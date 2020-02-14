using Dapper;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace SysPoint.Models
{
    public class Context : IDisposable
    {

        private IDbConnection _conn { get; set; }

        public IDbConnection Connection { get { return _conn;  } }

        public IEnumerable<T> Query<T>(
            string sql, object param = null)
        {
            try
            {
                return _conn.Query<T>(sql, param);
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public int Execute(string sql, object param = null)
        {
            return _conn.Execute(sql, param);
        }
        /// <summary>
        /// Create a new Sql database connection
        /// </summary>
        /// <param name="connString">The name of the connection string</param>
        public Context()
        {
            if (_conn == null)
            {
                string cs = @"Server=tcp:dbrcksoftware.database.windows.net,1433;Initial Catalog=dbDEra;Persist Security Info=False;User ID=dera;Password=RIV@ess01;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                //_conn = new MySql.Data.MySqlClient.MySqlConnection(cs);
                _conn = new System.Data.SqlClient.SqlConnection(cs);
            }
        }

        public string PrepareInsert(string sql_insert, string primarykey_field)
        {
            if (_conn is System.Data.SqlClient.SqlConnection)
            {
                return string.Format(sql_insert, "OUTPUT Inserted." + primarykey_field, "");
            }
            else if (_conn is MySql.Data.MySqlClient.MySqlConnection)
            {
                return string.Format(sql_insert, "", ";SELECT LAST_INSERT_ID()");
            }

            //sqlite: ";select last_insert_rowid()"

            return sql_insert;
        }

        /// <summary>
        /// Close and dispose of the database connection
        /// </summary>
        public void Dispose()
        {
            if (_conn != null)
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                    _conn.Dispose();
                }
                _conn = null;
            }
        }
        public static int LocalGMT()
        {
            var info = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            return info.BaseUtcOffset.Hours;//HttpContext.Current.Request.ClientCertificate.ValidFrom.Subtract(DateTime.UtcNow).Hours;
        }
        public static DateTime GetLocalData(DateTime datetime)
        {
            if (datetime != DateTime.MinValue)
            {
                return datetime.AddHours(LocalGMT());
            }
            return DateTime.MinValue;
        }
        public static DateTime? GetLocalData(DateTime? datetime)
        {
            if (datetime != null)
            {
                return (datetime ?? DateTime.MinValue).AddHours(LocalGMT());
            }
            return null;
        }
    }
}