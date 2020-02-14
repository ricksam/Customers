using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Database.Drivers;

namespace Folha_Marcelo.FORMS
{
  public partial class frmResumo : lib.Visual.Models.frmBase
  {
    public frmResumo()
    {
      InitializeComponent();

      Cnv = new lib.Class.Conversion();
      dsLancDiario = new dsLCD_LANCAMENTO_DIARIO(Utilities.Cnn);
      dsLancResumo = new dsLNC_LANCAMENTO(Utilities.Cnn);
      Cfg = (new dsCFG_CONFIG(Utilities.Cnn)).Get();
    }

    dsLCD_LANCAMENTO_DIARIO dsLancDiario { get; set; }
    dsLNC_LANCAMENTO dsLancResumo { get; set; }
    CFG_CONFIG Cfg { get; set; }
    lib.Class.Conversion Cnv { get; set; }

    #region private void Carregar()
    private void Carregar() 
    {
      cmbMes.SelectedIndex = DateTime.Now.Month - 1;
      for (int i = DateTime.Now.Year - 2; i <= (DateTime.Now.Year + 2); i++)
      { cmbAno.Items.Add(i.ToString()); }
      cmbAno.SelectedIndex = 2;

      cmbLoja.ValueMember = "EMP_CODIGO";
      cmbLoja.DisplayMember = "EMP_NOME";
      cmbLoja.DataSource = (new dsEMP_EMPRESA(Utilities.Cnn)).GetList();
    }
    #endregion

    #region private void CarregaColaborador() 
    private void CarregaColaborador() 
    {
      if (cmbLoja.SelectedIndex != -1)
      {
        cmbColaborador.ValueMember = "CLB_CODIGO";
        cmbColaborador.DisplayMember = "CLB_NOME";
        cmbColaborador.DataSource = (new dsCLB_COLABORADOR(Utilities.Cnn)).GetList_FromEmpresa((int)cmbLoja.SelectedValue);          
      }      
    }
    #endregion

    #region private void CarregaLancamentos()
    private void CarregaLancamentos()
    {
      txtTotRemuneracao.AsDecimal = 0;
      txtTotDesconto.AsDecimal = 0;
      txtLiquido.AsDecimal = 0;
      CarregaLancDiarios();
      CarregaResumo();
    }
    #endregion

    #region private void CarregaLancDiarios()
    private void CarregaLancDiarios() 
    {
      if (cmbColaborador.SelectedIndex != -1)
      {
        grdDiario.Clear();
        grdDiario.AddColumn(new lib.Database.Query.FieldColumn("Dia", "LCD_DIA", enmFieldType.Int, 40));
        grdDiario.AddColumn(new lib.Database.Query.FieldColumn("Operação", "OPR_DESCRICAO", enmFieldType.String, 120));
        grdDiario.AddColumn(new lib.Database.Query.FieldColumn("Descrição", "LCD_DESCRICAO", enmFieldType.String, 120));
        grdDiario.AddColumn(new lib.Database.Query.FieldColumn("Ref.", "LCD_REFERENCIA", enmFieldType.Int, 40));
        grdDiario.AddColumn(new lib.Database.Query.FieldColumn("Tipo", "OPR_TIPO", enmFieldType.String, 30));
        grdDiario.AddColumn(new lib.Database.Query.FieldColumn("Valor", "LCD_VALOR", enmFieldType.Decimal, 60));
        grdDiario.AddItems(dsLancDiario.GetList_FromHolerite(cmbMes.SelectedIndex + 1, Cnv.ToInt(cmbAno.Text), (int)cmbColaborador.SelectedValue));
      }
    }
    #endregion

    #region private void CarregaResumo()
    private void CarregaResumo()
    {
      if (cmbColaborador.SelectedIndex != -1)
      {
        grdResumo.Clear();
        grdResumo.AddColumn(new lib.Database.Query.FieldColumn("Operação", "OPR_DESCRICAO", enmFieldType.String, 120));
        grdResumo.AddColumn(new lib.Database.Query.FieldColumn("Ref.", "LNC_REFERENCIA", enmFieldType.Int, 40));
        grdResumo.AddColumn(new lib.Database.Query.FieldColumn("Tipo", "OPR_TIPO", enmFieldType.String, 30));
        grdResumo.AddColumn(new lib.Database.Query.FieldColumn("Valor", "LNC_VALOR", enmFieldType.Decimal, 60));
        LNC_LANCAMENTO[] lncs = dsLancResumo.GetList_FromHolerite(cmbMes.SelectedIndex + 1, Cnv.ToInt(cmbAno.Text), (int)cmbColaborador.SelectedValue);
        grdResumo.AddItems(lncs);

        txtTotRemuneracao.AsDecimal = 0;
        txtTotDesconto.AsDecimal = 0;
        txtLiquido.AsDecimal = 0;

        for (int i = 0; i < lncs.Length; i++)
        { AddCalc(lncs[i].TipoOperacao, lncs[i].LNC_VALOR); }
      }
    }
    #endregion

