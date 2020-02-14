using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace SysPoint.Models
{
    public class Coordenadas {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Qtde { get; set; }
    }

    public class RegistroPonto : BaseEntity<RegistroPonto>
    {
        public int Id { get; set; }
        public int Id_Colaborador { get; set; }
        //public string Foto { get; set; }
        public DateTime Registro { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Log { get; set; }
        public int Id_Foto { get; set; }
        public Colaboradores Colaborador { get; set; }

        public static RegistroPonto Find(int Id)
        {
            using (var cx = new Context())
            {
                return cx.Query<RegistroPonto>(
                    @"select 
                        Id
                       ,Id_Colaborador
                       ,Registro
                       ,Latitude
                       ,Longitude
                       ,Log
                       ,Id_Foto
                    from RegistroPonto where Id = @Id", new { Id = Id }).FirstOrDefault();
            }
        }

        public static List<RegistroPonto> List(string Data = "", string Local = "", string Colaborador = "")
        {
            using (var cx = new Context())
            {
                List<string> list = new List<string>();
                if (!string.IsNullOrEmpty(Data))
                {
                    //list.Add(string.Format(" DATE_FORMAT(r.Registro, '%d/%m/%Y') = {0} ", Quoted(Data)));
                    DateTime dt = Convert.ToDateTime(Data);
                    list.Add(string.Format("cast(r.Registro as date) = {0}", Quoted(dt.ToString("yyyy-MM-dd"))));
                }

                if (!string.IsNullOrEmpty(Colaborador))
                {
                    list.Add(string.Format(" c.Nome = {0} ", Quoted(Colaborador)));
                }

                string condition = "";

                if (list.Count != 0)
                {
                    condition = " where " + String.Join(" and ", list);
                }


                return cx.Connection.Query<RegistroPonto, Colaboradores, RegistroPonto>(
                    string.Format(
                    @"select
                        r.*, c.* 
                    from RegistroPonto r
                    inner join Colaboradores c on c.Id = r.Id_Colaborador 
                    {0}
                    order by r.Id desc", condition), (r, c) => { r.Colaborador = c; return r; }).ToList();
            }
        }

        public static List<Coordenadas> ListCoordenadas(DateTime Registro)
        {
            using (var cx = new Context())
            {
                return cx.Connection.Query<Coordenadas>(
                    string.Format(
                    @"select 
                        round(Latitude,3) as Latitude, 
                        round(Longitude,3) as Longitude, 
                        count(Id) as Qtde 
                    from RegistroPonto
                    where DATE_FORMAT(Registro, '%d/%m/%Y') = {0}
                    group by round(Latitude,3), round(Longitude,3)", 
                    Quoted(Registro.ToString("dd/MM/yyyy")))).ToList();
            }
        }
        

        public static List<string> ListDatas()
        {
            using (var cx = new Context())
            {
                return cx.Connection.Query<string>(
                    @"select cast(Registro as date) as Datas from RegistroPonto
                    group by cast(Registro as date)
                    order by 1 desc").ToList();
            }
        }

        public static List<string> ListColaboradores()
        {
            using (var cx = new Context())
            {
                return cx.Connection.Query<string>(
                    @"select c.Nome from RegistroPonto r
                    inner join Colaboradores c on c.Id = r.Id_Colaborador 
                    group by c.Nome
                    order by 1 ").ToList();
            }
        }

        private int Insert(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into RegistroPonto (
                        Id_Colaborador,
                        Registro,
                        Latitude,
                        Longitude,
                        Log,
                        Id_Foto
                    ) {0} values (
                        @Id_Colaborador,
                        @Registro,
                        @Latitude,
                        @Longitude,
                        @Log,
                        @Id_Foto
                    ) {1}", "Id"), this).Single();
        }

        private void Update()
        {
            using (var cx = new Context())
            {
                cx.Execute(
                    @"update RegistroPonto set 
                        Id_Colaborador=@Id_Colaborador, 
                        Registro=@Registro, 
                        Latitude=@Latitude, 
                        Longitude=@Longitude, 
                        Log=@Log, 
                        Id_Foto=@Id_Foto 
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
                    @"delete from RegistroPonto where Id = @Id", new { Id = Id });
            }
        }
    }
}
