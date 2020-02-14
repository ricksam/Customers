using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using lib.Class;

namespace Folha_Marcelo
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args)
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      if (!Instance.RunningInstance())
      {
        Utilities.Start();
        if (args.Length == 0)
        { Application.Run(new frmPrincipal()); }
        else
        {
          while (!EnviaEmail()) ;
        }
      }
    }

    static bool EnviaEmail() 
    {
      FORMS.frmProcesso f = new FORMS.frmProcesso();
      f.Show();

      try
      {
        f.SetText("Lendo Configurações");
        CFG_CONFIG cfg = (new dsCFG_CONFIG(Utilities.Cnn)).Get();
        ALT_ALERTAS[] alertas = (new dsALT_ALERTAS(Utilities.Cnn)).GetAlertas_Hoje(DateTime.Now);

        f.SetText("Email:" + cfg.CFG_EMAIL_ALERTA + " Alertas:" + alertas.Length);
        if (!string.IsNullOrEmpty(cfg.CFG_EMAIL_ALERTA) && alertas.Length != 0)
        {
          string html = "";
          html += "<tr><th>Data</th><th>Loja</th><th>Colaborador</th><th>Mensagem</th></tr>";
          for (int i = 0; i < alertas.Length; i++)
          {
            html += string.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td></tr>",
              alertas[i].ALT_DATA_FINAL.ToString("dd/MM/yy"), alertas[i].EMP_NOME, alertas[i].CLB_NOME, alertas[i].ALT_MENSAGEM);
          }

          html = string.Format("<h1>Alertas</h1><table>{0}</table>", html);

          f.SetText("Enviando para o email:" + cfg.CFG_EMAIL_ALERTA);
          Mail mail = lib.Class.WebUtils.GetMailDeveloper();
          mail.SendMail(html, true, cfg.CFG_EMAIL_ALERTA, "SISTEMA DE FOLHA");
        }
        return true;
      }
      catch
      {
        return false;
      }
      finally
      { f.Close(); }
    } 
  }
}
