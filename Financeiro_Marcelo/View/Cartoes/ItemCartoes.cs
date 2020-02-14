using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Financeiro_Marcelo;
using lib.Class;
using lib.Visual;

namespace Financeiro_Marcelo.View.Cartoes
{
  public partial class ItemCartoes : lib.Visual.Models.frmDialog
  {
    public ItemCartoes()
    {
      InitializeComponent();
    }

    public int EMP_CODIGO { get; set; }
    public LNC_LANC_CARTOES Tab { get; set; }
    
    #region private void Carregar()
    private void Carregar() 
    {
      cmbCartao.DisplayMember = "CRT_DESCRICAO";
      cmbCartao.ValueMember = "CRT_CODIGO";
      cmbCartao.DataSource = (new dsCRT_CARTOES(Utilities.Cnn)).GetList_FromEmpresa(EMP_CODIGO);

      if (Tab.LNC_CRT_CODIGO != 0)
      { cmbCartao.SelectedValue = Tab.LNC_CRT_CODIGO; }
      txtValor.AsDecimal = Tab.LNC_VALOR;
    }
    #endregion

    #region private bool FaltaPreencher()
    private bool FaltaPreencher()
    {
      dsLNC_LANC_CARTOES ds = new dsLNC_LANC_CARTOES(Utilities.Cnn);
      LockedField[] lf = ds.GetLockedFields(Tab);
      if (lf.Length != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "\n"; }
        Msg.Warning("Verifique os campos abaixo:\n" + xMsg);

        if (lf[0].Field == "LNC_VALOR")
        { txtValor.Select(); }        
      }

      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      if (cmbCartao.SelectedIndex != -1)
      {
        Tab.LNC_CRT_CODIGO = (int)cmbCartao.SelectedValue;

        Tab.Assign(((CRT_CARTOES)cmbCartao.SelectedItem));

        //Tab.CRT_DESCRICAO = ((CRT_CARTOES)cmbCartao.SelectedItem).CRT_DESCRICAO;
        //Tab.CRT_NRDIAS = ((CRT_CARTOES)cmbCartao.SelectedItem).CRT_NRDIAS;
        //Tab.CRT_SEMANA = ((CRT_CARTOES)cmbCartao.SelectedItem).CRT_SEMANA;
        //Tab.CRT_TAXA = ((CRT_CARTOES)cmbCartao.SelectedItem).CRT_TAXA;
        //Tab.CRT_VENCIMENTOS = ((CRT_CARTOES)cmbCartao.SelectedItem).CRT_VENCIMENTOS;
      }
      else
      { Tab.LNC_CRT_CODIGO = 0; }

      Tab.LNC_VALOR = txtValor.AsDecimal;

      


      if (!FaltaPreencher())
      {
        base.OnConfirm();
      }
    }
    #endregion

    #region Events
    private void txtValor_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.F2)
      {
        Expressao ex = new Expressao();
        ex.ShowDialog();
        txtValor.AsDecimal = ex.Result();
        txtValor.Select();
        e.Handled = true;
      }
    }

    private void ItemCartoes_Load(object sender, EventArgs e)
    {
      Carregar();
    }
    #endregion    
  }
}
