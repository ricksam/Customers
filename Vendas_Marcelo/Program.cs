using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vendas_Marcelo
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] Args)
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      if (!lib.Class.Instance.RunningInstance())
      { Application.Run(new Form1(Args)); }
    }
  }
}
