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
  public partial class frmPlanoContas : lib.Visual.Models.frmBaseCadastro
  {
    public frmPlanoContas()
    {
      InitializeComponent();
      ds = new dsPLN_PLANO_CONTAS(Utilities.Cnn);
    }

    PLN_PLANO_CONTAS Tab { get; set; }
    dsPLN_PLANO_CONTAS ds { get; set; }

    #region private void Carregar()
    private void Carregar()
    {
      cmbTipo.SelectedIndex = (Tab.PLN_TIPO == "R" ? 1 : 0);
      txtDescricao.Text = Tab.PLN_DESCRICAO;
      txtDescricao.Select();
    }
    #endregion

    #region protected override void OnNewRecord()
    protected override void OnNewRecord()
    {
      base.OnNewRecord();
      Tab = new PLN_PLANO_CONTAS();
      Carregar();
    }
    #endregion

    #region protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      base.OnAlterRecord(Grid);
      Tab = Grid.GetItem<PLN_PLANO_CONTAS>();
      Carregar();      
    }
    #endregion

    #region protected override void OnRemoveRecord()
    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover o registro {0}", Tab.PLN_CODIGO)))
      {
        try
        { ds.Remove(Tab.PLN_CODIGO); }
        catch { Msg.Warning("Não foi possível remover este plano de contas.\n Verifique se existem financeiros ligados a este plano de contas"); } 
      }
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

        if (lf[0].Field == "PLN_TIPO")
        { cmbTipo.Select(); }
        if (lf[0].Field == "PLN_DESCRICAO")
        { txtDescricao.Select(); }
      }

      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      Tab.PLN_TIPO = cmbTipo.SelectedIndex == 0 ? "D" : "R";
      Tab.PLN_DESCRICAO = txtDescricao.Text;
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
      Grid.AddColumn(new FieldColumn("Tipo", "PLN_TIPO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Descrição", "PLN_DESCRICAO", enmFieldType.String));
      Grid.AddItems(ds.Search(TextSearch));
    }
    #endregion
  }
}

