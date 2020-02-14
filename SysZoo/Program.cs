using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SysZoo
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    /// 



      [STAThread]
      static void Main(string[] args)
      {
          Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);

          MessageBox.Show("O sistema syszoo foi encerrado! agradecemos pela preferencia!");
          return;

          /*Utilities.VerificaScript();

          if (args.Length != 0 && args[0] == "-c")
          { Application.Run(new frmGerencia()); }
          else if (args.Length != 0 && args[0] == "-i")
          { Application.Run(new frmTesteImpressora()); }
          else if (args.Length != 0 && (args[0] == "-a"))
          {
              DadosSZO dadosSZO = new DadosSZO(lib.Class.Utils.GetVersion());
              Application.Run(new frmAdmin());
              dadosSZO.PararProcesso = true;
          }
          else
          {
              //frmBase.ShowInTopMost = true;
              Application.Run(new frmVendaTicket());
          }*/
      }

    static void AvailabilityChangedCallback(object sender, EventArgs e)
    {
      System.Net.NetworkInformation.NetworkInterface[] adapters = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();
      foreach (System.Net.NetworkInformation.NetworkInterface n in adapters)
      {
        Console.WriteLine("   {0} is {1}", n.Name, n.OperationalStatus);
      }
    }
  }
}
