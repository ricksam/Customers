using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControlePortarias
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      if (!lib.Class.Instance.RunningInstance())
      {
        Utilities.Start();
        Application.Run(new frmPrincipal());
      }
    }
  }
}
