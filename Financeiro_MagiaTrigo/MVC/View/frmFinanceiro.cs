using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Class;
using lib.Database.Query;
using lib.Database.Drivers;
using lib.Visual;

namespace MagiaTrigo
{
  public partial class frmFinanceiro : lib.Visual.Models.frmBaseCadastro
  {
    public frmFinanceiro()
    {
      InitializeComponent();
      ds = new dsFIN_FINANCEIRO(Utilities.Cnn);
      dsCon = new dsCON_CONTATOS(Utilities.Cnn);
    }

    FIN_FINANCEIRO Tab { get; set; }
    dsFIN_FINANCEIRO ds { get; set; }
    dsCON_CONTATOS dsCon { get; set; }

    #region private void Carregar()
    private void Carregar()
    {
      cbBaixado.Checked = false;
      cmbPlanoContas.DisplayMember = "PLN_DESCRICAO";
      cmbPlanoContas.ValueMember = "PLN_CODIGO";
      cmbPlanoContas.DataSource = (new dsPLN_PLANO_CONTAS(Utilities.Cnn)).GetList();

      if (Tab.FIN_PLN_CODIGO != 0)
      { cmbPlanoContas.SelectedValue = Tab.FIN_PLN_CODIGO; }

      if (Tab.FIN_CON_CODIGO != 0)
      { txtContato.Text = dsCon.Get(Tab.FIN_CON_CODIGO).CON_NOME; }
      else 
      { txtContato.Text = ""; }

      txtDocumento.Text = Tab.FIN_DOCUMENTO;
      txtDescricao.Text = Tab.FIN_DESCRICAO;
      dtEmissao.Value = (Tab.FIN_EMISSAO == DateTime.MinValue ? DateTime.Now : Tab.FIN_EMISSAO);
      dtVencimento.Value = (Tab.FIN_VENCIMENTO == DateTime.MinValue ? DateTime.Now : Tab.FIN_VENCIMENTO);
      //dt.AsDateTime = Tab.FIN_DTPGTO;
      txtValor.AsDecimal = Tab.FIN_VALOR;
      cmbPlanoContas.Select();
    }
    #endregion

    #region protected override void OnNewRecord()
    protected override void OnNewRecord()
    {
      base.OnNewRecord();
      Tab = new FIN_FINANCEIRO();
      Carregar();            
    }
    #endregion

    #region protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      base.OnAlterRecord(Grid);
      Tab = Grid.GetItem<FIN_FINANCEIRO>();
      Carregar();      
    }
    #endregion

    #region protected override void OnRemoveRecord()
    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover o registro {0}", Tab.FIN_CODIGO)))
      { ds.Remove(Tab.FIN_CODIGO); }
      base.OnRemoveRecord();
    }
    #endregion

    #region private bool FaltaPreencher()
    private bool FaltaPreencher()
    {
      LockedField[] lf = ds.GetLockedFields(Tab);
      if (lf.Length != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "\n"; }
        Msg.Warning("Verifique os campos abaixo:\n" + xMsg);

        if (lf[0].Field == "FIN_PLN_CODIGO")
        { cmbPlanoContas.Select(); }        
        if (lf[0].Field == "FIN_VALOR")
        { txtValor.Select(); }
      }

      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      if (cmbPlanoContas.SelectedIndex != -1)
      { Tab.FIN_PLN_CODIGO = (int)cmbPlanoContas.SelectedValue; }

      Tab.FIN_DOCUMENTO = txtDocumento.Text;
      Tab.FIN_DESCRICAO = txtDescricao.Text;
      Tab.FIN_EMISSAO = dtEmissao.Value;
      Tab.FIN_VENCIMENTO = dtVencimento.Value;
      if (cbBaixado.Checked)
      { Tab.FIN_DTPGTO = DateTime.Now; }
      Tab.FIN_VALOR = txtValor.AsDecimal;
      if (!FaltaPreencher())
      {
        ds.Save(Tab);
        base.OnConfirm();
      }
    }
    #endregion

    #region Events
    private void Form_Search(object sender, lib.Visual.Components.sknGrid Grid, string TextSearch)
    {
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Plano de Contas", "PLN_DESCRICAO", enmFieldType.Int));
      Grid.AddColumn(new FieldColumn("Documento", "FIN_DOCUMENTO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Descrição", "FIN_DESCRICAO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Emissão", "FIN_EMISSAO", enmFieldType.DateTime));
      Grid.AddColumn(new FieldColumn("Vencimento", "FIN_VENCIMENTO", enmFieldType.DateTime));
      Grid.AddColumn(new FieldColumn("Valor", "FIN_VALOR", enmFieldType.Decimal));
      Grid.AddColumn(new FieldColumn("Nome", "CON_NOME", enmFieldType.Int));
      Grid.AddItems(ds.Search(TextSearch));
    }
    
    private void txtFIN_VALOR_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.F2)
      {
        lib.Visual.Forms.Expressao ex = new lib.Visual.Forms.Expressao();
        ex.ShowDialog();
        txtValor.AsDecimal = ex.Result();
        txtValor.Select();
        e.Handled = true;
      }
    }
    #endregion

    #region private void btnContato_Click(object sender, EventArgs e)
    private void btnContato_Click(object sender, EventArgs e)
    {
      lib.Visual.Forms.FormQuery fs = new lib.Visual.Forms.FormQuery();
      fs.OnSearch += new lib.Visual.Forms.FormSearch.OnSearch_Handle(PesquisaContato_OnSearch);
      if (fs.Exec())
      {
        Tab.FIN_CON_CODIGO = fs.Grid.GetField("CON_CODIGO").ToInt();
        txtContato.Text = fs.Grid.GetField("CON_NOME").ToString();
      }
    }
    #endregion

    #region private void PesquisaContato_OnSearch(object sender, lib.Visual.Components.sknGrid Grid, string s)
    private void PesquisaContato_OnSearch(object sender, lib.Visual.Components.sknGrid Grid, string s) 
    {
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Nome", "CON_NOME", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Tel. Residencial", "CON_TEL_RESIDENCIAL", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Celular", "CON_TEL_CELULAR", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Tel. Comercial", "CON_TEL_COMERCIAL", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Fax", "CON_TEL_FAX", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Logradouro", "CON_LOGRADOURO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Númeor", "CON_NUMERO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Bairro", "CON_BAIRRO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Cidade", "CON_CIDADE", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("CEP", "CON_CEP", enmFieldType.String));
      Grid.AddItems(dsCon.Search(s));
    }
    #endregion
  }
}

