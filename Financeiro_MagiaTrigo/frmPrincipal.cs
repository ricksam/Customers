using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Visual.Models;

namespace MagiaTrigo
{
  public partial class frmPrincipal : lib.Visual.Models.frmBase
  {
    public frmPrincipal()
    {
      InitializeComponent();
    }

    enum enmFormName { frmContato, frmFinanceiro, frmNotas, frmOperacao, 
      frmPlanoContas, frmProdutos, frmBaixa, frmEstorno }

    #region private Form GetMDIForm(string FormName)
    private Form GetMDIForm(string FormName) 
    {
      for (int i = 0; i < this.MdiChildren.Length; i++)
      {
        if (this.MdiChildren[i].Name == FormName)
        { return this.MdiChildren[i]; }
      }

      return null;
    }
    #endregion

    #region private void ShowForm(enmFormName enm)
    private void ShowForm(enmFormName enm)
    {
      Form f = GetMDIForm(enm.ToString());

      if (f == null)
      {
        Type tp = Type.GetType("MagiaTrigo." + enm.ToString());
        f = (frmBase)Activator.CreateInstance(tp);
        f.Icon = this.Icon;
        f.MdiParent = this;
        f.MinimizeBox = false;

        f.StartPosition = FormStartPosition.Manual;
        f.Top = this.MdiChildren.Length * 10;
        f.Left = this.MdiChildren.Length * 10;
        //f.WindowState = FormWindowState.Maximized;

        f.Show();
      }

      f.BringToFront();
    }
    #endregion

    private void lancamentosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm(enmFormName.frmFinanceiro);
    }

    private void planoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm(enmFormName.frmPlanoContas);
    }

    private void contatosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm(enmFormName.frmContato);
    }

    private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm(enmFormName.frmProdutos);
    }

    private void operaçãoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm(enmFormName.frmOperacao);
    }

    private void notaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm(enmFormName.frmNotas);
    }

    private void frmPrincipal_Load(object sender, EventArgs e)
    {
      ToolStripManager.Renderer = new lib.Visual.Style.Office2007Renderer();
      this.Text = string.Format("Software Demo [versão=Demo]", lib.Class.Utils.GetVersion());
    }

    private void btnContatos_Click(object sender, EventArgs e)
    {
      ShowForm(enmFormName.frmContato);
    }

    private void btnFinanceiro_Click(object sender, EventArgs e)
    {
      ShowForm(enmFormName.frmFinanceiro);
    }

    private void btnMateriais_Click(object sender, EventArgs e)
    {
      ShowForm(enmFormName.frmProdutos);
    }

    private void btnNotas_Click(object sender, EventArgs e)
    {
      ShowForm(enmFormName.frmNotas);
    }

    private void frmPrincipal_Resize(object sender, EventArgs e)
    {
      this.BackgroundImageLayout = ImageLayout.None;
      this.BackgroundImageLayout = ImageLayout.Stretch;
    }

    private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
    {
    }

    private void lanamentosAReceberToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Financeiro_PlanoContas_Aberto");
    }

    private void listaDePlanoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Lista_PlanoContas");
    }

    private void listaDeContatosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Lista_Contatos");
    }

    private void listaDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Lista_Produtos");
    }

    private void listaDeOperaçãoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Lista_Operacoes");
    }

    private void baixaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm(enmFormName.frmBaixa);
    }

    private void estornoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm(enmFormName.frmEstorno);
    }

    private void lançamentosRecebidosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Financeiro_PlanoContas_Baixado");
    }

    private void fuxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }
  }
}
