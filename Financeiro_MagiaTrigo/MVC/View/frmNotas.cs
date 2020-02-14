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
  public partial class frmNotas : lib.Visual.Models.frmBaseCadastro
  {
    public frmNotas()
    {
      InitializeComponent();
      ds = new dsNOT_NOTA(Utilities.Cnn);
    }

    NOT_NOTA Tab { get; set; }
    dsNOT_NOTA ds { get; set; }

    #region private void Carregar()
    private void Carregar()
    {
      cmbOperacao.DisplayMember = "OPR_DESCRICAO";
      cmbOperacao.ValueMember = "OPR_CODIGO";
      cmbOperacao.DataSource = (new dsOPR_OPERACAO(Utilities.Cnn)).GetList();

      if (Tab.NOT_OPR_CODIGO != 0)
      { cmbOperacao.SelectedValue = Tab.NOT_OPR_CODIGO; }
      txtDocumento.AsInt = Tab.NOT_DOCUMENTO;
      //txtEntrada.AsDateTime = Tab.NOT_ENTRADA;
      //txtEmissao.AsDateTime = Tab.NOT_EMISSAO;
      txtDocumento.Select();
    }
    #endregion

    #region protected override void OnNewRecord()
    protected override void OnNewRecord()
    {
      base.OnNewRecord();
      Tab = new NOT_NOTA();
      Carregar();            
    }
    #endregion

    #region protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      base.OnAlterRecord(Grid);
      Tab = Grid.GetItem<NOT_NOTA>();
      Carregar();      
    }
    #endregion

    #region protected override void OnRemoveRecord()
    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover o registro {0}", Tab.NOT_CODIGO)))
      { ds.Remove(Tab.NOT_CODIGO); }
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

        if (lf[0].Field == "NOT_OPR_CODIGO")
        { cmbOperacao.Select(); }
        if (lf[0].Field == "NOT_DOCUMENTO")
        { txtDocumento.Select(); }
        //if (lf[0].Field == "NOT_ENTRADA")
        //{ txtEntrada.Select(); }
        //if (lf[0].Field == "NOT_EMISSAO")
        //{ txtEmissao.Select(); }
      }

      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      if (cmbOperacao.SelectedIndex != -1)
      { Tab.NOT_OPR_CODIGO = (int)cmbOperacao.SelectedValue; }

      Tab.NOT_DOCUMENTO = txtDocumento.AsInt;
      //Tab.NOT_ENTRADA = txtEntrada.AsDateTime;
      //Tab.NOT_EMISSAO = txtEmissao.AsDateTime;
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
      Grid.AddColumn(new FieldColumn("NOT_OPR_CODIGO", "NOT_OPR_CODIGO", enmFieldType.Int));
      Grid.AddColumn(new FieldColumn("NOT_DOCUMENTO", "NOT_DOCUMENTO", enmFieldType.Int));
      Grid.AddColumn(new FieldColumn("NOT_ENTRADA", "NOT_ENTRADA", enmFieldType.DateTime));
      Grid.AddColumn(new FieldColumn("NOT_EMISSAO", "NOT_EMISSAO", enmFieldType.DateTime));
      Grid.AddItems(ds.Search(TextSearch));
    }
    #endregion
  }
}

