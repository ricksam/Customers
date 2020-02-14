using Dapper;
using System;
using System.Linq;
using System.Collections.Generic;

namespace SysPoint.Models
{
    public class LogError : BaseEntity<LogError>
    {
        public int Id { get; set; }
        public DateTime DtLog { get; set; }
        public string Method { get; set; }
        public int Id_User { get; set; }
        public string Request { get; set; }
        public string Error { get; set; }

        public static LogError Find(int Id)
        {
            using (var cx = new Context())
            {
                return cx.Query<LogError>(
                    @"select 
                        Id
                       ,DtLog
                       ,Method
                       ,Id_User
                       ,Request
                       ,Error
                    from LogError where Id = @Id", new { Id = Id }).FirstOrDefault();
            }
        }

        public static List<LogError> List()
        {
            using (var cx = new Context())
            {
                return cx.Query<LogError>(
                    @"select
                        Id
                       ,DtLog 
                       ,Method 
                       ,Id_User 
                       ,Request 
                       ,Error 
                    from LogError").ToList();
            }
        }

        private int Insert(Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<int>(
                cx.PrepareInsert(
                    @"insert into LogError (
                        DtLog,
                        Method,
                        Id_User,
                        Request,
                        Error
                    ) {0} values (
                        @DtLog,
                        @Method,
                        @Id_User,
                        @Request,
                        @Error
                    ) {1}", "Id"), this).Single();
        }

        private void Update()
        {
            using (var cx = new Context())
            {
                cx.Execute(
                    @"update LogError set 
                        DtLog=@DtLog, 
                        Method=@Method, 
                        Id_User=@Id_User, 
                        Request=@Request, 
                        Error=@Error 
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
                    @"delete from LogError where Id = @Id", new { Id = Id });
            }
        }

        public static int GravaLogErro(string Method, string Request, Exception ex)
        {
            try
            {
                return GravaLogErro(
                Method,
                Request,
                (SysPoint.Helper.AppContext.UsuarioLogado ? SysPoint.Helper.AppContext.Usuario.Id : 0),
                ex);
            }
            catch
            {
                return 0;
            }

        }

        public static int GravaLogErro(string Method, string Request, int Id_User, Exception ex)
        {
            try
            {
                SysPoint.Models.LogError _err = new SysPoint.Models.LogError();

                string error = ex.Message + " " + ex.StackTrace;
                if (ex.InnerException != null)
                {
                    error += " InnerException.Message : " + ex.InnerException.Message + " " + ex.InnerException.StackTrace;
                }


                _err.Method = Method;
                _err.Id_User = Id_User;
                _err.Error = error;
                _err.DtLog = DateTime.Today;
                _err.Request = Request;
                _err.Save();

                return _err.Id;
            }
            catch { return 0; }
        }
    }
}
