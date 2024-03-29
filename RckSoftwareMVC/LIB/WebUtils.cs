﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.IO;
using System.Threading;

namespace lib.Class
{
  public class WebUtils
  {
    public WebUtils() 
    {
      InternetOn = false;
      InternetVerify = false;
    }
    
    private string VerifyLink { get; set; }
    private bool InternetOn { get; set; }
    private bool InternetVerify { get; set; }

    #region void InvestigaInternet()
    void InvestigaInternet()
    {
      try
      {
        //GetWebResponse("http://ricksam.net84.net/");
        GetWebResponse(VerifyLink);
        InternetOn = true;
      }
      catch
      { InternetOn = false; }

      InternetVerify = false;
    }
    #endregion

    #region public bool InternetOnLine(string VerifyLink)
    public bool InternetOnLine(string VerifyLink)
    {
      /*
      // Busca OnLine
      try
      {
        GetWebResponse(VerifyLink);
        return true;
      }
      catch
      { return false; }*/

      
      // Off Line com thread
      InternetVerify = true;
      this.VerifyLink = VerifyLink;

      Thread tr = new Thread(new ThreadStart(InvestigaInternet));
      tr.Start();

      for (int i = 0; i < 2000 && InternetVerify; i++)
      { System.Threading.Thread.Sleep(10); }

      return InternetOn;
    }
    #endregion
                
    #region public static string GetWebResponse(string Url)
    public static string GetWebResponse(string Url)
    {
      return GetWebResponse(Url, "", "application/x-www-form-urlencoded");
    }
    #endregion

    #region public static string GetWebResponse(string Url, string PostData)
    public static string GetWebResponse(string Url, string PostData, string ContentType = "application/x-www-form-urlencoded")
    { return GetWebResponse(Url, PostData, ContentType, Encoding.Default); }
    #endregion

    #region public static string GetWebResponse(string Url, string PostData)
    public static string GetWebResponse(string Url, string PostData, string ContentType,Encoding enc, int Timeout = 100000)
    {
      System.Net.HttpWebResponse rp =null;
      System.IO.StreamReader sr =null;
      try
      {
        System.Net.HttpWebRequest rq = ((System.Net.HttpWebRequest)System.Net.WebRequest.Create(Url));
        rq.Timeout = Timeout;
        if (!string.IsNullOrEmpty(PostData))
        {
          rq.Method = "POST";
          rq.ContentType = ContentType;
          StreamWriter rw = new StreamWriter(rq.GetRequestStream());
          rw.Write(PostData);
          rw.Close();
          rw = null;
        }

        rp = (System.Net.HttpWebResponse)rq.GetResponse();
        sr = new System.IO.StreamReader(rp.GetResponseStream(), enc);
        return sr.ReadToEnd();
      }
      finally 
      {
        if (rp != null)
        { rp.Close(); }

        if (sr != null)
        { sr.Close(); }

        rp = null;
        sr = null;
      }
    }
    /*public static string GetWebResponse(string Url, byte[] PostDataArray)
    {
      System.Net.HttpWebResponse rp = null;
      System.IO.StreamReader sr = null;
      try
      {
        System.Net.HttpWebRequest rq = ((System.Net.HttpWebRequest)System.Net.WebRequest.Create(Url));

        if (PostDataArray != null && PostDataArray.Length != 0)
        {
          rq.Method = "POST";
          rq.ContentType = "application/x-www-form-urlencoded";
          Stream rw = rq.GetRequestStream();
          rw.Write(PostDataArray, 0, PostDataArray.Length);
          rw.Close();
          rw = null;
        }

        rp = (System.Net.HttpWebResponse)rq.GetResponse();
        sr = new System.IO.StreamReader(rp.GetResponseStream());
        return sr.ReadToEnd();
      }
      finally
      {
        if (rp != null)
        { rp.Close(); }

        if (sr != null)
        { sr.Close(); }

        rp = null;
        sr = null;
      }
    }*/
    #endregion

    #region public static string GetRemoteIP()
    public static string GetRemoteIP()
    {
      try
      {
        // exemple: <html><head><title>Current IP Check</title></head><body>Current IP Address: 187.115.128.126</body></html>
        //string content = GetWebResponse("http://checkip.dyndns.org/");
        //int idx = content.IndexOf("Current IP Address:");
        //content = content.Remove(0, idx + 20);
        //return content.Substring(0, content.IndexOf("</"));

        // Mas enquanto tiver o locaweb
        return GetWebResponse("http://www.rcksoftware.com.br/service/myip.php");
      }
      catch { return "0.0.0.0"; }
    }
    #endregion

    #region public static DateTime GetRightTime()
    public static DateTime GetRightTime() 
    {
      try
      {
        string source = GetWebResponse("http://www.horacerta.com.br/index.php?city=sao_paulo");
        string search = "<input name=\"initial_date\" type=\"hidden\" value=\"";
        int idx = source.IndexOf(search);
        if (idx != -1)
        {
          source = source.Remove(0, idx + search.Length);
          int idx_fim = source.IndexOf("\" />");
          string sval_hora = source.Substring(0, idx_fim);

          string[] campos = sval_hora.Split(new char[] { ' ' });
          return Convert.ToDateTime(string.Format("{0}-{1}-{2} {3}:{4}:{5}", campos));
        }
        return DateTime.Now;
      }
      catch { return DateTime.Now; }
    }
    #endregion

    #region public static Mail GetMailDeveloper()
    /// <summary>
    /// Para GMAIL deve-se usar a configuração abaixo e habilitar aplicativos menos seguros
    /// smtp.UseDefaultCredentials = false;
    /// https://www.google.com/settings/u/2/security/lesssecureapps
    /// </summary>
    /// <returns></returns>
    public static Mail GetMailDeveloper()
    {
        if (System.Configuration.ConfigurationManager.AppSettings["EMAIL_SMTP"] == null)
        { return new Mail("smtp.gmail.com", "contatorcksoftware@gmail.com.br", "contatorcksoftware", true, true, 587); }
        else
        {
            Conversion cnv = new Conversion();
            return new Mail(
                System.Configuration.ConfigurationManager.AppSettings["EMAIL_SMTP"].ToString(),
                System.Configuration.ConfigurationManager.AppSettings["EMAIL_User"].ToString(),
                System.Configuration.ConfigurationManager.AppSettings["EMAIL_Password"].ToString(),
                cnv.ToBool(System.Configuration.ConfigurationManager.AppSettings["EMAIL_SSL"]),
                cnv.ToBool(System.Configuration.ConfigurationManager.AppSettings["EMAIL_Authentication"]),
                cnv.ToInt(System.Configuration.ConfigurationManager.AppSettings["EMAIL_Port"])
                );
        }
    }
    #endregion

    [System.Runtime.InteropServices.DllImport("sensapi.dll")]
    public static extern bool IsNetworkAlive(out int flags);

    public static bool IsNetworkAlive() 
    {
      return System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
      //int flags;
      //bool connected = IsNetworkAlive(out flags);
      //return flags == 1 && connected;
    }

    public static string ConvertHtmlUTF8(string s)
    {
      string r = "";
      for (int i = 0; i < s.Length; i++)
      { r += ((int)s[i] < 32 || (int)s[i] > 127 ? string.Format("&#{0};", (int)s[i]) : s[i].ToString()); }
      return r;
    }
  }
}
