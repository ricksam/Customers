using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;
using RckSoftwareMVC.Helpers;

namespace RckSoftwareMVC.Models.SysCam
{
    public class DataImage : BaseEntity<DataImage>
    {
        public int id { get; set; }
        public string image { get; set; }
        public string camera { get; set; }
        public string date { get; set; }

        public static string[] GroupData(int count, Context cx = null) {
            if (cx == null)
            { cx = new Context(); }

            if (cx.ConnectionType() == typeof(System.Data.SqlClient.SqlConnection)) {
                string[] dates = cx.Query<string>(
                string.Format(@"select 
                        top {0}
                       convert(varchar, date, 3)
                    from DataImage 
                    group by date", count)).ToArray();
                return dates;
            }

            if (cx.ConnectionType() == typeof(MySql.Data.MySqlClient.MySqlConnection)) {
                return cx.Query<string>(
                string.Format(@"select 
                       date
                    from DataImage 
                    group by date limit {0}", count)).ToArray();
            }
            return new string[] { };
        }

        public static string[] GroupCamera(Context cx = null) {
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<string>(
                @"select 
                       camera
                    from DataImage 
                    group by camera").ToArray();

            /*return cx.Query<DataImage>(
                    @"select 
                        id
                       ,image
                       ,camera
                       ,date
                    from DataImage where id = @id", new { id = id }).FirstOrDefault();*/
        }

        public static DataImage Find(int id, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<DataImage>(
                    @"select 
                        id
                       ,image
                       ,camera
                       ,date
                    from DataImage where id = @id", new { id = id }).FirstOrDefault();
        }

        public static DataImage Last(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            if (cx.ConnectionType() == typeof(System.Data.SqlClient.SqlConnection))
            {
                return cx.Query<DataImage>(
                    @"select 
                        top 1
                        id
                       ,image
                       ,camera
                       ,date
                    from DataImage 
                    where id = @id
                    order by id desc").FirstOrDefault();
            }

            if (cx.ConnectionType() == typeof(MySql.Data.MySqlClient.MySqlConnection))
            {
                return cx.Query<DataImage>(
                    @"select 
                        id
                       ,image
                       ,camera
                       ,date
                    from DataImage 
                    where id = @id
                    order by id desc
                    limit 1").FirstOrDefault();
            }

            return new DataImage();

            
        }

        public static List<DataImage> List(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<DataImage>(
                    @"select
                        id
                       ,image 
                       ,camera 
                       ,date 
                    from DataImage").ToList();
        }

        public static List<DataImage> List(string date, string camera, int id, int count, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            if (cx.ConnectionType() == typeof(System.Data.SqlClient.SqlConnection)) {
                return cx.Query<DataImage>(
                string.Format(@"select
                        top {0}
                        id
                       ,image 
                       ,camera 
                       ,date 
                    from DataImage
                    where convert(varchar, date, 3) = @date and camera = @camera and id > @id", count)
                    , new { date, camera, id }).ToList();
            }

            if (cx.ConnectionType() == typeof(MySql.Data.MySqlClient.MySqlConnection)) {
                return cx.Query<DataImage>(
                string.Format(@"select
                        id
                       ,image 
                       ,camera 
                       ,date 
                    from DataImage
                    where convert(varchar, date, 3) = @date and camera = @camera and id > @id
                    limit {0}", count)
                    , new { date, camera, id }).ToList();
            }

            return new List<DataImage>();
        }

        private int Insert(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into DataImage (
                        image,
                        camera,
                        date
                    ) {0} values (
                        @image,
                        @camera,
                        @date
                    ) {1}", "id"), this).Single();
        }

        private void Update(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            cx.Execute(
                    @"update DataImage set 
                        image=@image, 
                        camera=@camera, 
                        date=@date 
                    where id = @id", this);
        }

        public void Save(Context cx = null)
        {
            if (this.id == 0)
                this.id = Insert(cx);
            else
                Update(cx);
        }

        public static void Delete(int id, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            cx.Execute(@"delete from DataImage where id = @id", new { id = id });
        }

        public static void Delete(string date, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            cx.Execute(@"delete from DataImage where date = @date", new { date = Convert.ToDateTime(date).ToString("yyyy-MM-dd") });
        }
    }
}
