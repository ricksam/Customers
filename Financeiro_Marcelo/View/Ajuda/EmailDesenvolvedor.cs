using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Financeiro_Marcelo.View.Ajuda
{
  public partial class EmailDesenvolvedor : lib.Visual.Models.frmDialog
  {
    public EmailDesenvolvedor()
    {
      InitializeComponent();
    }
    
    private void Carregar()     
    {
      txtMensagem.Text = "";
      cbDados.Checked = true;
    }

    protected override void OnConfirm()
    {
      try
      {
        btnConfirm.Enabled = false;
        btnConfirm.Text = "Transmitindo ...";
        this.Refresh();

        if (cbDados.Checked)
        {
          lib.Visual.Forms.Backup b = new lib.Visual.Forms.Backup(Utilities.Cnn, Utilities.ScriptFile);
          b.Show();
          b.ExecBackup(Utilities.BackupFile, new List<string>(), false, false);
          b.Close();
          b = null;
        }

        this.Refresh();

        //Tenta compactar
        string winrar = @"C:\Arquivos de programas\WinRAR\WinRar.exe";
        if (System.IO.File.Exists(winrar))
        {
          lib.Class.Instance.ExecProcess(winrar, string.Format("a \"{0}.zip\" \"{0}\"", Utilities.BackupFile), true);
          if (System.IO.File.Exists(Utilities.BackupFile))
          { System.IO.File.Delete(Utilities.BackupFile); }
          Utilities.BackupFile = Utilities.BackupFile + ".zip";
        }

        lib.Class.Mail mail = lib.Class.WebUtils.GetMailDeveloper();
        if (cbDados.Checked)
        {
          List<string> atch = new List<string>();
          atch.Add(Utilities.BackupFile);
          mail.SendMail(txtMensagem.Text, false, "jricksam@gmail.com", "AutoMessage", null, null, atch);
        }
        else
        { mail.SendMail(txtMensagem.Text, false, "jricksam@gmail.com", "AutoMessage"); }

        mail = null;

        if (!lib.Class.FileUtils.InUse(Utilities.BackupFile))
        {
          if (System.IO.File.Exists(Utilities.BackupFile))
          { System.IO.File.Delete(Utilities.BackupFile); }
        }        

        btnConfirm.Text = "Confirmar";
        btnConfirm.Enabled = true;

        base.OnConfirm();
      }
      catch (Exception ex)
      { Utilities.FormError.ShowError(ex); }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      Carregar();
    }
  }
}
