using System;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Database;
using lib.Database.Drivers;
using lib.Visual;
using lib.Visual.Forms;
using SqlWebReport;

namespace Financeiro_Marcelo
{
  public static class Utilities
  {
    #region public static void Start()
    public static void Start()
    {
      try
      {
        FormError = new FormError();
                //lib.Class.Encryption.
        Enc = new lib.Class.EncryptionDeprecated("FinanceiroMarcelo");
        FormConnection f = new FormConnection(Utilities.PastaDados());

        enmConnection DbType = enmConnection.SQLite;
        InfoConnection InfoConnection = new InfoConnection("", Utilities.PastaDados() + "\\DATABASE\\Database.sqlite", "", "");
                
        if(!f.NotConfigured)
        {
          if (f.LoadCfg())
          {
            DbType = f.DbType;
            InfoConnection = f.InfoConnection;
          }
        }

        Cnn = new Connection();
        Cnn.Connect(DbType, InfoConnection);
        if (Cnn.IsConnected())
        {
          //Sb = new SqlBuild(Cnn.dbu);
          ScriptFile = Utilities.PastaDados() + string.Format("\\DATABASE\\Script_{0}.sql", DbType.ToString());
          VerificaScript(Cnn);
        }
      }
      catch (Exception ex)
      { FormError.ShowError("Erro ao iniciar a aplicação devido falha ao conectar-se com o banco de dados.", ex); }
    }
    #endregion

    #region Fields
    public static Connection Cnn { get; set; }
    //public static SqlBuild Sb { get; set; }
    public static FormError FormError { get; set; }
    public static EncryptionDeprecated Enc { get; set; }
    public static string BackupFile = GetBackupFolder() + string.Format("\\Database_{0}.bkp", DateTime.Now.ToString("yyMMddHHmmss"));
    public static string ScriptFile { get; set; }
    public static string DirectoryPortable = System.Windows.Forms.Application.StartupPath;
    #endregion

