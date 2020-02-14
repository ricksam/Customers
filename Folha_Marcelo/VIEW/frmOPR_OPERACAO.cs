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

namespace Folha_Marcelo
{
  public partial class frmOPR_OPERACAO : lib.Visual.Models.frmBaseCadastro
  {
    public frmOPR_OPERACAO()
    {
      InitializeComponent();
      ds = new dsOPR_OPERACAO(Utilities.Cnn);
    }

    OPR_OPERACAO Tab { get; set; }
    dsOPR_OPERACAO ds { get; set; }
    
    #region private void Carregar()
    private void Carregar()
    {
      cmbTipo.Items.Clear();
      cmbTipo.Items.AddRange(Enum.GetNames(typeof(TipoOperacao)));
      cmbTipo.Text = Tab.TipoOperacao.ToString();

      txtOPR_DESCRICAO.Text = Tab.OPR_DESCRICAO;
      txtOPR_CAMPO.Text = Tab.OPR_CAMPO;
      txtOPR_CALCULO.Text = Tab.OPR_CALCULO;
      txtOPR_OBS.Text = Tab.OPR_OBS;      
      cbDiario.Checked = Tab.OPR_DIARIO;      
      txtOPR_DESCRICAO.Select();

      if (Tab.OPR_NIVEL != 0)
      { txtOPR_NIVEL.AsInt = Tab.OPR_NIVEL; }
      else
      { txtOPR_NIVEL.AsInt = 3; }
    }
    #endregion

    #region protected override void OnNewRecord()
    protected override void OnNewRecord()
    {
      base.OnNewRecord();
      Tab = new OPR_OPERACAO();
      Carregar();
    }
    #endregion

    #region protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      base.OnAlterRecord(Grid);
      Tab = Grid.GetItem<OPR_OPERACAO>();
      Carregar();
    }
    #endregion

    #region protected override void OnRemoveRecord()
    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover o registro {0}", Tab.OPR_CODIGO)))
      { ds.Remove(Tab.OPR_CODIGO); }
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

        if (lf[0].Field == "OPR_DESCRICAO")
        { txtOPR_DESCRICAO.Select(); }
        else if (lf[0].Field == "OPR_CAMPO")
        { txtOPR_CAMPO.Select(); }
        else if (lf[0].Field == "OPR_CALCULO")
        { txtOPR_CALCULO.Select(); }
        else if (lf[0].Field == "OPR_OBS")
        { txtOPR_OBS.Select(); }
        else if (lf[0].Field == "OPR_TIPO")
        { cmbTipo.Select(); }        
        else if (lf[0].Field == "OPR_NIVEL")
        { txtOPR_NIVEL.Select(); }
      }

      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      Tab.OPR_DESCRICAO = txtOPR_DESCRICAO.Text;
      Tab.OPR_CAMPO = txtOPR_CAMPO.Text;
      Tab.OPR_CALCULO = txtOPR_CALCULO.Text;
      Tab.OPR_OBS = txtOPR_OBS.Text;
      Tab.TipoOperacao = (TipoOperacao)cmbTipo.SelectedIndex;
      Tab.OPR_DIARIO = cbDiario.Checked;
      Tab.OPR_NIVEL = txtOPR_NIVEL.AsInt;
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
      Grid.AddColumn(new FieldColumn("Descrição", "OPR_DESCRICAO", enmFieldType.String, 120));
      Grid.AddColumn(new FieldColumn("Campo", "OPR_CAMPO", enmFieldType.String, 120));
      Grid.AddColumn(new FieldColumn("Cálculo", "OPR_CALCULO", enmFieldType.String, 180));
      //Grid.AddColumn(new FieldColumn("OBS", "OPR_OBS", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Tipo", "OPR_TIPO", enmFieldType.String, 60));
      Grid.AddColumn(new FieldColumn("Lanc. Diário", "OPR_DIARIO", enmFieldType.Bool));
      Grid.AddColumn(new FieldColumn("Nível", "OPR_NIVEL", enmFieldType.Int, 60));
      Grid.AddItems(ds.Search(TextSearch));
    }

    private string GetTextoCampo(string s)
    {
      string r = "";
      for (int i = 0; i < s.Length; i++)
      {
        if (s[i] == ' ') { r += '_'; }
        else if ("ÁÀÄÃÂ".IndexOf(s[i]) != -1) { r += 'A'; }
        else if ("ÉÈËÊ".IndexOf(s[i]) != -1) { r += 'E'; }
        else if ("ÍÌÏÎ".IndexOf(s[i]) != -1) { r += 'I'; }
        else if ("ÓÒÖÕÔ".IndexOf(s[i]) != -1) { r += 'O'; }
        else if ("ÚÙÜÛ".IndexOf(s[i]) != -1) { r += 'U'; }
        else if (s[i] == 'Ç') { r += 'C'; }
        else { r += s[i].ToString(); }
      }
      return r;
    }
    
    private void txtOPR_DESCRICAO_Leave(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtOPR_CAMPO.Text))
      { txtOPR_CAMPO.Text = GetTextoCampo(txtOPR_DESCRICAO.Text); }
    }
    #endregion
  }
}

