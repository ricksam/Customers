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

namespace Financeiro_Marcelo
{
  public partial class CarregaVendas : lib.Visual.Models.frmDialog
  {
    #region public CarregaVendas()
    public CarregaVendas()
    {
      InitializeComponent();
      dsVda = new dsVDA_VENDA(Utilities.Cnn);
    }

    public CarregaVendas(bool Encerrar):this() 
    {
      this.EncerrarAoCarregar = Encerrar;
    }
    #endregion

    #region Feilds
    dsVDA_VENDA dsVda { get; set; }
    //public VDA_VENDA SelVda { get; set; }
    //public int NrFormulario { get { return txtNuFormulario.AsInt; } }
    public bool EncerrarAoCarregar { get; set; }
    #endregion

    #region private void CarregarVendasOnline()
    private void CarregarVendasOnline() 
    {
      lib.Class.Conversion Cnv = new lib.Class.Conversion();
      Config Cfg = new Config();
      Cfg.Open();

      lblSincronismo.Text = "Carregando vendas ...";
      this.Refresh();
      dsVendasOnLine bsVdaOn = new dsVendasOnLine();

      VendasOnLine[] VdaOnList = null;

      try
      { VdaOnList = bsVdaOn.Get(); }
      catch (Exception ex)
      {
        Utilities.FormError.ShowError(ex);
        return;
      }

      pbSincronismo.Maximum = VdaOnList.Length;
      for (int i = 0; i < VdaOnList.Length; i++)
      {
        lblSincronismo.Text = string.Format("Gravando venda : loja {0} data {1} operador {2}", VdaOnList[i].empresa, Cnv.ToDateTime(VdaOnList[i].emissao).ToString("dd/MMM"), VdaOnList[i].operador);
        this.Refresh();
        pbSincronismo.Value = i + 1;
        VDA_VENDA Vda = dsVda.Get_LocalizaVenda(VdaOnList[i]);        
        Vda.VDA_EMISSAO = Cnv.ToDateTime(VdaOnList[i].emissao);
        Vda.VDA_CNPJ = VdaOnList[i].cnpj;
        Vda.VDA_EMPRESA = VdaOnList[i].empresa;
        Vda.VDA_INICIO = VdaOnList[i].inicio;
        Vda.VDA_OPERADOR = VdaOnList[i].operador;
        Vda.VDA_COD_OPERADOR = VdaOnList[i].cod_operador;
        Vda.VDA_CUPONS = VdaOnList[i].cupons;
        Vda.VDA_TOTAL = VdaOnList[i].total;
        dsVda.Save(Vda);

        if (Cfg.RemoveVendasOnLine)
        {
          if (dsVda.Save(Vda))
          { bsVdaOn.Delete(VdaOnList[i].id); }
        }
      }
      pbSincronismo.Value = 0;
      lblSincronismo.Text = "";
    }
    #endregion

    #region private List<SqlWebReport.ParamQuery> GetParametrosReportMes()
    private List<SqlWebReport.ParamQuery> GetParametrosReportMes() 
    {
      List<SqlWebReport.ParamQuery> lpar = new List<SqlWebReport.ParamQuery>();
      if (dsVda.ExisteVendaEsteMes())
      {
        lpar.Add(new SqlWebReport.ParamQuery(DateTime.Now.Month, SqlWebReport.FieldType.Int));
        lpar.Add(new SqlWebReport.ParamQuery(DateTime.Now.Year, SqlWebReport.FieldType.Int));
        lpar.Add(new SqlWebReport.ParamQuery(DateTime.Now.Day, SqlWebReport.FieldType.Int));
      }
      else
      {
        lpar.Add(new SqlWebReport.ParamQuery(DateTime.Now.AddDays(-DateTime.Now.Day).Month, SqlWebReport.FieldType.Int));
        lpar.Add(new SqlWebReport.ParamQuery(DateTime.Now.AddDays(-DateTime.Now.Day).Year, SqlWebReport.FieldType.Int));
        lpar.Add(new SqlWebReport.ParamQuery(0, SqlWebReport.FieldType.Int));
      }

      return lpar;
    }
    #endregion

    #region private void EnviaVendasEmail()
    private void EnviaVendasEmail() 
    {
      Config cfg = new Config();
      cfg.Open();

      if (cfg.UltimoEnvioVendas != DateTime.Now.ToString("dd/MM/yyyy"))
      {
        lib.Class.Mail mail = Utilities.GetMailUser(cfg.Email);

        if (mail != null)
        {
          Utilities.SendReportEmail("VendasEmailMensal", GetParametrosReportMes(), mail, Utilities.GetListaContatos());                    
          cfg.UltimoEnvioVendas = DateTime.Now.ToString("dd/MM/yyyy");
          cfg.Save();
        }
      }
    }
    #endregion

