using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RckSoftwareMVC.Controllers
{
  public class SZOOldController : Controller
  {
    //
    // GET: /SZO/

    public ActionResult Index()
    {
      return View();
    }

    private lib.Entity.MySQL GetDatabase() 
    {
      /*string ConnectionString =
          string.Format(
            "Server={0};Database={1};Uid={2};Pwd={3};",
            new object[]
            {
              "187.45.196.220",
              "rcksoftware",
              "rcksoftware",
              "RCK6px2erjr"
            }
          );
      return new lib.Entity.MySQL(ConnectionString);*/

      return new lib.Entity.MySQL(System.Configuration.ConfigurationManager.ConnectionStrings["RCKConnection"].ToString());
    }

    public ActionResult RetornaFormasPagamento(string id, string TimeStamp)
    {
      lib.Class.JSON json = new lib.Class.JSON();
      return Content(json.Serialize((new SysZoo.dsSZO_FPG_FORMA_PAGAMENTO(GetDatabase())).List_TimeStamp((new lib.Class.Conversion()).ToDateTime(TimeStamp))));
    }

    public ActionResult RetornaOperadores(string id, string TimeStamp)
    {
      lib.Class.JSON json = new lib.Class.JSON();
      return Content(json.Serialize((new SysZoo.dsSZO_OPR_OPERADORES(GetDatabase())).List_TimeStamp((new lib.Class.Conversion()).ToDateTime(TimeStamp))));
    }

    public ActionResult RetornaIngressos(string id, string TimeStamp)
    {
      lib.Class.JSON json = new lib.Class.JSON();
      return Content(json.Serialize((new SysZoo.dsSZO_CTK_CADASTRO_TICKETS(GetDatabase())).List_TimeStamp((new lib.Class.Conversion()).ToDateTime(TimeStamp))));
    }

    [AcceptVerbs(HttpVerbs.Get)]
    public ActionResult EnviaKeepAlive(string id)
    {
      lib.Entity.MySQL db = GetDatabase();
      SysZoo.dsSZO_KPA_KEEP_ALIVE ds = new SysZoo.dsSZO_KPA_KEEP_ALIVE(db);

      SysZoo.SZO_KPA_KEEP_ALIVE kpa = new SysZoo.SZO_KPA_KEEP_ALIVE();
      kpa.KPA_IDENTIFICACAO = id;

      db.DbConnection.Open();
      System.Data.Common.DbTransaction transaction = db.DbConnection.BeginTransaction();
      try
      {
        ds.Save(kpa, transaction);

        if (kpa.KPA_CODIGO == 0)
        { kpa.KPA_CODIGO = db.ReturnLastID(transaction).ToInt(); }

        transaction.Commit();
      }
      catch
      { transaction.Rollback(); }
      finally
      {
        if (db.DbConnection.State != System.Data.ConnectionState.Closed)
        { db.DbConnection.Close(); }
      }

      return Content(kpa.KPA_CODIGO.ToString());
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult EnviaKeepAlive(string id, string Versao)
    {
      if (string.IsNullOrEmpty(Versao)&&Request.Form.Count!=0)
      { Versao = Request.Form[0].ToString(); }

      lib.Entity.MySQL db = GetDatabase();
      SysZoo.dsSZO_KPA_KEEP_ALIVE ds = new SysZoo.dsSZO_KPA_KEEP_ALIVE(db);

      SysZoo.SZO_KPA_KEEP_ALIVE kpa = new SysZoo.SZO_KPA_KEEP_ALIVE();
      kpa.KPA_IDENTIFICACAO = id;
      kpa.KPA_VERSAO = Versao;

      db.DbConnection.Open();
      System.Data.Common.DbTransaction transaction = db.DbConnection.BeginTransaction();
      try
      {
        ds.Save(kpa, transaction);

        if (kpa.KPA_CODIGO == 0)
        { kpa.KPA_CODIGO = db.ReturnLastID(transaction).ToInt(); }

        transaction.Commit();
      }
      catch
      { transaction.Rollback(); }
      finally
      {
        if (db.DbConnection.State != System.Data.ConnectionState.Closed)
        { db.DbConnection.Close(); }
      }

      return Content(kpa.KPA_CODIGO.ToString());
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult EnviaFormaPagamento(string id, SysZoo.SZO_FPG_FORMA_PAGAMENTO Forma) 
    {
      lib.Entity.MySQL db = GetDatabase();
      SysZoo.dsSZO_FPG_FORMA_PAGAMENTO ds = new SysZoo.dsSZO_FPG_FORMA_PAGAMENTO(db);
      Forma.FPG_CODIGO = ds.Get_FromMD5(Forma.FPG_MD5).FPG_CODIGO;

      db.DbConnection.Open();
      System.Data.Common.DbTransaction transaction = db.DbConnection.BeginTransaction();
      try
      {
        Forma.FPG_TIMESTAMP = DateTime.UtcNow;
        Forma.FPG_SINCRONIZADO = true;
        ds.Save(Forma, transaction);
        
        if (Forma.FPG_CODIGO == 0)
        { Forma.FPG_CODIGO = db.ReturnLastID(transaction).ToInt(); }
        
        transaction.Commit();
      }
      catch 
      { transaction.Rollback(); }
      finally 
      {
        if (db.DbConnection.State != System.Data.ConnectionState.Closed)
        { db.DbConnection.Close(); }
      }

      return Content(Forma.FPG_CODIGO.ToString());
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult EnviaOperador(string id, SysZoo.SZO_OPR_OPERADORES Operador)
    {
      lib.Entity.MySQL db = GetDatabase();
      SysZoo.dsSZO_OPR_OPERADORES ds = new SysZoo.dsSZO_OPR_OPERADORES(db);
      Operador.OPR_CODIGO = ds.Get_FromMD5(Operador.OPR_MD5).OPR_CODIGO;

      db.DbConnection.Open();
      System.Data.Common.DbTransaction transaction = db.DbConnection.BeginTransaction();
      try
      {
        Operador.OPR_TIMESTAMP = DateTime.UtcNow;
        Operador.OPR_SINCRONIZADO = true;
        ds.Save(Operador, transaction);

        if (Operador.OPR_CODIGO == 0)
        { Operador.OPR_CODIGO = db.ReturnLastID(transaction).ToInt(); }

        transaction.Commit();
      }
      catch
      { transaction.Rollback(); }
      finally
      {
        if (db.DbConnection.State != System.Data.ConnectionState.Closed)
        { db.DbConnection.Close(); }
      }

      return Content(Operador.OPR_CODIGO.ToString());
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult EnviaIngresso(string id, SysZoo.SZO_CTK_CADASTRO_TICKETS Ingresso)
    {
      lib.Entity.MySQL db = GetDatabase();
      SysZoo.dsSZO_CTK_CADASTRO_TICKETS ds = new SysZoo.dsSZO_CTK_CADASTRO_TICKETS(db);
      Ingresso.CTK_CODIGO = ds.Get_FromMD5(Ingresso.CTK_MD5).CTK_CODIGO;

      db.DbConnection.Open();
      System.Data.Common.DbTransaction transaction = db.DbConnection.BeginTransaction();
      try
      {
        Ingresso.CTK_TIMESTAMP = DateTime.UtcNow;
        Ingresso.CTK_SINCRONIZADO = true;
        ds.Save(Ingresso, transaction);

        if (Ingresso.CTK_CODIGO == 0)
        { Ingresso.CTK_CODIGO = db.ReturnLastID(transaction).ToInt(); }

        transaction.Commit();
      }
      catch
      { transaction.Rollback(); }
      finally
      {
        if (db.DbConnection.State != System.Data.ConnectionState.Closed)
        { db.DbConnection.Close(); }
      }

      return Content(Ingresso.CTK_CODIGO.ToString());
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult EnviaVenda(string id, SysZoo.SZO_VDA_VENDA Venda)
    {
      lib.Entity.MySQL db = GetDatabase();
      SysZoo.dsSZO_VDA_VENDA ds = new SysZoo.dsSZO_VDA_VENDA(db);
      Venda.VDA_CODIGO = ds.Get_FromMD5(Venda.VDA_MD5).VDA_CODIGO;

      db.DbConnection.Open();
      System.Data.Common.DbTransaction transaction = db.DbConnection.BeginTransaction();
      try
      {
        Venda.VDA_TIMESTAMP = DateTime.UtcNow;
        Venda.VDA_SINCRONIZADO = true;
        ds.Save(Venda, transaction);

        if (Venda.VDA_CODIGO == 0)
        { Venda.VDA_CODIGO = db.ReturnLastID(transaction).ToInt(); }

        transaction.Commit();
      }
      catch
      { transaction.Rollback(); }
      finally
      {
        if (db.DbConnection.State != System.Data.ConnectionState.Closed)
        { db.DbConnection.Close(); }
      }

      return Content(Venda.VDA_CODIGO.ToString());
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult EnviaItem(string id, SysZoo.SZO_VTK_VENDA_TICKETS Item)
    {
      lib.Entity.MySQL db = GetDatabase();
      SysZoo.dsSZO_VTK_VENDA_TICKETS ds = new SysZoo.dsSZO_VTK_VENDA_TICKETS(db);
      Item.VTK_CODIGO = ds.Get_FromMD5(Item.VTK_MD5).VTK_CODIGO;

      db.DbConnection.Open();
      System.Data.Common.DbTransaction transaction = db.DbConnection.BeginTransaction();
      try
      {
        Item.VTK_TIMESTAMP = DateTime.UtcNow;
        Item.VTK_SINCRONIZADO = true;
        ds.Save(Item, transaction);

        if (Item.VTK_CODIGO == 0)
        { Item.VTK_CODIGO = db.ReturnLastID(transaction).ToInt(); }

        transaction.Commit();
      }
      catch
      { transaction.Rollback(); }
      finally
      {
        if (db.DbConnection.State != System.Data.ConnectionState.Closed)
        { db.DbConnection.Close(); }
      }

      return Content(Item.VTK_CODIGO.ToString());
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult EnviaPagamento(string id, SysZoo.SZO_PGT_PAGAMENTO Pagamento)
    {
      lib.Entity.MySQL db = GetDatabase();
      SysZoo.dsSZO_PGT_PAGAMENTO ds = new SysZoo.dsSZO_PGT_PAGAMENTO(db);
      Pagamento.PGT_CODIGO = ds.Get_FromMD5(Pagamento.PGT_MD5).PGT_CODIGO;

      db.DbConnection.Open();
      System.Data.Common.DbTransaction transaction = db.DbConnection.BeginTransaction();
      try
      {
        Pagamento.PGT_TIMESTAMP = DateTime.UtcNow;
        Pagamento.PGT_SINCRONIZADO = true;
        ds.Save(Pagamento, transaction);

        if (Pagamento.PGT_CODIGO == 0)
        { Pagamento.PGT_CODIGO = db.ReturnLastID(transaction).ToInt(); }

        transaction.Commit();
      }
      catch
      { transaction.Rollback(); }
      finally
      {
        if (db.DbConnection.State != System.Data.ConnectionState.Closed)
        { db.DbConnection.Close(); }
      }

      return Content(Pagamento.PGT_CODIGO.ToString());
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult EnviaMovimentoCaixa(string id, SysZoo.SZO_MCX_MOVIMENTO_CAIXA Movimento)
    {
      lib.Entity.MySQL db = GetDatabase();
      SysZoo.dsSZO_MCX_MOVIMENTO_CAIXA ds = new SysZoo.dsSZO_MCX_MOVIMENTO_CAIXA(db);
      Movimento.MCX_CODIGO = ds.Get_FromMD5(Movimento.MCX_MD5).MCX_CODIGO;

      db.DbConnection.Open();
      System.Data.Common.DbTransaction transaction = db.DbConnection.BeginTransaction();
      try
      {
        Movimento.MCX_TIMESTAMP = DateTime.UtcNow;
        Movimento.MCX_SINCRONIZADO = true;
        ds.Save(Movimento, transaction);

        if (Movimento.MCX_CODIGO == 0)
        { Movimento.MCX_CODIGO = db.ReturnLastID(transaction).ToInt(); }

        transaction.Commit();
      }
      catch
      { transaction.Rollback(); }
      finally
      {
        if (db.DbConnection.State != System.Data.ConnectionState.Closed)
        { db.DbConnection.Close(); }
      }

      return Content(Movimento.MCX_CODIGO.ToString());
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult RelatorioAPK(string id)
    {
      string data = id;

      //string format = "%Y-%m-%d";
      string format = "%Y-%c-%e";

      lib.Entity.MySQL db = GetDatabase();

      int Interira = db.DbGet(
              string.Format(
                @"SELECT COUNT(VTK_CODIGO) AS QTDE 
                FROM SZO_VTK_VENDA_TICKETS 
                WHERE VTK_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
                AND DATE_FORMAT(VTK_DATA, '{0}') = {1} 
                AND VTK_DESCRICAO = 'INTEIRA'", format, db.DbQuoted(data))).ToInt();

      int Meia = db.DbGet(
            string.Format(
              @"SELECT COUNT(VTK_CODIGO) AS QTDE 
                FROM SZO_VTK_VENDA_TICKETS 
                WHERE VTK_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
                AND DATE_FORMAT(VTK_DATA, '{0}') = {1} 
                AND VTK_DESCRICAO = 'MEIA'", format, db.DbQuoted(data))).ToInt();

      int Isento = db.DbGet(
          string.Format(
            @"SELECT COUNT(VTK_CODIGO) AS QTDE 
                FROM SZO_VTK_VENDA_TICKETS 
                WHERE VTK_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
                AND DATE_FORMAT(VTK_DATA, '{0}') = {1} 
                AND VTK_DESCRICAO = 'ISENTO'", format, db.DbQuoted(data))).ToInt();

      decimal Vendas = db.DbGet(
          string.Format(
                @"SELECT SUM(VTK_VALOR) AS TOTAL
                FROM SZO_VTK_VENDA_TICKETS 
                WHERE VTK_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
                AND DATE_FORMAT(VTK_DATA, '{0}') = {1} ", format, db.DbQuoted(data))).ToInt();

      decimal Suprimento = db.DbGet(
          string.Format(
              @"SELECT SUM(MCX_VALOR) FROM SZO_MCX_MOVIMENTO_CAIXA  
              WHERE MCX_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
              AND DATE_FORMAT(MCX_DATA, '{0}') = {1} 
              AND MCX_TIPO = 'SUPRIMENTO'", format, db.DbQuoted(data))).ToDecimal();

      decimal Sangria = db.DbGet(
          string.Format(
              @"SELECT SUM(MCX_VALOR) FROM SZO_MCX_MOVIMENTO_CAIXA  
              WHERE MCX_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
              AND DATE_FORMAT(MCX_DATA, '{0}') = {1} 
              AND MCX_TIPO = 'SANGRIA'", format, db.DbQuoted(data))).ToDecimal();

      decimal Caixa = Vendas+Suprimento-Sangria;

      return Content(
        string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}",
          Interira.ToString("0"), 
          Meia.ToString("0"), 
          Isento.ToString("0"),
          Vendas.ToString("0.00").Replace(",","."),
          Suprimento.ToString("0.00").Replace(",", "."),
          Sangria.ToString("0.00").Replace(",", "."),
          Caixa.ToString("0.00").Replace(",", ".")));
    }

    public ActionResult RelatorioAPK2(string id)
    {
      string data = id;

      //string format = "%Y-%m-%d";
      string format = "%Y-%c-%e";

      lib.Entity.MySQL db = GetDatabase();

      int Interira = db.DbGet(
              string.Format(
                @"SELECT COUNT(VTK_CODIGO) AS QTDE 
                FROM SZO_VTK_VENDA_TICKETS 
                WHERE VTK_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
                AND DATE_FORMAT(VTK_DATA, '{0}') = {1} 
                AND VTK_DESCRICAO = 'INTEIRA'", format, db.DbQuoted(data))).ToInt();

      int Meia = db.DbGet(
            string.Format(
              @"SELECT COUNT(VTK_CODIGO) AS QTDE 
                FROM SZO_VTK_VENDA_TICKETS 
                WHERE VTK_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
                AND DATE_FORMAT(VTK_DATA, '{0}') = {1} 
                AND VTK_DESCRICAO = 'MEIA'", format, db.DbQuoted(data))).ToInt();

      int Isento = db.DbGet(
          string.Format(
            @"SELECT COUNT(VTK_CODIGO) AS QTDE 
                FROM SZO_VTK_VENDA_TICKETS 
                WHERE VTK_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
                AND DATE_FORMAT(VTK_DATA, '{0}') = {1} 
                AND VTK_DESCRICAO = 'ISENTO'", format, db.DbQuoted(data))).ToInt();

      decimal Vendas = db.DbGet(
          string.Format(
                @"SELECT SUM(VTK_VALOR) AS TOTAL
                FROM SZO_VTK_VENDA_TICKETS 
                WHERE VTK_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
                AND DATE_FORMAT(VTK_DATA, '{0}') = {1} ", format, db.DbQuoted(data))).ToInt();

      decimal Suprimento = db.DbGet(
          string.Format(
              @"SELECT SUM(MCX_VALOR) FROM SZO_MCX_MOVIMENTO_CAIXA  
              WHERE MCX_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
              AND DATE_FORMAT(MCX_DATA, '{0}') = {1} 
              AND MCX_TIPO = 'SUPRIMENTO'", format, db.DbQuoted(data))).ToDecimal();

      decimal Sangria = db.DbGet(
          string.Format(
              @"SELECT SUM(MCX_VALOR) FROM SZO_MCX_MOVIMENTO_CAIXA  
              WHERE MCX_IDENTIFICACAO NOT IN ('RICKSAM', 'ATLANTIS') 
              AND DATE_FORMAT(MCX_DATA, '{0}') = {1} 
              AND MCX_TIPO = 'SANGRIA'", format, db.DbQuoted(data))).ToDecimal();

      decimal Caixa = Vendas + Suprimento - Sangria;

      return Content(
        string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}",
          Interira.ToString("0"),
          Meia.ToString("0"),
          Isento.ToString("0"),
          Vendas.ToString("0.00").Replace(",", "."),
          Suprimento.ToString("0.00").Replace(",", "."),
          Sangria.ToString("0.00").Replace(",", "."),
          Caixa.ToString("0.00").Replace(",", ".")));
    }

    public ActionResult MaquinasAtivas()
    {
      lib.Entity.MySQL db = GetDatabase();

      lib.Class.Conversion cnv = new lib.Class.Conversion();
      System.Data.DataTable dt = db.DbGetDataTable(
        @"SELECT KPA_IDENTIFICACAO, KPA_VERSAO, SEC_TO_TIME(TIME_TO_SEC(MAX(KPA_TIMESTAMP))+60*60*-3) AS HORA FROM SZO_KPA_KEEP_ALIVE 
          WHERE CAST(KPA_TIMESTAMP AS DATE) = CAST(NOW() AS DATE)
          GROUP BY KPA_IDENTIFICACAO, KPA_VERSAO
          ORDER BY KPA_CODIGO DESC"
        /*@"SELECT KPA_IDENTIFICACAO, SEC_TO_TIME(TIME_TO_SEC(MAX(KPA_TIMESTAMP))+60*60*-3) AS HORA, MAX(KPA_VERSAO) AS KPA_VERSAO FROM SZO_KPA_KEEP_ALIVE
          GROUP BY KPA_IDENTIFICACAO
          HAVING MAX(KPA_TIMESTAMP) > NOW() "*/);

      string result = "";
      for (int i = 0; i < dt.Rows.Count; i++)
      { result += (i == 0 ? "" : "|") + string.Format("{0} ({1}) {2}", 
        dt.Rows[i]["KPA_IDENTIFICACAO"].ToString(), 
        dt.Rows[i]["KPA_VERSAO"].ToString(),
        cnv.ToDateTime(DateTime.Now.ToString("dd/MM/yy")+" "+ dt.Rows[i]["HORA"].ToString()).ToString("HH:mm"));
      }

      return Content(result);
    }
  }
}