    #region private static string GetBackupFolder()
    private static string GetBackupFolder() 
    {
      string Folder = Utilities.PastaDados() + "\\BACKUP";
      if (!System.IO.Directory.Exists(Folder))
      { System.IO.Directory.CreateDirectory(Folder); }
      return Folder;
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
      string LogFile = Utilities.PastaDados() + string.Format(@"\Reports\Sql.log");

      if (System.IO.File.Exists(LogFile))
      { System.IO.File.Delete(LogFile); }

      lib.Entity.MySQL db = new lib.Entity.MySQL(Cnn.ConnectionString);

      SwrReport Rep = new SwrReport();
      Rep.ReportDirectory = Utilities.PastaDados() + @"\Reports\";
      Rep.Cmp.SetLogFile(LogFile);
      Rep.AddConnection(new ItemConnection("Database", db));

      if (System.IO.File.Exists(Rep.ReportDirectory + RepFile))
      {
        Config cfg = new Config();
        cfg.Open();
        SwrForms.Report.ShowReport(Rep, RepFile, ListParam, GetListaContatos(), GetMailUser(cfg.Email));
      }
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
      string LogFile = Utilities.PastaDados() + string.Format(@"\Reports\Sql.log");

      if (System.IO.File.Exists(LogFile))
      { System.IO.File.Delete(LogFile); }

      lib.Entity.MySQL db = new lib.Entity.MySQL(Cnn.ConnectionString);

      SwrReport Rep = new SwrReport();
      Rep.ReportDirectory = Utilities.PastaDados() + @"\Reports\";
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
      string LogFile = Utilities.PastaDados() + string.Format(@"\Reports\Sql.log");

      if (System.IO.File.Exists(LogFile))
      { System.IO.File.Delete(LogFile); }

      lib.Entity.MySQL db = new lib.Entity.MySQL(Cnn.ConnectionString);

      SwrReport Rep = new SwrReport();
      Rep.TypeFile = true;
      Rep.ReportDirectory = Utilities.PastaDados() + @"\Reports\";
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
      string LogFile = Utilities.PastaDados() + string.Format(@"\Reports\Sql.log");

      if (System.IO.File.Exists(LogFile))
      { System.IO.File.Delete(LogFile); }

      lib.Entity.MySQL db = new lib.Entity.MySQL(Cnn.ConnectionString);

      SwrReport Rep = new SwrReport();
      Rep.TypeFile = true;
      Rep.ReportDirectory = Utilities.PastaDados() + @"\Reports\";
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

    #region public static void VerificaScript(Connection Cnn)
    public static void VerificaScript(Connection Cnn)
    {
      if (System.IO.File.Exists(ScriptFile))
      {
        UpdateScript up = new UpdateScript();
        up.DbUpdate.Load(ScriptFile);
        up.DbUpdate.Connection = Cnn;

        if (up.DbUpdate.GetDbUpdateNumber() == 0)
        {
          if (Cnn.TableExists("CAT_CATEGORIAS"))
          { up.DbUpdate.SetDbUpdateNumber(1); }
        }

        if (up.DbUpdate.HasUpdate())
        { up.ShowDialog(); }
        up.Dispose();
        up = null;
      }
    }
    #endregion

    #region public static bool Liberar()
    public static bool Liberar()
    {
      try
      {
        CFG_CONFIG Cfg = (new dsCFG_CONFIG(Utilities.Cnn)).Get();
        if (string.IsNullOrEmpty(Cfg.CFG_SENHA_EXCLUSIVA))
        { return true; }

        Senha.InformarSenha infoSenha = new Senha.InformarSenha();
        if (infoSenha.Exec())
        {
          if (Cfg.CFG_SENHA_EXCLUSIVA == lib.Class.EncryptionDeprecated.GetSHA1(infoSenha.Senha))
          { return true; }
          else
          { Msg.Warning("Senha incorreta!"); }
        }
        return false;
      }
      catch { return true; }
    }
    #endregion

    #region public static bool Liberar()
    public static bool LiberarEntrada()
    {
      try
      {
        CFG_CONFIG Cfg = (new dsCFG_CONFIG(Utilities.Cnn)).Get();
        if (string.IsNullOrEmpty(Cfg.CFG_SENHA_ENTRADA))
        { return true; }

        Senha.InformarSenha infoSenha = new Senha.InformarSenha();
        if (infoSenha.Exec())
        {
          if (Cfg.CFG_SENHA_ENTRADA == lib.Class.EncryptionDeprecated.GetSHA1(infoSenha.Senha) || Cfg.CFG_SENHA_EXCLUSIVA == lib.Class.EncryptionDeprecated.GetSHA1(infoSenha.Senha))
          { return true; }
          else
          { Msg.Warning("Senha incorreta!"); }
        }
        return false;
      }
      catch { return true; }
    }
    #endregion

    #region public static Mail GetMailUser()
    public static Mail GetMailUser(CfgEmail CfgEmail) 
    {
      if (!string.IsNullOrEmpty(CfgEmail.Servidor))
      {
        return new Mail(
          CfgEmail.Servidor,
          CfgEmail.Usuario, CfgEmail.Senha,
          CfgEmail.HabilitaSSL, CfgEmail.RequerAutenticacao,
          CfgEmail.Porta);
      }
      else { return null; }
    }
    #endregion

    #region public static string[] GetListaContatos()
    public static string[] GetListaContatos() 
    {
      EML_EMAIL[] EmailList = (new dsEML_EMAIL(Utilities.Cnn)).GetList();
      string[] Cc = new string[EmailList.Length];
      for (int i = 0; i < EmailList.Length; i++)
      { Cc[i] = EmailList[i].EML_CONTATO; }
      return Cc;
    }
    #endregion

    #region public static void BackupInstantaneo()
    public static void BackupInstantaneo() 
    {
      lib.Visual.Forms.Backup b = new lib.Visual.Forms.Backup(Utilities.Cnn, Utilities.ScriptFile);
      b.Show();
      b.ExecBackup(Utilities.BackupFile, new List<string>(), false, false);
      b.Close();
      b = null;

      Config cfg = new Config();
      cfg.Open();

      if (System.IO.File.Exists(Utilities.BackupFile) && System.IO.Directory.Exists(cfg.PastaCopiaBackup)) 
      {
        try 
        {
          System.IO.File.Copy(Utilities.BackupFile, cfg.PastaCopiaBackup + System.IO.Path.GetFileName(Utilities.BackupFile));
        }
        catch { Msg.Warning(string.Format("Não foi possível copiar o backup {0} para a pasta {1}",Utilities.BackupFile,cfg.PastaCopiaBackup)); }
      }      
    }
    #endregion

    #region public static string PastaDados()
    public static string PastaDados() 
    {
      if (System.Configuration.ConfigurationSettings.AppSettings["Portable"] == "true")
      { return DirectoryPortable; }
      else 
      { return lib.Visual.Functions.GetDirAppCondig(); }
    }
    #endregion

  }
}