    #region private void CarregarVendasBanco()
    private void CarregarVendasBanco()
    {
      grdVendas.Clear();
      grdVendas.AddColumn(new FieldColumn("Empresa", "VDA_EMPRESA", enmFieldType.String, 120));
      grdVendas.AddColumn(new FieldColumn("CNPJ", "VDA_CNPJ", enmFieldType.String, 120));
      grdVendas.AddColumn(new FieldColumn("Emissão", "VDA_EMISSAO", enmFieldType.Date));
      grdVendas.AddColumn(new FieldColumn("Operador", "VDA_OPERADOR", enmFieldType.String, 120));
      grdVendas.AddColumn(new FieldColumn("Cupons", "VDA_CUPONS", enmFieldType.Int));
      grdVendas.AddColumn(new FieldColumn("Total", "VDA_TOTAL", enmFieldType.Decimal));
      VDA_VENDA[] vdas = dsVda.GetList_SemFormulario();
      grdVendas.AddItems(vdas);
      lblTotal.Text = "Total:" + vdas.Length + " registros.";
    }
    #endregion

    #region private void EditaVendas()
    private void EditaVendas() 
    {
      if (grdVendas.RowCount != 0)
      {
        EditarVendas ed = new EditarVendas();
        VDA_VENDA Vda = grdVendas.GetItem<VDA_VENDA>();
        ed.CarregarVenda(Vda);
        if (ed.Exec())
        {
          if (ed.SelForm != null)
          {
            Vda.VDA_FRM_CODIGO = ed.SelForm.FRM_CODIGO;
            dsVda.SaveNrForm(Vda);
            //bsVda.Save(Vda);
            CarregarVendasBanco();
          }
        }
      }
    }
    #endregion

    #region private void EditarLancamentos()
    private void EditarLancamentos(VDA_VENDA Vda)
    {
      EMP_EMPRESAS emp = (new dsEMP_EMPRESAS(Utilities.Cnn)).Get_FromDescricaoOnLine(Vda.VDA_EMPRESA);

      if (emp.EMP_CODIGO == 0) 
      {
        Msg.Information("Empresa não identificada");
        return;
      }

      Financeiro f = new Financeiro();
      f.Vda = Vda;
      f.Frm = (new dsFRM_FORMULARIOS(Utilities.Cnn)).Get(emp.EMP_CODIGO, txtNuFormulario.AsInt, Vda.VDA_EMISSAO);

      if (txtNuFormulario.AsInt == 0)
      {
        Msg.Information("Informe o número do formulário");
        return;
      }

      //Isto parece estar repetido porém serve para novos formulário
      f.Frm.FRM_EMP_CODIGO = emp.EMP_CODIGO;
      f.Frm.FRM_NUMERO = txtNuFormulario.AsInt;
      f.Frm.FRM_DATA = Vda.VDA_EMISSAO;

      if (f.Frm.FRM_BLOQUEADO && !Utilities.Liberar())
      { return; }

      f.Exec();

      //CarregaUltimosLancamentos();
      //cmbEmpresa.Select();
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      if (grdVendas.SelectedRows.Count != 0)
      {
        EditarLancamentos(grdVendas.GetItem<VDA_VENDA>());
        CarregarVendasBanco();
        //base.OnConfirm();
      }
    }
    #endregion

    #region private void tmrVendas_Tick(object sender, EventArgs e)
    private void tmrVendas_Tick(object sender, EventArgs e)
    {
      tmrVendas.Enabled = false;
      CarregarVendasOnline();
      CarregarVendasBanco();
      grpVendas.Enabled = true;
      grdVendas.Enabled = true;
      System.Threading.Thread trEmail = new System.Threading.Thread(new System.Threading.ThreadStart(EnviaVendasEmail)); 
      trEmail.Start();

      if (EncerrarAoCarregar) 
      {
        while (trEmail.IsAlive)
        { System.Threading.Thread.Sleep(100); }

        this.VerifyCancel = false;
        this.Close();
      }
    }
    #endregion

    #region private void grdVendas_KeyDown(object sender, KeyEventArgs e)
    private void grdVendas_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter) 
      { EditaVendas(); }
    }
    #endregion

    #region private void grdVendas_DoubleClick(object sender, EventArgs e)
    private void grdVendas_DoubleClick(object sender, EventArgs e)
    {
      EditaVendas();
    }
    #endregion

    #region private void sknButton1_Click(object sender, EventArgs e)
    private void sknButton1_Click(object sender, EventArgs e)
    {
      Utilities.ExibeReport(this.MdiParent, "VendasEmailMensal", GetParametrosReportMes());
    }
    #endregion
  }
}
