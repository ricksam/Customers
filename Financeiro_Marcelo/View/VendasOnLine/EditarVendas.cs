using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Database.Query;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class EditarVendas : lib.Visual.Models.frmDialog
  {
    public EditarVendas()
    {
      InitializeComponent();
      bsFrm = new dsFRM_FORMULARIOS(Utilities.Cnn);
    }

    private int EMP_CODIGO { get; set; }
    public FRM_FORMULARIOS SelForm { get; set; }
    private dsFRM_FORMULARIOS bsFrm { get; set; }

    public void CarregarVenda(VDA_VENDA Vda)
    {
      EMP_CODIGO = (new dsEMP_EMPRESAS(Utilities.Cnn)).Get_FromDescricaoOnLine(Vda.VDA_EMPRESA).EMP_CODIGO;
      txtEmpresa.Text = Vda.VDA_EMPRESA;
      txtEmissao.Text = Vda.VDA_EMISSAO.ToString("dd/MM/yyyy");
      txtOperador.Text = Vda.VDA_OPERADOR;
      txtCupons.Text = Vda.VDA_CUPONS.ToString();
      txtTotal.Text = Vda.VDA_TOTAL.ToString("#,##0.00");
    }

    protected void Formulario_OnSearch(object sender, lib.Visual.Components.sknGrid Grid, string TextSearch)
    {
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Empresa", "EMP_DESCRICAO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Emissão", "FRM_DATA", enmFieldType.Date));
      Grid.AddColumn(new FieldColumn("Número", "FRM_NUMERO", enmFieldType.Int));      
      Grid.AddColumn(new FieldColumn("Clientes", "FRM_NUMERO_CLIENTES", enmFieldType.Int));
      Grid.AddColumn(new FieldColumn("Total Venda", "FRM_VALOR_COMPARATIVO", enmFieldType.Decimal));
      Grid.AddItems(bsFrm.GetList_SemVendas(TextSearch, EMP_CODIGO));
    }
        
    private void sknButton1_Click(object sender, EventArgs e)
    {
      lib.Visual.Forms.FormQuery fq = new lib.Visual.Forms.FormQuery();
      fq.OnSearch += new lib.Visual.Forms.FormSearch.OnSearch_Handle(Formulario_OnSearch);
      if (fq.Exec())
      {
        if (fq.Grid.RowCount != 0)
        {
          SelForm = fq.Grid.GetItem<FRM_FORMULARIOS>();
          txtNrForm.AsInt = SelForm.FRM_NUMERO;
          txtFormCupons.AsInt = SelForm.FRM_NUMERO_CLIENTES;
          txtFormTotal.AsDecimal = SelForm.FRM_VALOR_COMPARATIVO;
          btnConfirm.Select();
        }
      }
    }
  }
}
