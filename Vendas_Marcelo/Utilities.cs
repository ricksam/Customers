using System;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Visual.Forms;

namespace Vendas_Marcelo
{
  public class Utilities
  {
    public static void Start()
    {
      FormError = new FormError();
      FormConnection f = new FormConnection(lib.Visual.Functions.GetDirAppCondig());
      if (f.LoadCfg())
      {
        Cnn = new Connection();
        Cnn.Connect(f.DbType, f.InfoConnection);
        if (Cnn.IsConnected())
        {
          Sb = new SqlBuild(Cnn.dbu, false);
          //VerificaScript(Cnn);
        }
      }
    }

    public static Connection Cnn { get; set; }
    public static SqlBuild Sb { get; set; }
    public static FormError FormError { get; set; }
  }
}
