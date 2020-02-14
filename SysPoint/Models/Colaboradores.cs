using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace SysPoint.Models
{
    public class Colaboradores : BaseEntity<Colaboradores>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Unidade { get; set; }
        public string Turno { get; set; }
        public int Id_Empresa { get; set; }
        public int Id_Supervisor { get; set; }

        public Empresa Empresa { get; set; }
        public Supervisor Supervisor { get; set; }

        public static Colaboradores Find(int Id)
        {
            using (var cx = new Context())
            {
                return cx.Query<Colaboradores>(
                    @"select * from Colaboradores where Id = @Id", new { Id }).FirstOrDefault();
            }
        }

        public static List<Colaboradores> List()
        {
            using (var cx = new Context())
            {
                return cx.Connection.Query<Colaboradores,Empresa, Supervisor, Colaboradores>(
                    @"select c.*, e.*, s.* from Colaboradores c
                        left outer join Empresa e on e.Id = c.Id_Empresa
                        left outer join Supervisor s on s.Id = c.Id_Supervisor",
                    (c, e, s)=> {
                        c.Empresa = e;
                        c.Supervisor = s;
                        return c; }).ToList();
            }
        }

        private int Insert(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Colaboradores (
                        Nome,
                        Senha,
                        Unidade,
                        Turno,
                        Id_Empresa,
                        Id_Supervisor
                    ) {0} values (
                        @Nome,
                        @Senha,
                        @Unidade,
                        @Turno,
                        @Id_Empresa,
                        @Id_Supervisor
                    ) {1}", "Id"), this).Single();
        }

        private void Update()
        {
            using (var cx = new Context())
            {
                cx.Execute(
                    @"update Colaboradores set 
                        Nome=@Nome, 
                        Senha=@Senha, 
                        Unidade=@Unidade, 
                        Turno=@Turno, 
                        Id_Empresa=@Id_Empresa, 
                        Id_Supervisor=@Id_Supervisor 
                    where Id = @Id", this);
            }
        }

        public void Save()
        {
            if (this.Id == 0)
                this.Id = Insert();
            else
                Update();
        }

        public static void Delete(int Id)
        {
            using (var cx = new Context())
            {
                cx.Execute(
                    @"delete from Colaboradores where Id = @Id", new { Id = Id });
            }
        }
    }
}