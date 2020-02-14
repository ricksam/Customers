using System;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Database;
using lib.Database.Drivers;
using lib.Visual;
using lib.Visual.Forms;
using SqlWebReport;

namespace MagiaTrigo
{
  public static class Utilities
  {
    public static void Start()
    {
      try
      {
        FormError = new FormError();
        Enc = new lib.Class.Encryption("MagiaTrigo");
        //FormConnection f = new FormConnection();
        //if (f.LoadCfg())
        //{
          Cnn = new Connection();
          //Cnn.Connect(f.DbType, f.InfoConnection);
          Cnn.Connect(enmConnection.SQLite, new InfoConnection("localhsot", lib.Visual.Functions.GetDirAppCondig() + "\\Database.db", "", ""));
          if (Cnn.IsConnected())
          { VerificaScript(Cnn); }
        //}
      }
      catch (Exception ex)
      { FormError.ShowError("Erro ao iniciar a aplicação devido falha ao conectar-se com o banco de dados.", ex); }
    }

    public static Connection Cnn { get; set; }
    public static FormError FormError { get; set; }
    public static Encryption Enc { get; set; }

    #region public static void ExibeReport(string ReportName, [List<ParamQuery> ListParam])
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

      SwrReport Rep = new SwrReport();
      Rep.ReportDirectory = lib.Visual.Functions.GetDirAppCondig() + @"\Reports\";
      Rep.Cmp.dstList.SetLogFile(LogFile);
      Rep.AddConnection(new ItemConnection("Database", Cnn));

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

      SwrReport Rep = new SwrReport();
      Rep.TypeFile = true;
      Rep.ReportDirectory = lib.Visual.Functions.GetDirAppCondig() + @"\Reports\";
      Rep.Cmp.dstList.SetLogFile(LogFile);
      Rep.AddConnection(new ItemConnection("Database", Cnn));

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
    #endregion

    #region public static void VerificaScript(Connection Cnn)
    public static void VerificaScript(Connection Cnn)
    {
      string ArqScript = lib.Visual.Functions.GetDirAppCondig() + "\\Script_SQLite.sql";
      if (System.IO.File.Exists(ArqScript))
      {
        UpdateScript up = new UpdateScript();
        up.DbUpdate.Load(ArqScript);
        up.DbUpdate.Connection = Cnn;
                
        if (up.DbUpdate.HasUpdate())
        { up.ShowDialog(); }
        up.Dispose();
        up = null;
      }
    }
    #endregion
  }
}
