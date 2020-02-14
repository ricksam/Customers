using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Database;
using lib.Visual;
using lib.Visual.Forms;
using lib.Database.Drivers;
using SqlWebReport;
using lib.Class;

namespace Folha_Marcelo
{
  public class Utilities
  {
    public static void Start()
    {
      string DATABASE_FILE_ADDRESS = lib.Visual.Functions.GetDirAppCondig() + "\\Address.sqlite";
      string DATABASE_FILE = lib.Visual.Functions.GetDirAppCondig() + "\\Database.sqlite";
      string BKP_DIRECTORY = lib.Visual.Functions.GetDirAppCondig() + "\\BKP";

      FazerBackup(BKP_DIRECTORY, DATABASE_FILE);

      FormError = new FormError();

      CnnAddress = new Connection();
      CnnAddress.Connect(enmConnection.SQLite, new InfoConnection("", DATABASE_FILE_ADDRESS, "", ""));

      Cnn = new Connection();
      Cnn.Connect(enmConnection.SQLite, new InfoConnection("", DATABASE_FILE, "", ""));
      if (Cnn.IsConnected())
      { VerificaScript(Cnn); }
    }

    #region Field
    public static Connection CnnAddress { get; set; }
    public static Connection Cnn { get; set; }
    public static FormError FormError { get; set; }
    public static string ScriptFile = lib.Visual.Functions.GetDirAppCondig() + "\\Script.sql";
    #endregion

    #region public static void FazerBackup(string DirBkp, string ArqSource)
    public static void FazerBackup(string DirBkp, string ArqSource)
    {
      if(!System.IO.Directory.Exists(DirBkp))
      { System.IO.Directory.CreateDirectory(DirBkp); }

      if (System.IO.File.Exists(ArqSource)) 
      {
        string ArqBkp = DirBkp + string.Format("\\BkpDatabase_{0}.bkp", DateTime.Now.ToString("yyMMdd"));
        
        if (System.IO.File.Exists(ArqBkp))
        { System.IO.File.Delete(ArqBkp); }

        System.IO.File.Copy(ArqSource, ArqBkp);
      }
    }
    #endregion

    #region public static void VerificaScript(Connection Cnn)
    public static void VerificaScript(Connection Cnn)
    {
      if (System.IO.File.Exists(ScriptFile))
      {
        UpdateScript up = new UpdateScript();
        up.DbUpdate.Load(ScriptFile);
        up.DbUpdate.Connection = Cnn;

        //if (up.DbUpdate.GetDbUpdateNumber() == 0)
        //{
        //  if (Cnn.TableExists("CAT_CATEGORIAS"))
        //  { up.DbUpdate.SetDbUpdateNumber(1); }
        //}

        if (up.DbUpdate.HasUpdate())
        { up.ShowDialog(); }
        up.Dispose();
        up = null;
      }
    }
    #endregion

    #region public static void ExibeReport(string ReportName, [List<ParamQuery> ListParam])
    public static void ExibeReport(string ReportName)
    {
      ExibeReport(ReportName, new List<ParamQuery>());
    }

    public static void ExibeReport(string ReportName, List<ParamQuery> ListParam)
    {
      string RepFile = string.Format("{0}.swr", ReportName);
      string LogFile = lib.Visual.Functions.GetDirAppCondig() + string.Format(@"\Reports\Sql.log");

      if (System.IO.File.Exists(LogFile))
      { System.IO.File.Delete(LogFile); }

      lib.Entity.MySQL db = new lib.Entity.MySQL(Cnn.ConnectionString);

      SwrReport Rep = new SwrReport();
      Rep.ReportDirectory = lib.Visual.Functions.GetDirAppCondig() + @"\Reports\";
      Rep.Cmp.SetLogFile(LogFile);
      Rep.AddConnection(new ItemConnection("Database", db));

      if (System.IO.File.Exists(Rep.ReportDirectory + RepFile))
      { SwrForms.Report.ShowReport(Rep, RepFile, ListParam, new string[] { }, lib.Class.WebUtils.GetMailDeveloper()); }
      else
      { Msg.Warning("Arquivo não encontrado :\n" + Rep.ReportDirectory + RepFile); }
      Rep = null;
    }

    public static void ExibeReport(System.Windows.Forms.Form MDIParent, string ReportName)
    {
      ExibeReport(MDIParent, ReportName, new List<ParamQuery>());
    }

    public static void ExibeReport(System.Windows.Forms.Form MDIParent, string ReportName, List<ParamQuery> ListParam)
    {
      string RepFile = string.Format("{0}.swr", ReportName);
      string LogFile = lib.Visual.Functions.GetDirAppCondig() + string.Format(@"\Reports\Sql.log");

      if (System.IO.File.Exists(LogFile))
      { System.IO.File.Delete(LogFile); }

      lib.Entity.MySQL db = new lib.Entity.MySQL(Cnn.ConnectionString);

      SwrReport Rep = new SwrReport();
      Rep.ReportDirectory = lib.Visual.Functions.GetDirAppCondig() + @"\Reports\";
      Rep.Cmp.SetLogFile(LogFile);
      Rep.AddConnection(new ItemConnection("Database", db));

      if (System.IO.File.Exists(Rep.ReportDirectory + RepFile))
      { SwrForms.Report.ShowMDIReport(MDIParent, Rep, RepFile, ListParam, new string[] { }, null); }
      else
      { Msg.Warning("Arquivo não encontrado :\n" + Rep.ReportDirectory + RepFile); }
      Rep = null;
    }