    #region Funções de Calculo
    private void AddCalc(TipoOperacao TipoOperacao, decimal LNC_VALOR) 
    {
      if (TipoOperacao == TipoOperacao.Credito)
      { AddCalcRemuneracao(LNC_VALOR); }
      else if (TipoOperacao == TipoOperacao.Debito)
      { AddCalcDesconto(LNC_VALOR); }
      Totalizar();
    }
    private void AddCalcRemuneracao(decimal Value) 
    {
      txtTotRemuneracao.AsDecimal += Value;
    }
    private void AddCalcDesconto(decimal Value)
    {
      txtTotDesconto.AsDecimal += Value;
    }
    private void Totalizar() 
    {
      txtLiquido.AsDecimal = txtTotRemuneracao.AsDecimal - txtTotDesconto.AsDecimal;
    }
    private void Calcular() 
    {
      txtTotRemuneracao.Text = "997,43";
      txtTotDesconto.Text = "642,44";
      txtLiquido.Text = "354,99";
    }
    #endregion

    #region private bool FaltaPreencher(lib.Class.LockedField[] lf)
    private bool FaltaPreencher(lib.Class.LockedField[] lf) 
    {
      if (lf.Length != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "\n"; }
        lib.Visual.Msg.Warning("Verifique os campos abaixo:\n" + xMsg);
      }
      return lf.Length != 0;
    }
    #endregion

    #region private void AddLancDiario()
    private void AddLancDiario()
    {
      if (cmbLoja.SelectedIndex != -1 && cmbColaborador.SelectedIndex != -1)
      {
        frmLancDiario ld = new frmLancDiario();
        ld.Tab = new LCD_LANCAMENTO_DIARIO();
        ld.SetDefaultValues(cmbMes.SelectedIndex + 1, Cnv.ToInt(cmbAno.Text), ((CLB_COLABORADOR)cmbColaborador.SelectedItem).CLB_SALARIO);
        if (ld.Exec())
        {
          ld.Tab.LCD_EMP_CODIGO = (int)cmbLoja.SelectedValue;
          ld.Tab.LCD_CLB_CODIGO = (int)cmbColaborador.SelectedValue;

          if (!FaltaPreencher(dsLancDiario.GetLockedFields(ld.Tab)))
          {
            dsLancDiario.Save(ld.Tab);
            grdDiario.AddItem(ld.Tab);
            AtualizaLancResumo(ld.Tab.LCD_OPR_CODIGO, ld.Tab.LCD_VALOR);
          }
        }
      }
    }
    #endregion

    #region private List<MathField> GetMathFields()
    private List<MathField> GetMathFields()
    {
      LNC_LANCAMENTO[] lncs = grdResumo.GetItems<LNC_LANCAMENTO>();
      List<MathField> mfs = new List<MathField>();
      for (int i = 0; i < lncs.Length; i++)
      { mfs.Add(new MathField(lncs[i].OPR_CAMPO, lncs[i].LNC_VALOR)); }

      mfs.Add(new MathField(Cfg.CFG_CAMPO_REMUNERACAO, ((CLB_COLABORADOR)cmbColaborador.SelectedItem).CLB_SALARIO));
      mfs.Add(new MathField(Cfg.CFG_CAMPO_REMUNERACAO_TOTAL, txtTotRemuneracao.AsDecimal));
      mfs.Add(new MathField(Cfg.CFG_CAMPO_DESCONTO_TOTAL, txtTotDesconto.AsDecimal));
      mfs.Add(new MathField(Cfg.CFG_CAMPO_REMUNERACAO_LIQUIDA, txtLiquido.AsDecimal));

      return mfs;
    }
    #endregion

