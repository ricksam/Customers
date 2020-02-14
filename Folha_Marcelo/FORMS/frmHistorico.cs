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

namespace Folha_Marcelo.VIEW
{
  public partial class frmHistorico : lib.Visual.Models.frmBase
  {
    public frmHistorico()
    {
      InitializeComponent();
    }

    #region private void Carregar()
    private void Carregar()
    {
      cmbEmpresas.ValueMember = "EMP_CODIGO";
      cmbEmpresas.DisplayMember = "EMP_DESCRICAO";
      cmbEmpresas.DataSource = (new dsEMP_EMPRESA(Utilities.Cnn)).GetList();
    }
    #endregion

    #region private void CarregaHistoricos()
    private void CarregaHistoricos() 
    {
      if (cmbEmpresas.SelectedIndex != -1 && cmbColaborador.SelectedIndex != -1)
      {
        grdHistorico.Clear();
        grdHistorico.AddColumn(new FieldColumn("Data", "HTR_DATA", enmFieldType.DateTime));
        grdHistorico.AddColumn(new FieldColumn("Ocorrência", "OCR_DESCRICAO", enmFieldType.String));
        grdHistorico.AddColumn(new FieldColumn("Observação", "HTR_OBSERVACAO", enmFieldType.String));
        grdHistorico.AddItems(new dsHTR_HISTORICO(Utilities.Cnn).GetList_FrmEmpClb((int)cmbColaborador.SelectedValue));
      }
    }
    #endregion

    #region private void CarregaAlertas()
    private void CarregaAlertas() 
    {
      if (cmbEmpresas.SelectedIndex != -1 && cmbColaborador.SelectedIndex != -1)
      {
        lstAlertas.Items.Clear();
        lstAlertas.Items.AddRange(new dsALT_ALERTAS(Utilities.Cnn).GetList_FrmEmpClb((int)cmbColaborador.SelectedValue));
      }
    }
    #endregion

    #region private void CarregarColaboradores(int EMP_CODIGO)
    private void CarregarColaboradores(int EMP_CODIGO) 
    {
      cmbColaborador.ValueMember = "CLB_CODIGO";
      cmbColaborador.DisplayMember = "CLB_NOME";
      cmbColaborador.DataSource = (new dsCLB_COLABORADOR(Utilities.Cnn)).GetList_FromEmpresa(EMP_CODIGO);
    }
    #endregion
        
    #region private void AdicionarHistorico()
    private void AdicionarHistorico() 
    {
      if (cmbEmpresas.SelectedIndex != -1 && cmbColaborador.SelectedIndex != -1)
      {
        ItemHistorico f = new ItemHistorico();
        if (f.Exec())
        {
          f.Tab.HTR_EMP_CODIGO = (int)cmbEmpresas.SelectedValue;
          f.Tab.HTR_CLB_CODIGO = (int)cmbColaborador.SelectedValue;
          
          Utilities.SalvaHistoricoComAlerta(f.Tab);
          CarregaAlertas();

          grdHistorico.AddItem(f.Tab);
        }
      }
    }
    #endregion

    #region private void AlterarHistorico()
    private void AlterarHistorico() 
    {
      if (grdHistorico.SelectedRows.Count != 0)
      {
        int idx = grdHistorico.SelectedRows[0].Index;
        if (idx != -1)
        {
          HTR_HISTORICO h = grdHistorico.GetItem<HTR_HISTORICO>(idx);
          ItemHistorico f = new ItemHistorico();
          f.Tab.Assign(h);
          if (f.Exec()) 
          {
            dsHTR_HISTORICO dsHst = new dsHTR_HISTORICO(Utilities.Cnn);
            h.Assign(f.Tab);

            
            //ALT_ALERTAS Alt

            //dsHst.Save(h);
            Utilities.SalvaHistoricoComAlerta(f.Tab);
            CarregaAlertas();

            grdHistorico.AlterItem(idx, h);
          }
        }
      }
    }
    #endregion

