using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RckSoftware
{
  public class Utilities
  {
    public static string Callback()
    {
      System.Configuration.AppSettingsReader reader = new System.Configuration.AppSettingsReader();
      return (new lib.Class.Conversion()).ToString(reader.GetValue("Callback", (typeof(string))));
    }
    
    public static lib.Database.Connection GetDatabase() 
    {
      lib.Class.Conversion cnv = new lib.Class.Conversion();
      System.Configuration.AppSettingsReader reader = new System.Configuration.AppSettingsReader();

      string Server = cnv.ToString(reader.GetValue("Server", (typeof(string))));
      string Database = cnv.ToString(reader.GetValue("Database", (typeof(string))));
      string User = cnv.ToString(reader.GetValue("User", (typeof(string))));
      string Password = cnv.ToString(reader.GetValue("Password", (typeof(string))));

      lib.Database.Connection cnn = new lib.Database.Connection();
      cnn.Connect(lib.Database.Drivers.enmConnection.MySql,
        new lib.Database.Drivers.InfoConnection(Server, Database, User, Password));

      return cnn;
    }
    
    public static void AddToken(string Code, string Token, string Nome, string Email)
    {
      lib.Database.Connection cnn = GetDatabase();

      if (string.IsNullOrEmpty(GetToken(Code)))
      {
        cnn.QueryParam.Add(Code);
        cnn.QueryParam.Add(Token);
        cnn.QueryParam.Add(Nome);
        cnn.QueryParam.Add(Email);
        cnn.Exec("INSERT INTO CONVITE (CODIGO, TOKEN, NOME, EMAIL) VALUES ({0}, {1}, {2}, {3})");
      }
      else 
      {
        cnn.QueryParam.Add(Code);
        cnn.QueryParam.Add(Token);
        cnn.QueryParam.Add(Nome);
        cnn.QueryParam.Add(Email);
        cnn.Exec("UPDATE CONVITE SET TOKEN = {1}, NOME = {2}, EMAIL = {3} WHERE CODIGO = {0}");
      }
    }
    
    public static string GetToken(string Code)
    {
      lib.Database.Connection cnn = GetDatabase();
      cnn.QueryParam.Add(Code);
      return cnn.Sql("SELECT TOKEN FROM CONVITE WHERE CODIGO = {0}").ToString();
    }
    
    public static string GetName(string Code)
    {
      lib.Database.Connection cnn = GetDatabase();
      cnn.QueryParam.Add(Code);
      return cnn.Sql("SELECT NOME FROM CONVITE WHERE CODIGO = {0}").ToString();
    }
    
    public static string RemoverCode(string Code)
    {
      lib.Database.Connection cnn = GetDatabase();
      cnn.QueryParam.Add(Code);
      return cnn.Exec("DELETE FROM CONVITE WHERE CODIGO = {0}").ToString();
    }
    
    public static ConviteCadastrado[] RetornaConvitesCadastrados() 
    {
      lib.Database.Connection cnn = GetDatabase();
      System.Data.DataTable dt = cnn.GetDataTable("SELECT * FROM CONVITE");

      List<ConviteCadastrado> lst = new List<ConviteCadastrado>();
      for (int i = 0; i < dt.Rows.Count; i++)
      {
        ConviteCadastrado c = new ConviteCadastrado();
        c.Code = dt.Rows[i]["CODIGO"].ToString();
        c.Nome = dt.Rows[i]["NOME"].ToString();
        c.Email = dt.Rows[i]["EMAIL"].ToString();
        c.Token = dt.Rows[i]["TOKEN"].ToString();
        lst.Add(c);
      }
      return lst.ToArray();
    }
  }

  public class ConviteCadastrado
  {
    public string Code{get;set;}
    public string Nome{get;set;}
    public string Email{get;set;}
    public string Token{get;set;}
  }
}

