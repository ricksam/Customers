using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysPoint.Helper
{
    public static class Utility
    {
        public static DateTime BrazilianDatetimeNow()
        {
            var info = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            DateTimeOffset localServerTime = DateTimeOffset.Now;
            DateTimeOffset brazilTime = TimeZoneInfo.ConvertTime(localServerTime, info);
            return Convert.ToDateTime(brazilTime.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        public static string GetVersion()
        {
            System.Reflection.Assembly entryPoint = System.Reflection.Assembly.GetExecutingAssembly();
            System.Reflection.AssemblyName entryPointName = entryPoint.GetName();
            return entryPointName.Version.ToString();
        }

        public static string md5(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            { sb.Append(hash[i].ToString("x2")); }
            return sb.ToString();
        }

        public static System.Web.HttpRequest Request { get { return System.Web.HttpContext.Current.Request; } }

        public static System.Web.SessionState.HttpSessionState Session { get { return System.Web.HttpContext.Current.Session; } }
    }
}