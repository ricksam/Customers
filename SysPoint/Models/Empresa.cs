using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace SysPoint.Models
{
    public class Empresa : BaseEntity<Empresa>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public static Empresa Find(int Id)
        {
            using (var cx = new Context())
            {
                return cx.Query<Empresa>(
                    @"select 
                        Id
                       ,Nome
                       ,Endereco
                    from Empresa where Id = @Id", new { Id = Id }).FirstOrDefault();
            }
        }

        public static List<Empresa> List()
        {
            using (var cx = new Context())
            {
                return cx.Query<Empresa>(
                    @"select
                        Id
                       ,Nome 
                       ,Endereco 
                    from Empresa").ToList();
            }
        }

        private int Insert(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Empresa (
                        Nome,
                        Endereco
                    ) {0} values (
                        @Nome,
                        @Endereco
                    ) {1}", "Id"), this).Single();
        }

        private void Update()
        {
            using (var cx = new Context())
            {
                cx.Execute(
                    @"update Empresa set 
                        Nome=@Nome, 
                        Endereco=@Endereco 
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
                    @"delete from Empresa where Id = @Id", new { Id = Id });
            }
        }
    }
}