    #region private void AddLancResumo()
    private void AddLancResumo() 
    {
      if (cmbLoja.SelectedIndex != -1 && cmbColaborador.SelectedIndex != -1)
      {
        frmLancResumo ld = new frmLancResumo();
        ld.Tab = new LNC_LANCAMENTO();
        ld.SetDefaultValues(cmbMes.SelectedIndex + 1, Cnv.ToInt(cmbAno.Text), GetMathFields(), Cfg);
        if (ld.Exec())
        {
          ld.Tab.LNC_EMP_CODIGO = (int)cmbLoja.SelectedValue;
          ld.Tab.LNC_CLB_CODIGO = (int)cmbColaborador.SelectedValue;
          if (!FaltaPreencher(dsLancResumo.GetLockedFields(ld.Tab)))
          {
            dsLancResumo.Save(ld.Tab);
            grdResumo.AddItem(ld.Tab);
            AddCalc(ld.Tab.TipoOperacao, ld.Tab.LNC_VALOR);
          }
        }
      }
    }
    #endregion

    #region private void EditLancDiario()
    private void EditLancDiario() 
    {
      if (cmbColaborador.SelectedIndex != -1 && grdDiario.SelectedRows.Count != 0)
      {
        int idx = grdDiario.SelectedRows[0].Index;
        frmLancDiario ld = new frmLancDiario();
        ld.Tab = grdDiario.GetItem<LCD_LANCAMENTO_DIARIO>();        
        ld.SetDefaultValues(cmbMes.SelectedIndex + 1, Cnv.ToInt(cmbAno.Text), ((CLB_COLABORADOR)cmbColaborador.SelectedItem).CLB_SALARIO);
        decimal ValorAnt = ld.Tab.LCD_VALOR;
        if (ld.Exec())
        {
          dsLancDiario.Save(ld.Tab);
          grdDiario.AlterItem(idx, ld.Tab);
          AtualizaLancResumo(ld.Tab.LCD_OPR_CODIGO, ld.Tab.LCD_VALOR - ValorAnt);
        }
      }
    }
    #endregion

    #region private void EditLancResumo()
    private void EditLancResumo() 
    {
      if (cmbColaborador.SelectedIndex != -1 && grdResumo.SelectedRows.Count != 0)
      {
        int idx = grdResumo.SelectedRows[0].Index;
        frmLancResumo ld = new frmLancResumo();
        ld.Tab = grdResumo.GetItem<LNC_LANCAMENTO>();

        if (ld.Tab.OPR_DIARIO)
        {
          lib.Visual.Msg.Warning("Não é possível alterar lançamentos ligados a lançamentos diários");
          return;
        }

        ld.SetDefaultValues(cmbMes.SelectedIndex + 1, Cnv.ToInt(cmbAno.Text), GetMathFields(), Cfg);
        decimal ValorAnt = ld.Tab.LNC_VALOR;
        if (ld.Exec())
        {
          dsLancResumo.Save(ld.Tab);
          grdResumo.AlterItem(idx, ld.Tab);

          AddCalc(ld.Tab.TipoOperacao, -ValorAnt);
          AddCalc(ld.Tab.TipoOperacao, ld.Tab.LNC_VALOR);
        }
      }
    }
    #endregion

    #region private void RemoveLancDiario()
    private void RemoveLancDiario() 
    {
      if (grdDiario.SelectedRows.Count != 0) 
      {
        int idx = grdDiario.SelectedRows[0].Index;
        LCD_LANCAMENTO_DIARIO lcd = grdDiario.GetItem<LCD_LANCAMENTO_DIARIO>();
        dsLancDiario.Remove(lcd.LCD_CODIGO);
        grdDiario.Rows.RemoveAt(idx);

        AtualizaLancResumo(lcd.LCD_OPR_CODIGO, -lcd.LCD_VALOR);
        RemoveLancResumo(lcd.LCD_OPR_CODIGO);
      }
    }
    #endregion

    #region private void RemoveLancResumo()
    private void RemoveLancResumo() 
    {
      if (grdResumo.SelectedRows.Count != 0)
      {
        int idx = grdResumo.SelectedRows[0].Index;

        LNC_LANCAMENTO Tab = grdResumo.GetItem<LNC_LANCAMENTO>();

        if (Tab.OPR_DIARIO)
        {
          lib.Visual.Msg.Warning("Não é possível remover lançamentos ligados a lançamentos diários");
          return;
        }

        dsLancResumo.Remove(Tab.LNC_CODIGO);
        grdResumo.Rows.RemoveAt(idx);
        AddCalc(Tab.TipoOperacao, -Tab.LNC_VALOR);
      }
    }
    #endregion

