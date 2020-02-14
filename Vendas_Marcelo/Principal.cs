using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using lib.Database;
using lib.Database.Drivers;

namespace Vendas_Marcelo
{
  public partial class Form1 : lib.Visual.Models.frmBase
  {
    #region Constructor
    public Form1()
    {
      InitializeComponent();

      try
      {
        Utilities.Start();
      }
      catch (Exception ex)
      { lblError.Text = ex.Message; }

      Cnv = new lib.Class.Conversion();
      Cfg = new Config();
      Cfg.Open();

      txtTempo.Text = Cfg.Sleep.ToString();
      txtProgram.Text = Cfg.Program;
      txtArguments.Text = Cfg.Arguments;
    }

    public Form1(string[] Args) 
      :this()
    {
      if (Args.Length == 0)
      {
        grpConfiguracoes.Enabled = false;
        if (Cfg.Sleep != 0)
        { tmrProcesso.Interval = Cfg.Sleep; }
        tmrProcesso.Enabled = true;        
      }      
    }
    #endregion

    #region Fields
    public const string LinkSql = "http://www.rcksoftware.com.br/app/marcelo_vendas/sql_{0}.html";
    public const string LinkPost = "http://www.rcksoftware.com.br/app/marcelo_vendas/service1.2.php?method=post";

    public const string LinkSqlQtdeVenda = "http://www.rcksoftware.com.br/app/marcelo_vendas/sqlQtdeVenda_{0}.html";
    public const string LinkQtdeVendaAdd = "http://www.rcksoftware.com.br/app/marcelo_vendas/service1.2.php?method=qtdevenda.add";

    public Config Cfg { get; set; }
    public lib.Class.Conversion Cnv { get; set; }
    #endregion

    private string GetWebSQL(string link) 
    {
      string sql = "";
      for (int i = 0; i < 10; i++)
      {
        try
        {
          sql = lib.Class.WebUtils.GetWebResponse(link);
          if (!string.IsNullOrEmpty(sql))
          { break; }
        }
        catch
        { System.Threading.Thread.Sleep(500); }
      }

      return sql;
    }

    #region private void ProcessaAtualizacao()
    private void ProcessaAtualizacao()
    {
      try
      {
        #region Pesquisa sql internet
        lblProcess.Text = "Verificando internet ...";
        this.Refresh();
        string sql = GetWebSQL(string.Format(LinkSql, Utilities.Cnn.dbType.ToString()));
        #endregion

        if (string.IsNullOrEmpty(sql))
        { lblError.Text = "arquivo sql vazio"; }
        else
        {
          #region Pesquisa dados no banco e envia para internet
          lblProcess.Text = "Enviando vendas ...";
          this.Refresh();
          DataSource ds = new DataSource(Utilities.Cnn.GetDataTable(sql));
          for (int i = 0; i < ds.Count; i++)
          {
            lblProcess.Text = string.Format("Enviando vendas operador {0} do dia {1} ...",
              ds.GetField(i, "operador").ToString(),
              ds.GetField(i, "emissao").ToDateTime().ToString("dd/MMM"));

            this.Refresh();
            string postData = string.Format(
              @"cnpj={0}&empresa={1}&emissao={2}&cod_operador={3}&operador={4}&inicio={5}&cupons={6}&total={7}",
              ds.GetField(i, "cnpj").ToString(),
              ds.GetField(i, "empresa").ToString(),
              ds.GetField(i, "emissao").ToDateTime().ToString("yyyy-MM-dd"),
              ds.GetField(i, "cod_operador").ToString(),
              ds.GetField(i, "operador").ToString(),
              ds.GetField(i, "inicio").ToDateTime().ToString("HH:mm:ss"),
              ds.GetField(i, "cupons").ToString(),
              ds.GetField(i, "total").ToDecimal().ToString("0.0000").Replace(",", ".")
            );

            string ret = lib.Class.WebUtils.GetWebResponse(LinkPost, postData);
            if (ret != "sucessfully")
            {
              lblError.Text = ret;
              lblError.Refresh();
              return; 
            }
          }
          #endregion
        }
      }
      catch (Exception ex)
      { lblError.Text = ex.Message; }
      finally
      {
        lblProcess.Refresh();
        lblError.Refresh();
      }
    }
    #endregion

