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
  public partial class frmEMP_EMPRESA : lib.Visual.Models.frmBaseCadastro
  {
    public frmEMP_EMPRESA()
    {
      InitializeComponent();
      ds = new dsEMP_EMPRESA(Utilities.Cnn);
    }

    EMP_EMPRESA Tab { get; set; }
    dsEMP_EMPRESA ds { get; set; }

    #region private void Carregar()
    private void Carregar()
    {
      txtEMP_NOME.Text = Tab.EMP_NOME;
      cbInativo.Checked = Tab.EMP_INATIVO;
      txtEMP_NOME.Select();
    }
    #endregion

    #region protected override void OnNewRecord()
    protected override void OnNewRecord()
    {
      base.OnNewRecord();
      Tab = new EMP_EMPRESA();
      Carregar();
    }
    #endregion

    #region protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      base.OnAlterRecord(Grid);
      Tab = Grid.GetItem<EMP_EMPRESA>();
      Carregar();
    }
    #endregion

    #region protected override void OnRemoveRecord()
    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover o registro {0}", Tab.EMP_CODIGO)))
      { ds.Remove(Tab.EMP_CODIGO); }
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

        if (lf[0].Field == "EMP_NOME")
        { txtEMP_NOME.Select(); }         
      }

      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      Tab.EMP_NOME = txtEMP_NOME.Text;
      Tab.EMP_INATIVO = cbInativo.Checked;
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
      Grid.AddColumn(new FieldColumn("Nome", "EMP_NOME", enmFieldType.String));
      Grid.AddItems(ds.Search(TextSearch));
    }
    #endregion
  }
}

