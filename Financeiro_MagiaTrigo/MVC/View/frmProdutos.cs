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
  public partial class frmProdutos : lib.Visual.Models.frmBaseCadastro
  {
    public frmProdutos()
    {
      InitializeComponent();
      ds = new dsPRO_PRODUTOS(Utilities.Cnn);
    }

    PRO_PRODUTOS Tab { get; set; }
    dsPRO_PRODUTOS ds { get; set; }

    #region private void Carregar()
    private void Carregar()
    {
      txtDescricao.Text = Tab.PRO_DESCRICAO;
      txtQtde.AsDecimal = Tab.PRO_QTDE;
      txtUnidade.Text = Tab.PRO_UNIDADE;
      txtCusto.AsDecimal = Tab.PRO_CUSTO;
      txtPreco.AsDecimal = Tab.PRO_PRECO;
      txtDescricao.Select();
    }
    #endregion

    #region protected override void OnNewRecord()
    protected override void OnNewRecord()
    {
      base.OnNewRecord();
      Tab = new PRO_PRODUTOS();
      Carregar();
    }
    #endregion

    #region protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      base.OnAlterRecord(Grid);
      Tab = Grid.GetItem<PRO_PRODUTOS>();
      Carregar();      
    }
    #endregion

    #region protected override void OnRemoveRecord()
    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover o registro {0}", Tab.PRO_CODIGO)))
      { ds.Remove(Tab.PRO_CODIGO); }
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

        if (lf[0].Field == "PRO_DESCRICAO")
        { txtDescricao.Select(); }
        if (lf[0].Field == "PRO_QTDE")
        { txtQtde.Select(); }
        if (lf[0].Field == "PRO_UNIDADE")
        { txtUnidade.Select(); }
        if (lf[0].Field == "PRO_CUSTO")
        { txtCusto.Select(); }
        if (lf[0].Field == "PRO_PRECO")
        { txtPreco.Select(); }
      }

      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      Tab.PRO_DESCRICAO = txtDescricao.Text;
      Tab.PRO_QTDE = txtQtde.AsDecimal;
      Tab.PRO_UNIDADE = txtUnidade.Text;
      Tab.PRO_CUSTO = txtCusto.AsDecimal;
      Tab.PRO_PRECO = txtPreco.AsDecimal;
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
      Grid.AddColumn(new FieldColumn("PRO_DESCRICAO", "PRO_DESCRICAO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("PRO_QTDE", "PRO_QTDE", enmFieldType.Decimal));
      Grid.AddColumn(new FieldColumn("PRO_UNIDADE", "PRO_UNIDADE", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("PRO_CUSTO", "PRO_CUSTO", enmFieldType.Decimal));
      Grid.AddColumn(new FieldColumn("PRO_PRECO", "PRO_PRECO", enmFieldType.Decimal));
      Grid.AddItems(ds.Search(TextSearch));
    }
    #endregion
  }
}

