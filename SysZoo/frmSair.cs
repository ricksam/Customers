using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysZoo
{
  public partial class frmSair : frmBase
  {
    public frmSair()
    {
      InitializeComponent();
    }

    public bool EncerrarMovimento = false;
    public bool FecharPrograma = false;

    private void btnFecharPrograma_Click(object sender, EventArgs e)
    {
      FecharPrograma = true;
      this.Close();
    }

    private void btnEncerrarMovimento_Click(object sender, EventArgs e)
    {
      dsSZO_CFG_CONFIG dsCfg = new dsSZO_CFG_CONFIG(Utilities.GetDatabase());
      dsSZO_OPR_OPERADORES dsOpr = new dsSZO_OPR_OPERADORES(Utilities.GetDatabase());
      
      SZO_CFG_CONFIG Cfg = dsCfg.Get();
      SZO_OPR_OPERADORES Opr = dsOpr.Get(Cfg.CFG_OPR_CODIGO);

      if (Cfg.CFG_OPR_CODIGO != 0)
      {
        dsCfg.EncerrarMovimento();
        EncerrarMovimento = true;
        Utilities.ImprimeFechamento(Cfg, Opr);
      }
      else
      { Utilities.MsgAlert("Movimento já encerrado"); }
      this.Close();
    }
  }
}