    public static string GetSwr(string ReportName, List<ParamQuery> ListParam)
    {
      string Ret = "";
      string RepFile = string.Format("{0}.swr", ReportName);
      string LogFile = lib.Visual.Functions.GetDirAppCondig() + string.Format(@"\Reports\Sql.log");

      if (System.IO.File.Exists(LogFile))
      { System.IO.File.Delete(LogFile); }

      lib.Entity.MySQL db = new lib.Entity.MySQL(Cnn.ConnectionString);

      SwrReport Rep = new SwrReport();
      Rep.TypeFile = true;
      Rep.ReportDirectory = lib.Visual.Functions.GetDirAppCondig() + @"\Reports\";
      Rep.Cmp.SetLogFile(LogFile);
      Rep.AddConnection(new ItemConnection("Database", db));

      if (System.IO.File.Exists(Rep.ReportDirectory + RepFile))
      {
        Rep.LoadCode(RepFile, ListParam);
        Ret = Rep.GetReport();
      }
      else
      { Msg.Warning("Arquivo não encontrado :\n" + Rep.ReportDirectory + RepFile); }

      Rep = null;

      return Ret;
    }

    public static void SendReportEmail(string ReportName, List<ParamQuery> ListParam, Mail Mail, string[] Cc)
    {
      string RepFile = string.Format("{0}.swr", ReportName);
      string LogFile = lib.Visual.Functions.GetDirAppCondig() + string.Format(@"\Reports\Sql.log");

      if (System.IO.File.Exists(LogFile))
      { System.IO.File.Delete(LogFile); }

      lib.Entity.MySQL db = new lib.Entity.MySQL(Cnn.ConnectionString);

      SwrReport Rep = new SwrReport();
      Rep.TypeFile = true;
      Rep.ReportDirectory = lib.Visual.Functions.GetDirAppCondig() + @"\Reports\";
      Rep.Cmp.SetLogFile(LogFile);
      Rep.AddConnection(new ItemConnection("Database", db));

      if (System.IO.File.Exists(Rep.ReportDirectory + RepFile))
      {
        Rep.LoadCode(RepFile, ListParam);
        Rep.SendReportEmail(Mail, Cc);
      }
      else
      { Msg.Warning("Arquivo não encontrado :\n" + Rep.ReportDirectory + RepFile); }

      Rep = null;
    }
    #endregion

    #region public static ALT_ALERTAS GeraNovoAlerta(HTR_HISTORICO h)
    public static ALT_ALERTAS GeraNovoAlerta(HTR_HISTORICO h) 
    {
      ALT_ALERTAS Alt = new ALT_ALERTAS();
      OCR_OCORRENCIA Ocr = (new dsOCR_OCORRENCIA(Utilities.Cnn)).Get(h.HTR_OCR_CODIGO);
      if (Ocr.OCR_DIAS_ALERTA != 0)
      {        
        Alt.ALT_HTR_CODIGO = h.HTR_CODIGO;
        Alt.ALT_EMP_CODIGO = h.HTR_EMP_CODIGO;
        Alt.ALT_CLB_CODIGO = h.HTR_CLB_CODIGO;
        Alt.ALT_OCR_CODIGO = h.HTR_OCR_CODIGO;
        Alt.ALT_DATA = h.HTR_DATA.AddDays(Ocr.OCR_DIAS_ALERTA);
        Alt.ALT_DATA_FINAL = h.HTR_DATA.AddDays(Ocr.OCR_DIAS_FINAL_ALERTA);
        Alt.ALT_MENSAGEM = Ocr.OCR_MENSAGEM_ALERTA;
      }
      return Alt; 
    }
    #endregion

    #region public ALT_ALERTAS SalvaHistoricoComAlerta(HTR_HISTORICO h)
    public static void SalvaHistoricoComAlerta(HTR_HISTORICO h)
    {
      try
      {
        Utilities.Cnn.BeginTransaction();

        (new dsHTR_HISTORICO(Utilities.Cnn)).Save(h);

        dsALT_ALERTAS dsAlt = new dsALT_ALERTAS(Utilities.Cnn);
        dsAlt.Remove_FromOCR(h.HTR_CLB_CODIGO, h.HTR_OCR_CODIGO);

        ALT_ALERTAS Alt = Utilities.GeraNovoAlerta(h);
        dsAlt.Save(Alt);

        /*OCR_OCORRENCIA Ocr = (new dsOCR_OCORRENCIA(Utilities.Cnn)).Get(h.HTR_OCR_CODIGO);
        if (Ocr.OCR_DIAS_ALERTA != 0)
        {
          ALT_ALERTAS Alt = new ALT_ALERTAS();
          Alt.ALT_HTR_CODIGO = h.HTR_CODIGO;
          Alt.ALT_EMP_CODIGO = h.HTR_EMP_CODIGO;
          Alt.ALT_CLB_CODIGO = h.HTR_CLB_CODIGO;
          Alt.ALT_OCR_CODIGO = h.HTR_OCR_CODIGO;
          Alt.ALT_DATA = h.HTR_DATA.AddDays(Ocr.OCR_DIAS_ALERTA);
          Alt.ALT_MENSAGEM = Ocr.OCR_MENSAGEM_ALERTA;

          
        }*/

        dsAlt.Save(Alt);
        Utilities.Cnn.CommitTransaction();
        //grdAlertas.AddItem(Alt);
      }
      catch
      { Utilities.Cnn.RollbackTransaction(); }
    }
    #endregion
  }
}