    #region private void ProcessaAtualizacao()
    private void ProcessaQtdeVendas()
    {
      try
      {
        #region Pesquisa sql internet
        lblProcess.Text = "Verificando internet ...";
        this.Refresh();
        string sql = GetWebSQL(string.Format(LinkSqlQtdeVenda, Utilities.Cnn.dbType.ToString()));
        #endregion

        if (string.IsNullOrEmpty(sql))
        { lblError.Text = "arquivo sql vazio"; }
        else
        {
          #region Pesquisa dados no banco e envia para internet
          lblProcess.Text = "Enviando vendas ...";
          this.Refresh();
          DataSource ds = new DataSource(Utilities.Cnn.GetDataTable(sql));
          for (int i = 0; i < ds.Count; i++)
          {
            lblProcess.Text = string.Format("Enviando vendas operador {0} do dia {1} ...",
              ds.GetField(i, "empresa").ToString(),
              ds.GetField(i, "emissao").ToDateTime().ToString("dd/MMM"));

            this.Refresh();
            string postData = string.Format(
              @"cnpj={0}&empresa={1}&emissao={2}&menor={3}&maior={4}&contagem={5}&diferenca={6}",
              ds.GetField(i, "cnpj").ToString(),
              ds.GetField(i, "empresa").ToString(),
              ds.GetField(i, "emissao").ToDateTime().ToString("yyyy-MM-dd"),
              ds.GetField(i, "menor").ToInt(),
              ds.GetField(i, "maior").ToInt(),
              ds.GetField(i, "contagem").ToInt(),
              ds.GetField(i, "diferenca").ToInt()
            );

            string ret = lib.Class.WebUtils.GetWebResponse(LinkQtdeVendaAdd, postData);
            lblError.Text = ret;
            lblError.Refresh();
            if (ret != "sucessfully")
            { return; }
          }
          #endregion
        }
      }
      catch (Exception ex)
      { lblError.Text = ex.Message; }
      finally
      {
        lblProcess.Refresh();
        lblError.Refresh();        
      }
    }
    #endregion

    #region Events
    private void btnSave_Click(object sender, EventArgs e)
    {
      Cfg.Sleep = Cnv.ToInt(txtTempo.Text);
      Cfg.Program = txtProgram.Text;
      Cfg.Arguments = txtArguments.Text;
      Cfg.Save();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      { txtProgram.Text = dlgOpen.FileName; }
    }

    private void tmrProcesso_Tick(object sender, EventArgs e)
    {
      try
      {
        tmrProcesso.Enabled = false;
        ProcessaAtualizacao();
        ProcessaQtdeVendas();
        System.Threading.Thread.Sleep(5000);

        #region Processa programa configurado
        lblProcess.Text = "Concluindo ...";
        this.Refresh();
        if (!string.IsNullOrEmpty(Cfg.Program))
        { lib.Class.Instance.ExecProcess(Cfg.Program, Cfg.Arguments, false); }
        #endregion

        this.Close();
      }
      catch 
      { this.Close(); }
    }
    #endregion

    private void btnBanco_Click(object sender, EventArgs e)
    {
      lib.Visual.Forms.FormConnection fc = new lib.Visual.Forms.FormConnection(lib.Visual.Functions.GetDirAppCondig());
      fc.Exec();
    }

    private void sknButton1_Click(object sender, EventArgs e)
    {
      string postData = string.Format(
              @"cnpj={0}&empresa={1}&emissao={2}&cod_operador={3}&operador={4}&inicio={5}&cupons={6}&total={7}",
              "11.111.111/0000-11",
              "TESTE",
              "2011-01-01",
              "1",
              "OPERADOR",
              "00:00:00",
              "1",
              "0.00"
            );

      string ret = lib.Class.WebUtils.GetWebResponse(LinkPost, postData);
      MessageBox.Show(ret);
    }
  }
}
