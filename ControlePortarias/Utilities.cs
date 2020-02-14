using System;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Database;
using lib.Database.Drivers;
using lib.Visual;
using lib.Visual.Forms;
using SqlWebReport;

namespace ControlePortarias
{
  public static class Utilities
  {
    public static void Start()
    {
      try
      {
        FormError = new FormError();
        Enc = new lib.Class.Encryption("RckSoftware");
        FormConnection f = new FormConnection(Utilities.PastaDados());

        enmConnection DbType = enmConnection.SQLite;
        string banco = Utilities.PastaDados() + "\\Database.sqlite";
        InfoConnection InfoConnection = new InfoConnection("", banco, "", "");

        Cnn = new Connection();
        Cnn.Connect(DbType, InfoConnection);
        if (Cnn.IsConnected())
        {
          //Sb = new SqlBuild(Cnn.dbu);
          ScriptFile = Utilities.PastaDados() + string.Format("\\Script.sql", DbType.ToString());
          VerificaScript(Cnn);
        }
      }
      catch (Exception ex)
      { FormError.ShowError("Erro ao iniciar a aplicação devido falha ao conectar-se com o banco de dados.", ex); }
    }

    public static Connection Cnn { get; set; }
    //public static SqlBuild Sb { get; set; }
    public static FormError FormError { get; set; }
    public static Encryption Enc { get; set; }
    public static string BackupFile = GetBackupFolder() + string.Format("\\Database_{0}.bkp", DateTime.Now.ToString("yyMMddHHmmss"));
    public static string ScriptFile { get; set; }
    public static string DirectoryPortable = System.Windows.Forms.Application.StartupPath;
    //public static int Fuzo = -3;

    private static string GetBackupFolder()
    {
      string Folder = Utilities.PastaDados() + "\\BACKUP";
      if (!System.IO.Directory.Exists(Folder))
      { System.IO.Directory.CreateDirectory(Folder); }
      return Folder;
    }

    public static void VerificaScript(Connection Cnn)
    {
      if (System.IO.File.Exists(ScriptFile))
      {
        UpdateScript up = new UpdateScript();
        up.DbUpdate.Load(ScriptFile);
        up.DbUpdate.Connection = Cnn;

        if (up.DbUpdate.HasUpdate())
        { up.ShowDialog(); }
        up.Dispose();
        up = null;
      }
    }

    public static string PastaDados()
    {
      if (System.Configuration.ConfigurationSettings.AppSettings["Portable"] == "true")
      { return DirectoryPortable; }
      else
      { return lib.Visual.Functions.GetDirAppCondig(); }
    }
  }
}
