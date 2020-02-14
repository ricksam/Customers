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
  public partial class CadEmpresas : lib.Visual.Models.frmBaseCadastro
  {
    public CadEmpresas()
    {
      InitializeComponent();
      ds = new dsEMP_EMPRESAS(Utilities.Cnn);
    }

    #region Fields
    EMP_EMPRESAS Tab { get; set; }
    dsEMP_EMPRESAS ds { get; set; }
    #endregion

    private void Carregar()
    {
      txtNome.Text = Tab.EMP_DESCRICAO;
      txtCNPJ.Text = Tab.EMP_CNPJ;
      txtNomeOnLine.Text = Tab.EMP_DESCRICAO_ONLINE;
    }

    protected override void OnNewRecord()
    {
      Tab = new EMP_EMPRESAS();
      Carregar();
      base.OnNewRecord();
      txtNome.Select();
    }

    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      Tab = Grid.GetItem<EMP_EMPRESAS>();
      Carregar();
      base.OnAlterRecord(Grid);
    }

    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover a loja {0}", Tab.EMP_DESCRICAO)))
      { ds.Remove(Tab.EMP_CODIGO); }
      base.OnRemoveRecord();
    }

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

        if (lf[0].Field == "EMP_DESCRICAO")
        { txtNome.Select(); }
        if (lf[0].Field == "EMP_DESCRICAO_ONLINE")
        { txtNomeOnLine.Select(); }
      }

      return lf.Length != 0;
    }
    #endregion


    protected override void OnConfirm()
    {
      Tab.EMP_DESCRICAO = txtNome.Text;
      Tab.EMP_CNPJ = txtCNPJ.Text;
      Tab.EMP_DESCRICAO_ONLINE = txtNomeOnLine.Text;
      if (!FaltaPreencher())
      {
        ds.Save(Tab);
        base.OnConfirm();
      }
    }

    private void CadEmpresas_Search(object sender, lib.Visual.Components.sknGrid Grid, string TextSearch)
    {
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Nome", "EMP_DESCRICAO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Nome (Sistema On-Line)", "EMP_DESCRICAO_ONLINE", enmFieldType.String));
      Grid.AddItems(ds.Search(TextSearch));
    }
  }
}
