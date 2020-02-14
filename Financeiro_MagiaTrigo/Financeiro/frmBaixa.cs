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

namespace MagiaTrigo
{
  public partial class frmBaixa : lib.Visual.Models.frmEdit
  {
    public frmBaixa()
    {
      InitializeComponent();
      dsFin = new dsFIN_FINANCEIRO(Utilities.Cnn);
    }

    dsFIN_FINANCEIRO dsFin { get; set; }

    private void Carregar() 
    {
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Sel", "Sel", enmFieldType.Bool));
      Grid.AddColumn(new FieldColumn("Plano de Contas", "PLN_DESCRICAO", enmFieldType.String));      
      Grid.AddColumn(new FieldColumn("Emissão", "FIN_EMISSAO", enmFieldType.Date));
      Grid.AddColumn(new FieldColumn("Vencimento", "FIN_VENCIMENTO", enmFieldType.Date));
      Grid.AddColumn(new FieldColumn("Valor", "FIN_VALOR", enmFieldType.Decimal));
      Grid.AddColumn(new FieldColumn("Nome", "CON_NOME", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Documento", "FIN_DOCUMENTO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Descrição", "FIN_DESCRICAO", enmFieldType.String));
      Grid.AddItems(dsFin.GetList_FromAberto());
    }

    #region private void MarcaTitulo()
    private void MarcaTitulo() 
    {
      if (Grid.SelectedRows.Count != 0)
      {
        FIN_FINANCEIRO f = Grid.GetItem<FIN_FINANCEIRO>();
        f.Sel = !f.Sel;
        Grid.AlterItem(f);
      }
    }
    #endregion

    private void frmBaixa_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    protected override void OnConfirm()
    {
      if (lib.Visual.Msg.Question("Tem certeza que deseja baixar os títulos marcados?"))
      {
        FIN_FINANCEIRO[] lst = Grid.GetItems<FIN_FINANCEIRO>();

        for (int i = 0; i < lst.Length; i++)
        {
          if (lst[i].Sel)
          {
            lst[i].FIN_DTPGTO = DateTime.Now;
            dsFin.Save(lst[i]);
          }
        }
        base.OnConfirm();
      }
    }

    private void frmBaixa_Activated(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Maximized;
    }

    private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      MarcaTitulo();
    }
  }
}
