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
using lib.Visual;

namespace Financeiro_Marcelo.Fechamento
{
  public partial class UltimosBalancos : lib.Visual.Models.frmBase
  {
    public UltimosBalancos()
    {
      InitializeComponent();
      bs = new dsBAL_BALANCO(Utilities.Cnn);
    }

    dsBAL_BALANCO bs { get; set; }


    private void Carregar() 
    {
      lstBalancos.Clear();
      lstBalancos.AddColumn(new FieldColumn("Data", "BAL_DATA", enmFieldType.DateTime));
      lstBalancos.AddColumn(new FieldColumn("Estoque Inicial", "BAL_ESTOQUE_INICIAL", enmFieldType.Decimal));
      lstBalancos.AddColumn(new FieldColumn("Estoque Final", "BAL_ESTOQUE_FINAL", enmFieldType.Decimal));
      lstBalancos.AddItems(bs.GetList_UltimosFechamentos());
    }

    private void UltimosBalancos_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnApagar_Click(object sender, EventArgs e)
    {
      if (lstBalancos.SelectedRows.Count != 0) 
      {
        BAL_BALANCO Bal = lstBalancos.GetItem<BAL_BALANCO>();
        if (Msg.Question(
          string.Format(
            "Tem certeza que deseja remover o balanço:\nData: {0}\nEstoque Inicial: {1}\nEstoque Final: {2}", 
            Bal.BAL_DATA.ToString("dd/MM/yy"),
            Bal.BAL_ESTOQUE_INICIAL.ToString("#,##0.00"),
            Bal.BAL_ESTOQUE_FINAL.ToString("#,##0.00"))))
        {
          bs.Remove(Bal.BAL_CODIGO);
          Carregar();
        }
      }
    }
  }
}