    #region private void RemoverHistorico()
    private void RemoverHistorico() 
    {
      if (grdHistorico.SelectedRows.Count != 0) 
      {
        int idx = grdHistorico.SelectedRows[0].Index;
        if (idx != -1) 
        {
          HTR_HISTORICO h = grdHistorico.GetItem<HTR_HISTORICO>(idx);
          if (lib.Visual.Msg.Question("Tem certeza que deseja remover esta ocorrência?"))
          {
            (new dsHTR_HISTORICO(Utilities.Cnn)).Remove(h.HTR_CODIGO);
            grdHistorico.Rows.RemoveAt(idx);
          } 
        }
      }
    }
    #endregion

    #region private void AdicionarAlerta()
    private void AdicionarAlerta() 
    {
      if (cmbEmpresas.SelectedIndex != -1 && cmbColaborador.SelectedIndex != -1)
      {
        dsALT_ALERTAS dsAlt = new dsALT_ALERTAS(Utilities.Cnn);
        ItemAlerta f = new ItemAlerta();

        if (f.Exec())
        {
          f.Tab.ALT_EMP_CODIGO = (int)cmbEmpresas.SelectedValue;
          f.Tab.ALT_CLB_CODIGO = (int)cmbColaborador.SelectedValue;
          dsAlt.Save(f.Tab);
          lstAlertas.Items.Add(f.Tab);
        }
      }
    }
    #endregion

    #region private void AlterarHistorico()
    private void AlterarAlerta()
    {
      int idx = lstAlertas.SelectedIndex;
      if (idx != -1)
      {
        ALT_ALERTAS a = (ALT_ALERTAS)lstAlertas.SelectedItem;
        ItemAlerta f = new ItemAlerta();
        f.Tab.Assign(a);
        if (f.Exec())
        {
          dsALT_ALERTAS dsAlt = new dsALT_ALERTAS(Utilities.Cnn);
          a.Assign(f.Tab);
          dsAlt.Save(a);
          lstAlertas.Items[idx] = a;
        }
      }
    }
    #endregion

    #region private void RemoverAlerta()
    private void RemoverAlerta()
    {


      int idx = lstAlertas.SelectedIndex;
      if (idx != -1)
      {
        ALT_ALERTAS a = (ALT_ALERTAS)lstAlertas.SelectedItem;
        if (lib.Visual.Msg.Question("Tem certeza que deseja remover este alerta?"))
        {
          (new dsALT_ALERTAS(Utilities.Cnn)).Remove(a.ALT_CODIGO);
          lstAlertas.Items.RemoveAt(idx);
        }
      }

    }
    #endregion

    #region Events
    private void Historico_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void cmbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbEmpresas.SelectedIndex != -1)
      { CarregarColaboradores((int)cmbEmpresas.SelectedValue); }
    }

    private void btnAdicionarHistorico_Click(object sender, EventArgs e)
    {
      AdicionarHistorico();
    }
    
    private void cmbColaborador_SelectedIndexChanged(object sender, EventArgs e)
    {
      CarregaHistoricos();
      CarregaAlertas();
    }
    
    private void btnRemoverHistorico_Click(object sender, EventArgs e)
    {
      RemoverHistorico();
    }

    private void btnAdicionarAlertas_Click(object sender, EventArgs e)
    {
      AdicionarAlerta();
    }

    private void btnRemoverAlertas_Click(object sender, EventArgs e)
    {
      RemoverAlerta();
    }

    private void btnEditarAlerta_Click(object sender, EventArgs e)
    {
      AlterarAlerta();
    }

    private void btnEditarHistorico_Click(object sender, EventArgs e)
    {
      AlterarHistorico();
    }

    private void grdHistorico_DoubleClick(object sender, EventArgs e)
    {
      AlterarHistorico();
    }

    private void grdHistorico_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { AlterarHistorico(); }
    }

    private void grdAlertas_DoubleClick(object sender, EventArgs e)
    {
      AlterarAlerta();
    }

    private void grdAlertas_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { AlterarAlerta(); }
    }
    #endregion
  }
}
