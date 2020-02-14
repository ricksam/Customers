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
  public partial class frmContato : lib.Visual.Models.frmBaseCadastro
  {
    public frmContato()
    {
      InitializeComponent();
      ds = new dsCON_CONTATOS(Utilities.Cnn);
    }

    CON_CONTATOS Tab { get; set; }
    dsCON_CONTATOS ds { get; set; }

    #region private void Carregar()
    private void Carregar()
    {
      txtNome.Text = Tab.CON_NOME;
      txtEmail.Text = Tab.CON_EMAIL;
      txtTelResidencial.Text = Tab.CON_TEL_RESIDENCIAL;
      txtTelCelular.Text = Tab.CON_TEL_CELULAR;
      txtTelComercial.Text = Tab.CON_TEL_COMERCIAL;
      txtTelFax.Text = Tab.CON_TEL_FAX;
      txtLogradouro.Text = Tab.CON_LOGRADOURO;
      txtNumero.Text = Tab.CON_NUMERO;
      txtBairro.Text = Tab.CON_BAIRRO;
      txtCidade.Text = Tab.CON_CIDADE;
      txtCEP.Text = Tab.CON_CEP;
      txtNome.Select();
    }
    #endregion

    #region protected override void OnNewRecord()
    protected override void OnNewRecord()
    {      
      base.OnNewRecord();
      Tab = new CON_CONTATOS();      
      Carregar();
    }
    #endregion

    #region protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      base.OnAlterRecord(Grid);
      Tab = Grid.GetItem<CON_CONTATOS>();
      Carregar();
    }
    #endregion

    #region protected override void OnRemoveRecord()
    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover o registro {0}", Tab.CON_CODIGO)))
      { ds.Remove(Tab.CON_CODIGO); }
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

        if (lf[0].Field == "CON_NOME")
        { txtNome.Select(); }        
      }

      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      Tab.CON_NOME = txtNome.Text;
      Tab.CON_EMAIL = txtEmail.Text;
      Tab.CON_TEL_RESIDENCIAL = txtTelResidencial.Text;
      Tab.CON_TEL_CELULAR = txtTelCelular.Text;
      Tab.CON_TEL_COMERCIAL = txtTelComercial.Text;
      Tab.CON_TEL_FAX = txtTelFax.Text;
      Tab.CON_LOGRADOURO = txtLogradouro.Text;
      Tab.CON_NUMERO = txtNumero.Text;
      Tab.CON_BAIRRO = txtBairro.Text;
      Tab.CON_CIDADE = txtCidade.Text;
      Tab.CON_CEP = txtCEP.Text;
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
      Grid.AddItems(ds.Search(TextSearch));
    }
    #endregion
  }
}

