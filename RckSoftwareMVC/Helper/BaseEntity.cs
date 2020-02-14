using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Dapper;
using System.Linq.Expressions;

namespace RckSoftware
{
    public class BaseEntity<T>
    {
        public void SetFieldValue(string Name, object Value)
        {
            FieldInfo info = this.GetType().GetField(Name);
            if (info != null && !info.IsStatic)
            {
                info.SetValue(this, Value);
            }
        }

        public void SetPropertyValue(string Name, object Value)
        {
            PropertyInfo info = this.GetType().GetProperty(Name);
            if (info != null && info.CanWrite)
            {
                info.SetValue(this, Value, null);
            }
        }

        public void SetAttributeValue(string Name, object Value)
        {
            SetFieldValue(Name, Value);
            SetPropertyValue(Name, Value);
        }

        public void Assign(object o)
        {
            if (o == null)
            {
                return;
            }

            FieldInfo[] Fields = o.GetType().GetFields();
            PropertyInfo[] Properties = o.GetType().GetProperties();

            for (int i = 0; i < Fields.Length; i++)
            { SetFieldValue(Fields[i].Name, Fields[i].GetValue(o)); }

            for (int i = 0; i < Properties.Length; i++)
            {
                string name = Properties[i].Name;
                object value = Properties[i].GetValue(o, null);
                SetPropertyValue(name, value);
            }
        }

        public static string Quoted(string s)
        {
            if (!string.IsNullOrEmpty(s))
            { return string.Format("'{0}'", s.Replace("'", "''")); }
            else
            { return "''"; }
        }

        public static string[] GetAttributes(object _o)
        {
            List<string> lst = new List<string>();
            string[] fields = _o.GetType().GetFields().Select(q => q.Name).ToArray<string>();
            string[] properties = _o.GetType().GetProperties().Select(q => q.Name).ToArray<string>();
            lst.AddRange(fields);
            lst.AddRange(properties);
            return lst.ToArray();
        }

        public object GetFieldValue(string Name)
        {
            return GetFieldValue(this, Name);
        }

        private static object GetFieldValue(object _o, string Name)
        {
            FieldInfo field = _o.GetType().GetField(Name);

            if (field != null)
            { return field.GetValue(_o); }

            return null;
        }

        public object GetPropertyValue(string Name)
        {
            return GetPropertyValue(this, Name);
        }

        private static object GetPropertyValue(object _o, string Name)
        {
            PropertyInfo property = _o.GetType().GetProperty(Name);

            if (property != null)
            { return property.GetValue(_o, null); }

            return null;
        }

        public object GetAttributeValue(string Name)
        {
            FieldInfo field = this.GetType().GetField(Name);

            if (field != null)
            { return field.GetValue(this); }

            PropertyInfo property = this.GetType().GetProperty(Name);

            if (property != null)
            { return property.GetValue(this, null); }

            return null;
        }

        private static string getCondition(object condition)
        {
            string[] attrs = GetAttributes(condition);

            string result = "";
            foreach (var item in attrs)
            {
                result += (string.IsNullOrEmpty(result) ? "" : " and ") + string.Format("{0} = @{0}", item);
            }
            return "where " + result;
        }

        public static IEnumerable<T> Where(object condition, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            return cx.Query<T>(
                    @"select * 
                    from " + string.Format("{0}", typeof(T).Name) + " " + getCondition(condition), condition);
        }

        public static T First(object condition)
        {
            //return Where(condition).First();
            return FirstOrDefault(condition);
        }

        public static T FirstOrDefault(object condition)
        {
            var entity = Where(condition).FirstOrDefault();
            if (entity == null)
            { entity = Activator.CreateInstance<T>(); }
            return entity;
        }

        public static int Count(object condition)
        {
            return Where(condition).ToList().Count;
        }

        /*
        public static void Delete(object condition, Context cx = null)
        {
            if (cx == null)
            { cx = new Context(); }

            cx.Execute(
                    @"delete from " + string.Format("[{0}]", typeof(T).Name) + " " + getCondition(condition), condition);
        }*/

        private static string getDbValue(object obj)
        {
            if (obj == null)
            { return "null"; }

            if (obj is bool)
            {
                return Convert.ToBoolean(obj) ? "1" : "0";
            }

            if (obj is int || obj is long)
            {
                return Convert.ToInt32(obj).ToString();
            }

            if (obj is double || obj is float || obj is decimal)
            {
                return Convert.ToDouble(obj).ToString("0.0000").Replace(",", ".");
            }

            if (obj is DateTime)
            {
                return Quoted(Convert.ToDateTime(obj).ToString("yyyy-MM-dd HH:mm:ss"));
            }

            return Quoted(obj.ToString());
        }

        public static string MountSQL(string sql, object _o)
        {
            string[] sqlfields = getSQLFields(sql);
            foreach (var item in sqlfields)
            {
                string value = getDbValue(GetPropertyValue(_o, item));
                sql = sql.Replace("@" + item, value);
            }
            return sql;
        }

        private static string[] getSQLFields(string sql)
        {
            List<string> fields = new List<string>();
            while (sql.Contains("@"))
            {
                sql = sql.Remove(0, sql.IndexOf("@") + 1);
                string field = getSQLField(sql);
                fields.Add(field);
            }
            return fields.ToArray();
        }

        private static string getSQLField(string sql)
        {
            string field = "";
            foreach (char item in sql)
            {
                if (char.IsNumber(item) || char.IsLetter(item) || item == '@' || item == '_')
                {
                    field += item.ToString();
                }
                else { break; }
            }
            return field;
        }

        protected string SetMaxLength(string s, int max_legth)
        {
            if (!string.IsNullOrEmpty(s) && s.Length > max_legth)
            {
                return s.Substring(0, max_legth);
            }
            else
            {
                return s;
            }
        }
    }
}

