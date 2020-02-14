using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Visual;
using lib.Visual.Models;
using lib.Database.Query;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class frmPrincipal : lib.Visual.Models.frmBase
  {
    public frmPrincipal()
    {
      InitializeComponent();
    }

    #region private void Carregar()
    private void Carregar()
    {
      try
      {        
        this.Text = string.Format("Sistema Financeiro [versão:{0}]", lib.Class.Utils.GetVersion());
        lblDatabase.Text = Utilities.Cnn.dbType.ToString() + ":" + Utilities.Cnn.Info.Server + "." + Utilities.Cnn.Info.Database;        
      }
      catch (Exception ex)
      { Utilities.FormError.ShowError(ex); }
    }
    #endregion

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
    private void ShowForm(string FormName)
    {
      Form f = GetMDIForm(FormName);

      if (f == null)
      {
        Type tp = Type.GetType("Financeiro_Marcelo." + FormName);
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

    #region private void CloseMdiForms()
    private void CloseMdiForms() 
    {
      while (this.MdiChildren.Length != 0)
      { this.MdiChildren[0].Close(); }
    }
    #endregion

    private void frmPrincipal_Load(object sender, EventArgs e)
    {
      ToolStripManager.Renderer = new lib.Visual.Style.Office2007Renderer();
      Carregar();
      Formularios_Click(sender, e);
    }

    private void frmPrincipal_Resize(object sender, EventArgs e)
    {
      this.BackgroundImageLayout = ImageLayout.None;
      this.BackgroundImageLayout = ImageLayout.Stretch;
    }

    private void fazerBackupToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //ShowForm("Manutencao.Backup");
      lib.Visual.Forms.Backup b = new lib.Visual.Forms.Backup(Utilities.Cnn,Utilities.ScriptFile);
      b.MdiParent = this;
      b.Show();
    }

    private void restauraçãoDeSistemaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.MdiChildren.Length != 0) 
      {
        Msg.Warning("É necessário fechar todas as janelas para esta operação");
        return;
      }

      if (Utilities.Liberar())
      {
        lib.Visual.Forms.Restore r = new lib.Visual.Forms.Restore("FinanceiroMarcelo", Utilities.Cnn, Utilities.FormError, Utilities.PastaDados());
        if (r.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {
          Utilities.Start();
          Carregar();
        }
      }
    }

    private void conexãoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.MdiChildren.Length != 0)
      {
        Msg.Warning("É necessário fechar todas as janelas para esta operação");
        return;
      }

      if (Utilities.Liberar())
      {
        lib.Visual.Forms.FormConnection f = new lib.Visual.Forms.FormConnection(Utilities.PastaDados());
        if (f.Exec())
        {
          Utilities.Start();
          Carregar();
        }
      }
    }

    private void sairToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void planoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Utilities.Liberar())
      {
        ShowForm("PlanoContas");        
      }
    }

    private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Utilities.Liberar())
      {
        ShowForm("View.Cadastros.CadEmpresas");        
      }
    }

    private void contasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("CadastroContas");
    }

    private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("View.Cadastros.CadFornecedores");
    }

    private void talãoDeChequeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("View.Cadastros.CadTalaoCheque");
    }

    private void cartõesToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      ShowForm("frmCRT_CARTOES");
    }
    
    private void Consulta_OnSearch(object sender, lib.Visual.Components.sknGrid Grid, string TextSearch)
    {
      dsCPG_CONTAS_PAGAR dsCpg = new dsCPG_CONTAS_PAGAR(Utilities.Cnn);
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Empresa", "EMP_DESCRICAO", enmFieldType.String, 120));
      Grid.AddColumn(new FieldColumn("Categoria", "CAT_DESCRICAO", enmFieldType.String, 120));
      Grid.AddColumn(new FieldColumn("Plano de Contas", "PLN_DESCRICAO", enmFieldType.String, 120));
      Grid.AddColumn(new FieldColumn("Descrição", "FIN_DESCRICAO", enmFieldType.String, 120));
      Grid.AddColumn(new FieldColumn("Formulário", "FRM_NUMERO", enmFieldType.Int, 60));
      Grid.AddColumn(new FieldColumn("Documento", "CPG_DOCUMENTO", enmFieldType.String, 120));
      Grid.AddColumn(new FieldColumn("Entrada", "FIN_DATA", enmFieldType.Date));
      Grid.AddColumn(new FieldColumn("Emissão", "FIN_EMISSAO", enmFieldType.Date));      
      Grid.AddColumn(new FieldColumn("Vencimento", "CPG_VENCIMENTO", enmFieldType.Date));
      Grid.AddColumn(new FieldColumn("Pago", "FIN_DATA_PGTO", enmFieldType.Date));
      Grid.AddColumn(new FieldColumn("Valor", "FIN_VALOR", enmFieldType.Decimal));
      Grid.AddItems(dsCpg.Consulta(TextSearch));
    }
        
    private void carregarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("CarregaVendas");
    }

    private void GeraBalanco_Click(object sender, EventArgs e)
    {
      if (Utilities.Liberar())
      {
        ShowForm("Fechamento.Balanco");
      }
    }

    private void visualizarEncerramentosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Balanco");
    }

    private void comparativoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "CompararPeriodos");
    }

    private void planoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "PlanoContas_Comparativo");
    }

    private void comparativoPagoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "PlanoContas_Comparativo_Pago");
    }

    private void empresaRecebimentosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "PlanoContas_Empresa");
    }

    private void empresaPagoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "PlanoContas_Empresa_Pago");
    }

    private void porEmissãoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Mercadorias_Emissao");
    }

    private void porDataDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Mercadorias_DataEntrada");
    }

    private void valorDaNotaPorEmissãoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Mercadorias_ValorNota");
    }

    private void faturamentoLojasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "RelatorioFaturamentoLojas");
    }

    private void àPagarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "ContasPagar");
    }

    private void àPagarDespresasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "ContasPagar_Despesas");
    }

    private void àPagarMercadoriasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "ContasPagar_Mercadorias");
    }

    private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "ContasPago");
    }

    private void pagoDespesasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "ContasPago_Despesas");
    }

    private void pagoMercadoriasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "ContasPago_Mercadorias");
    }

    private void senhaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Utilities.Liberar())
      {
        ShowForm("Senha.CadastroSenha");        
      }
    }

    private void pastaDeArquivosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      lib.Class.Instance.ExecProcess(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", Utilities.PastaDados(), false);
    }

    private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("Configuracoes");
    }

    private void Desenvolvedor_Click(object sender, EventArgs e)
    {
      ShowForm("View.Ajuda.EmailDesenvolvedor");
    }

    private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
    {
      lib.Visual.Functions.Sobre();
    }

    private void Formularios_Click(object sender, EventArgs e)
    {
      ShowForm("View.Cadastros.Formularios");
    }
    
    private void lançamentoToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Cartoes_Lancamento");
    }

    private void abertoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Cartoes_Aberto");
    }

    private void baixadoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Cartoes_Baixado");
    }

    private void empresadataDeEntradaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "PlanoContas_Empresa_Entrada");
    }

    private void formuláriosToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Formularios");
    }

    private void lançamentoToolStripMenuItem3_Click(object sender, EventArgs e)
    {
      ShowForm("ContasPagar");
    }

    private void baixaToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      ShowForm("BaixaConta");
    }

    private void compensarChequeToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      ShowForm("View.ContasPagar.Cheques");
    }

    private void estornoToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      ShowForm("Estorno");
    }

    private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      lib.Visual.Forms.FormQuery fq = new lib.Visual.Forms.FormQuery();
      fq.OnSearch += new lib.Visual.Forms.FormSearch.OnSearch_Handle(Consulta_OnSearch);
      if (fq.Exec())
      {
        List<SqlWebReport.ParamQuery> pars = new List<SqlWebReport.ParamQuery>();
        pars.Add(new SqlWebReport.ParamQuery(fq.Grid.GetItem<CPG_CONTAS_PAGAR>().CPG_CODIGO, SqlWebReport.FieldType.Int));
        Utilities.ExibeReport(this, "Dados_Conta", pars);
      }
    }

    private void lançamentoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("View.Cartoes.LancaCartoes");
    }

    private void baixaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("View.Cartoes.BaixaCartoes");
    }

    private void estornoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("View.Cartoes.EstornaCartoes");
    }

    private void saldoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("View.Saldo");
    }

    private void saldoToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Saldo");
    }

    private void itensDoFormulárioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Item_Formulario");
    }

    private void valorUnitárioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Item_Valor_Unitario");
    }

    private void corrigirDescriçãoItemFinanceiroToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("View.CorrigirItem");
    }

    private void valorUnitárioPorFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this, "Item_Valor_Unitario_Empresa");
    }

    private void pagoGeralToolStripMenuItem_Click(object sender, EventArgs e)
    {
      (new dsCFG_CONFIG(Utilities.Cnn)).AvancaNrImpressaoBaixa();
      Utilities.ExibeReport(this, "ContasPago_Geral");
    }

    private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        System.Diagnostics.Process prc = new System.Diagnostics.Process();
        prc.StartInfo.FileName = Utilities.PastaDados() + "\\Suporte.exe";
        prc.Start();
      }
      catch { }
    }
  }
}
