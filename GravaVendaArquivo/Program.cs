using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GravaVendaArquivo
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

      if (args.Length != 0)
      {
        lib.Visual.Forms.FormConnection fc = new lib.Visual.Forms.FormConnection(lib.Visual.Functions.GetDirAppCondig());
        fc.Exec();
      }
      else
      { Application.Run(new Principal()); }
    }
  }
}
