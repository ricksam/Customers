using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Folha_Marcelo
{
  public partial class frmPrincipal : lib.Visual.Models.frmBase
  {
    public frmPrincipal()
    {
      InitializeComponent();
    }

    #region private string GetLastName(string FormName)
    private string GetLastName(string FormName)
    {
      if (FormName.IndexOf('.') == -1)
      { return FormName; }

      string[] Names = FormName.Split(new char[] { '.' });
      return Names[Names.Length - 1];
    }
    #endregion

    #region private Form GetMDIForm(string FormName)
    private Form GetMDIForm(string FormName)
    {
      for (int i = 0; i < this.MdiChildren.Length; i++)
      {
        if (this.MdiChildren[i].Name == GetLastName(FormName))
        { return this.MdiChildren[i]; }
      }

      return null;
    }
    #endregion

    #region private void ShowForm(enmFormName enm)
    private void ShowForm(string FormName, bool Maximizar = false)
    {
      Form f = GetMDIForm(FormName);

      if (f == null)
      {
        Type tp = Type.GetType("Folha_Marcelo." + FormName);
        f = (lib.Visual.Models.frmBase)Activator.CreateInstance(tp);
        f.Icon = this.Icon;
        f.MdiParent = this;
        f.MinimizeBox = false;

        f.StartPosition = FormStartPosition.Manual;
        f.Top = this.MdiChildren.Length * 10;
        f.Left = this.MdiChildren.Length * 10;

        if (Maximizar)
        { f.WindowState = FormWindowState.Maximized; }
        else
        { f.WindowState = FormWindowState.Normal; }

        f.Show();
      }

      f.BringToFront();
    }
    #endregion

    private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("frmEMP_EMPRESA");
    }

    private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("frmCLB_COLABORADOR");
    }

    private void operaçõesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("frmOPR_OPERACAO");
    }

    private void outrosLançamentosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("frmLNC_LANCAMENTO");
    }

    private void lançamentosDeSaláriosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("FORMS.frmProcSalario");
    }

    private void resumoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("FORMS.frmResumo", true);
    }

    private void configToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("FORMS.frmConfig");
    }

    private void frmPrincipal_Load(object sender, EventArgs e)
    {
      ToolStripManager.Renderer = new lib.Visual.Style.Office2007Renderer();
      this.Text = "Folha de Pagamento " + lib.Class.Utils.GetVersion();
    }

    private void lançamentosPorColaboradorToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Lancamentos_Colaborador");
    }

    private void testeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Folha_Marcelo.FORMS.frmLancDiarioExpert fe = new FORMS.frmLancDiarioExpert();
      fe.setValue(6, 2012, 1);
      fe.ShowDialog();
    }

    private void lançamentosPorLojaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Lancamentos_Loja");
    }

    private void colaboradoresAtivosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Colaboradores_Ativos");
    }

    private void colaboradoresInativosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Colaboradores_Inativos");
    }

    private void colaboradoresExperienciaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Colaboradores_Experiencia");
    }

    private void ocorrênciasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("frmOCR_OCORRENCIA");
    }

    private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("VIEW.frmHistorico");
    }

    private void pendênciasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("VIEW.frmPendencias");
    }

    private void salvarBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      dlgSave.FileName = "Database.sqlite";
      dlgSave.Filter = "SQLITE|*.sqlite";
      if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
      {
        if (System.IO.File.Exists(dlgSave.FileName))
        { System.IO.File.Delete(dlgSave.FileName); }
        System.IO.File.Copy(Utilities.Cnn.Info.Database, dlgSave.FileName);
      }
    }
  }
}
