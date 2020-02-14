using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace SysPoint.Models
{
    public class Fotos : BaseEntity<Fotos>
    {
        public int Id { get; set; }
        public string Foto { get; set; }
        public DateTime Data { get; set; }

        public static Fotos Find(int Id)
        {
            using (var cx = new Context())
            {
                return cx.Query<Fotos>(
                    @"select 
                        Id
                       ,Foto
                       ,Data
                    from Fotos where Id = @Id", new { Id = Id }).FirstOrDefault();
            }
        }

        public static List<Fotos> List()
        {
            using (var cx = new Context())
            {
                return cx.Query<Fotos>(
                    @"select
                        Id
                       ,Foto 
                       ,Data 
                    from Fotos").ToList();
            }
        }

        private int Insert(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into Fotos (
                        Foto,
                        Data
                    ) {0} values (
                        @Foto,
                        @Data
                    ) {1}", "Id"), this).Single();
        }

        private void Update()
        {
            using (var cx = new Context())
            {
                cx.Execute(
                    @"update Fotos set 
                        Foto=@Foto, 
                        Data=@Data 
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
                    @"delete from Fotos where Id = @Id", new { Id = Id });
            }
        }
    }
}
