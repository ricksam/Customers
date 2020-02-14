using System;
using System.Collections.Generic;
using System.Windows.Forms;
using lib.Class;

namespace Financeiro_Marcelo
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
        {
          if (Utilities.LiberarEntrada())
          { Application.Run(new frmPrincipal()); }
        }
        else if(args[0]=="vendas")
        {
          CarregaVendas cv = new CarregaVendas(true);
          cv.ShowDialog();
        }
        else if (args[0] == "backup") 
        {
          Utilities.BackupInstantaneo();
        }
      }
    }
  }
}
