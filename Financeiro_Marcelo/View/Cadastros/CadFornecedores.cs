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

namespace Financeiro_Marcelo.View.Cadastros
{
  public partial class CadFornecedores : lib.Visual.Models.frmBaseCadastro
  {
    public CadFornecedores()
    {
      InitializeComponent();
      ds = new dsFRN_FORNECEDORES(Utilities.Cnn);
    }

    FRN_FORNECEDORES Tab { get; set; }
    dsFRN_FORNECEDORES ds { get; set; }

    private void Carregar()
    {
      txtFornecedor.Text = Tab.FRN_NOME;
      txtCNPJ.Text = Tab.FRN_CNPJ;
      txtTelefone.Text = Tab.FRN_TELEFONE;
    }

    #region protected override void OnNewRecord()
    protected override void OnNewRecord()
    {
      Tab = new FRN_FORNECEDORES();
      Carregar();
      base.OnNewRecord();
      txtFornecedor.Select();
    }
    #endregion

    #region protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      Tab = Grid.GetItem<FRN_FORNECEDORES>();
      Carregar();
      base.OnAlterRecord(Grid);
    }
    #endregion

    #region protected override void OnRemoveRecord()
    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover o registro {0}", Tab.FRN_CODIGO)))
      { ds.Remove(Tab.FRN_CODIGO); }
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

        if (lf[0].Field == "FRN_NOME")
        { txtFornecedor.Select(); }
      }

      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      Tab.FRN_NOME = txtFornecedor.Text;
      Tab.FRN_CNPJ = txtCNPJ.Text;
      Tab.FRN_TELEFONE = txtTelefone.Text;

      if (!FaltaPreencher())
      {
        ds.Save(Tab);
        base.OnConfirm();
      }
    }
    #endregion
    
    #region Events
    private void CadFornecedores_Search(object sender, lib.Visual.Components.sknGrid Grid, string TextSearch)
    {
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Fornecedor", "FRN_NOME", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("CNPJ", "FRN_CNPJ", enmFieldType.String));
      Grid.AddItems(ds.Search(TextSearch));
    }    
    #endregion    
  }
}
