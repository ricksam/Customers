using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Database.Drivers;
using lib.Database.Query;
using lib.Visual;

namespace Financeiro_Marcelo.View.Cartoes
{
  public partial class LancaCartoes : lib.Visual.Models.frmBase
  {
    public LancaCartoes()
    {
      InitializeComponent();
      dsLanc = new dsLNC_LANC_CARTOES(Utilities.Cnn);
    }

    dsLNC_LANC_CARTOES dsLanc { get; set; }

    #region private void Carregar()
    private void Carregar() 
    {
      dtEmissao.Value = DateTime.Now;
      cmbEmpresa.ValueMember = "EMP_CODIGO";
      cmbEmpresa.DisplayMember = "EMP_DESCRICAO";
      cmbEmpresa.DataSource = (new dsEMP_EMPRESAS(Utilities.Cnn)).GetList();
    }
    #endregion

    #region private void AddTotal(decimal Valor, decimal Taxas, decimal Receber)
    private void AddTotal(decimal Valor, decimal Taxas, decimal Receber)
    {
      txtValorTotal.AsDecimal += Valor;
      txtTotalTaxas.AsDecimal += Taxas;
      txtTotalReceber.AsDecimal += Receber;
    }
    #endregion

    #region private void AdicionarCartao()
    private void AdicionarCartao() 
    {
      if (cmbEmpresa.SelectedIndex == -1) 
      {
        Msg.Warning("Informe a empresa antes de adicionar o cartão");
        return;
      }

      ItemCartoes fi = new ItemCartoes();
      fi.EMP_CODIGO = (int)cmbEmpresa.SelectedValue;
      fi.Tab = new LNC_LANC_CARTOES();
      fi.Tab.LNC_EMISSAO = dtEmissao.Value;
      if (fi.Exec()) 
      {
        dsLanc.Save(fi.Tab);
        AddTotal(fi.Tab.LNC_VALOR, fi.Tab.LNC_VALOR_TAXA, fi.Tab.LNC_VALOR_RECEBER);
        grdCartoes.AddItem(fi.Tab);
      }
    }
    #endregion

    #region private void AlterarCartao()
    private void AlterarCartao() 
    {
      if (cmbEmpresa.SelectedIndex == -1)
      {
        Msg.Warning("Informe a empresa antes de adicionar o cartão");
        return;
      }

      
      if (grdCartoes.SelectedRows.Count == 0)
      { return; }

      int idx = grdCartoes.SelectedRows[0].Index;

      LNC_LANC_CARTOES lanc = grdCartoes.GetItem<LNC_LANC_CARTOES>();
      if (lanc.LNC_DATA_PGTO != DateTime.MinValue)
      {
        Msg.Information("Não é permitido alter um cartão quitado");
        return;
      }

      ItemCartoes fi = new ItemCartoes();
      fi.EMP_CODIGO = (int)cmbEmpresa.SelectedValue;
      fi.Tab = new LNC_LANC_CARTOES();
      fi.Tab.Assign(lanc);

      decimal AntValor = fi.Tab.LNC_VALOR;
      decimal AntTaxas = fi.Tab.LNC_VALOR_TAXA;
      decimal AntReceber = fi.Tab.LNC_VALOR_RECEBER;

      if (fi.Exec())
      {
        dsLanc.Save(fi.Tab);
        AddTotal(-AntValor, -AntTaxas, -AntReceber);
        AddTotal(fi.Tab.LNC_VALOR, fi.Tab.LNC_VALOR_TAXA, fi.Tab.LNC_VALOR_RECEBER);
        grdCartoes.AlterItem(idx, fi.Tab);
      }
    }
    #endregion

    #region private void RemoverCartao()
    private void RemoverCartao() 
    {
      if (grdCartoes.SelectedRows.Count == 0)
      { return; }

      int idx = grdCartoes.SelectedRows[0].Index;

      LNC_LANC_CARTOES lanc = grdCartoes.GetItem<LNC_LANC_CARTOES>();
      if (lanc.LNC_DATA_PGTO != DateTime.MinValue)
      {
        Msg.Information("Não é permitido remover um cartão quitado");
        return;
      }

      if (Msg.Question("Tem certeza que deseja remover este cartão?")) 
      {
        AddTotal(-lanc.LNC_VALOR, -lanc.LNC_VALOR_TAXA, -lanc.LNC_VALOR_RECEBER);
        dsLanc.Remove(lanc.LNC_CODIGO);
        grdCartoes.Rows.RemoveAt(idx);        
      }
    }
    #endregion

    #region private void PesquisarCartao()
    private void PesquisarCartao()
    {
      if (cmbEmpresa.SelectedIndex != -1 && dtEmissao.Value != DateTime.MinValue)
      {
        LNC_LANC_CARTOES[] lst = dsLanc.GetList((int)cmbEmpresa.SelectedValue, dtEmissao.Value);

        grdCartoes.Clear();
        grdCartoes.AddColumn(new FieldColumn("Cartão", "CRT_DESCRICAO", enmFieldType.String, 180));
        grdCartoes.AddColumn(new FieldColumn("Emissão", "LNC_EMISSAO", enmFieldType.Date));
        grdCartoes.AddColumn(new FieldColumn("Vencimento", "LNC_VENCIMENTO", enmFieldType.Date));
        grdCartoes.AddColumn(new FieldColumn("Data Pgto.", "LNC_DATA_PGTO", enmFieldType.Date));
        grdCartoes.AddColumn(new FieldColumn("Valor", "LNC_VALOR", enmFieldType.Decimal, 90));
        grdCartoes.AddColumn(new FieldColumn("Taxa", "LNC_VALOR_TAXA", enmFieldType.Decimal, 90));
        grdCartoes.AddColumn(new FieldColumn("a Receber", "LNC_VALOR_RECEBER", enmFieldType.Decimal, 90));
        grdCartoes.AddItems(lst);

        txtValorTotal.AsDecimal = 0;
        txtTotalTaxas.AsDecimal = 0;
        txtTotalReceber.AsDecimal = 0;

        for (int i = 0; i < lst.Length; i++)
        { AddTotal(lst[i].LNC_VALOR, lst[i].LNC_VALOR_TAXA, lst[i].LNC_VALOR_RECEBER); }
      }
    }
    #endregion

    #region Events
    private void btnAdicionar_Click(object sender, EventArgs e)
    {
      AdicionarCartao();
    }

    private void dtEmissao_ValueChanged(object sender, EventArgs e)
    {
      PesquisarCartao();
    }

    private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
    {
      PesquisarCartao();
    }

    private void LancaCartoes_Load(object sender, EventArgs e)
    {
      Carregar();
    }
    
    private void removerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      RemoverCartao();
    }

    private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AdicionarCartao();
    }
    
    private void grdCartoes_DoubleClick(object sender, EventArgs e)
    {
      AlterarCartao();
    }

    private void grdCartoes_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { AlterarCartao(); }
    }
    #endregion
  }
}