    #region private void AtualizaLancResumo(int OPR_CODIGO, decimal Valor)
    private void AtualizaLancResumo(int OPR_CODIGO, decimal Valor) 
    {
      int Mes = cmbMes.SelectedIndex + 1;
      int Ano = Cnv.ToInt(cmbAno.Text);
      int EMP_CODIGO = (int)cmbLoja.SelectedValue;
      int CLB_CODIGO = (int)cmbColaborador.SelectedValue;

      LCD_LANCAMENTO_DIARIO[] lcds = dsLancDiario.GetList_FromOperacao(Mes, Ano, CLB_CODIGO, OPR_CODIGO);
      LNC_LANCAMENTO lanc = dsLancResumo.Get_FromOperacao(Mes, Ano, CLB_CODIGO, OPR_CODIGO);

      lanc.LNC_MES = Mes;
      lanc.LNC_ANO = Ano;
      lanc.LNC_EMP_CODIGO = EMP_CODIGO;
      lanc.LNC_CLB_CODIGO = CLB_CODIGO;
      lanc.LNC_OPR_CODIGO = OPR_CODIGO;
      lanc.LNC_REFERENCIA = lcds.Length;
      lanc.LNC_VALOR += Valor;
      
      dsLancResumo.Save(lanc);

      CarregaResumo();
    }
    #endregion

    #region private void RemoveLancResumo(int OPR_CODIGO)
    private void RemoveLancResumo(int OPR_CODIGO) 
    {
      LCD_LANCAMENTO_DIARIO[] lcds = dsLancDiario.GetList_FromOperacao(cmbMes.SelectedIndex + 1, Cnv.ToInt(cmbAno.Text), (int)cmbColaborador.SelectedValue, OPR_CODIGO);
      if (lcds.Length == 0)
      {
        dsLancResumo.Remove_FromOperacao(cmbMes.SelectedIndex + 1, Cnv.ToInt(cmbAno.Text), (int)cmbColaborador.SelectedValue, OPR_CODIGO);
        CarregaResumo();
      }
    }
    #endregion

    #region private void Imprimir()
    private void Imprimir()
    {
      List<SqlWebReport.ParamQuery> p = new List<SqlWebReport.ParamQuery>();
      p.Add(new SqlWebReport.ParamQuery(cmbMes.SelectedIndex + 1, SqlWebReport.FieldType.Int));
      p.Add(new SqlWebReport.ParamQuery(cmbAno.Text, SqlWebReport.FieldType.Int));
      p.Add(new SqlWebReport.ParamQuery(cmbColaborador.SelectedValue, SqlWebReport.FieldType.Int));
      Utilities.ExibeReport("Lancamentos_Colaborador_Inner", p);
    }
    #endregion

    #region Event
    private void frmResumo_Load(object sender, EventArgs e)
    {
      Carregar();
    }

    private void cmbLoja_SelectedIndexChanged(object sender, EventArgs e)
    {
      CarregaColaborador();
    }
    
    private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AddLancDiario();
    }

    private void removerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      RemoveLancDiario();
    }

    private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      AddLancResumo();
    }

    private void removerToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      RemoveLancResumo();
    }

    private void grdDiario_DoubleClick(object sender, EventArgs e)
    {
      EditLancDiario();
    }

    private void grdResumo_DoubleClick(object sender, EventArgs e)
    {
      EditLancResumo();
    }

    private void grdDiario_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { EditLancDiario(); }
    }

    private void grdResumo_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { EditLancResumo(); }
    }
    
    private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
    {
      CarregaLancamentos();
    }

    private void cmbAno_SelectedIndexChanged(object sender, EventArgs e)
    {
      CarregaLancamentos();
    }

    private void cmbColaborador_SelectedIndexChanged(object sender, EventArgs e)
    {
      CarregaLancamentos();
    }

    private void btnAtualizar_Click(object sender, EventArgs e)
    {
      CarregaLancamentos();
    }
    
    private void button1_Click(object sender, EventArgs e)
    {
      Imprimir();
    }
    #endregion
  }
}
