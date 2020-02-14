using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RckEventos
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string [] args)
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      if (!lib.Class.Instance.RunningInstance())
      {
        Utilities.Start();
        if (args != null && args.Length != 0)
        { 
            Application.Run(new Menu()); 
        }
        else {
            Config cfg = Utilities.OpenConfig();
            if (cfg == null)
            {
                Application.Run(new Mural2());
            }
            else {
                Application.Run(new Mural2(cfg.DirFotos));
            }
        }
        
        Utilities.Stop();
      }
    }
  }
}
