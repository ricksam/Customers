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
  public partial class frmConfiguracao : frmBase
  {
    public frmConfiguracao()
    {
      InitializeComponent();
    }

    private void frmConfiguracao_Load(object sender, EventArgs e)
    {
      Utilities.ProcuraPortas(cmbPorta);
      SZO_CFG_CONFIG cfg = (new dsSZO_CFG_CONFIG(Utilities.GetDatabase())).Get();
      txtIdentificacao.Text = cfg.CFG_IDENTIFICACAO;
      cmbPorta.Text = cfg.CFG_PRINTER_PORT;
      txtVelocidade.Text = cfg.CFG_PRINTER_VELOCITY.ToString();
      cbIndividual.Checked = cfg.CFG_IMPRIMIR_INDIVIDUAL;
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
      dsSZO_CFG_CONFIG dsCFg =new dsSZO_CFG_CONFIG(Utilities.GetDatabase()); 
      SZO_CFG_CONFIG cfg = dsCFg.Get();
      cfg.CFG_IDENTIFICACAO = txtIdentificacao.Text;
      cfg.CFG_PRINTER_PORT= cmbPorta.Text;
      cfg.CFG_PRINTER_VELOCITY = (new lib.Class.Conversion()).ToInt(txtVelocidade.Text);
      cfg.CFG_IMPRIMIR_INDIVIDUAL = cbIndividual.Checked;
      dsCFg.Save(cfg);
      this.Close();
    }
  }
}
