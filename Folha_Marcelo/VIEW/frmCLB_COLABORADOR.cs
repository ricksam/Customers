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

namespace Folha_Marcelo
{
  public partial class frmCLB_COLABORADOR : lib.Visual.Models.frmBaseCadastro
  {
    public frmCLB_COLABORADOR()
    {
      InitializeComponent();
      ds = new dsCLB_COLABORADOR(Utilities.Cnn);
    }

    CLB_COLABORADOR Tab { get; set; }
    dsCLB_COLABORADOR ds { get; set; }

    #region private void Carregar()
    private void Carregar()
    {
      cmbCLB_ESTADO.Items.Clear();
      cmbCLB_ESTADO.Items.AddRange((new dsSTATES(Utilities.CnnAddress)).GetList());

      cmbEmpresa.ValueMember = "EMP_CODIGO";
      cmbEmpresa.DisplayMember = "EMP_NOME";
      cmbEmpresa.DataSource = (new dsEMP_EMPRESA(Utilities.Cnn)).GetList();

      if (Tab.CLB_EMP_CODIGO != 0)
      { cmbEmpresa.SelectedValue = Tab.CLB_EMP_CODIGO; }
      else 
      { cmbEmpresa.SelectedValue = -1; }

      txtCLB_NOME.Text = Tab.CLB_NOME;
      txtCLB_CPF.Text = Tab.CLB_CPF;
      txtCLB_RG.Text = Tab.CLB_RG;
      txtCLB_FONE.Text = Tab.CLB_FONE;
      txtCLB_RECADO.Text = Tab.CLB_RECADO;
      txtCLB_CEP.Text = Tab.CLB_CEP;
      PesquisaCEP();
      cmbCLB_LOGRADOURO.Text = Tab.CLB_LOGRADOURO;
      txtCLB_NUMERO.Text = Tab.CLB_NUMERO;
      cmbCLB_BAIRRO.Text = Tab.CLB_BAIRRO;
      txtCLB_CIDADE.Text = Tab.CLB_CIDADE;
      cmbCLB_ESTADO.Text = Tab.CLB_ESTADO;
      txtCLB_OBS.Text = Tab.CLB_OBS;
      if (!string.IsNullOrEmpty(Tab.CLB_FOTO))
      { imgFoto.Image = lib.Class.ProcessImage.StringToImage(Tab.CLB_FOTO); }
      else if (imgFoto.Image != null)
      {
        imgFoto.Image.Dispose();
        imgFoto.Image = null;
      }
      txtCLB_SALARIO.AsDecimal = Tab.CLB_SALARIO;
      txtCLB_DTNASC.AsDateTime = Tab.CLB_DTNASC;
      cbCLB_INATIVO.Checked = Tab.CLB_INATIVO;
      
      CarregaHistoricos();
      CarregaAlertas();

      tbcCadastro.SelectedIndex = 0;
      txtCLB_NOME.Select();
    }
    #endregion

    #region protected override void OnNewRecord()
    protected override void OnNewRecord()
    {
      base.OnNewRecord();
      Tab = new CLB_COLABORADOR();
      Carregar();
    }
    #endregion

    #region protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      base.OnAlterRecord(Grid);
      Tab = Grid.GetItem<CLB_COLABORADOR>();
      Carregar();
    }
    #endregion

    #region protected override void OnRemoveRecord()
    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover o registro {0}", Tab.CLB_CODIGO)))
      { ds.Remove(Tab.CLB_CODIGO); }
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

        if (lf[0].Field == "CLB_EMP_CODIGO")
        { cmbEmpresa.Select(); }
        else if (lf[0].Field == "CLB_NOME")
        { txtCLB_NOME.Select(); }
        else if (lf[0].Field == "CLB_FONE")
        { txtCLB_FONE.Select(); }
        else if (lf[0].Field == "CLB_RECADO")
        { txtCLB_RECADO.Select(); }
        else if (lf[0].Field == "CLB_LOGRADOURO")
        { cmbCLB_LOGRADOURO.Select(); }
        else if (lf[0].Field == "CLB_NUMERO")
        { txtCLB_NUMERO.Select(); }
        else if (lf[0].Field == "CLB_BAIRRO")
        { cmbCLB_BAIRRO.Select(); }
        else if (lf[0].Field == "CLB_CIDADE")
        { txtCLB_CIDADE.Select(); }
        else if (lf[0].Field == "CLB_ESTADO")
        { cmbCLB_ESTADO.Select(); }
        else if (lf[0].Field == "CLB_CEP")
        { txtCLB_CEP.Select(); }
        else if (lf[0].Field == "CLB_OBS")
        { txtCLB_OBS.Select(); }        
        else if (lf[0].Field == "CLB_SALARIO")
        { txtCLB_SALARIO.Select(); }
      }

      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      if (cmbEmpresa.SelectedIndex != -1)
      { Tab.CLB_EMP_CODIGO = (int)cmbEmpresa.SelectedValue; }

      Tab.CLB_NOME = txtCLB_NOME.Text;
      Tab.CLB_CPF = txtCLB_CPF.OriginalText;
      Tab.CLB_RG = txtCLB_RG.OriginalText;
      Tab.CLB_FONE = txtCLB_FONE.Text;
      Tab.CLB_RECADO = txtCLB_RECADO.Text;
      Tab.CLB_LOGRADOURO = cmbCLB_LOGRADOURO.Text;
      Tab.CLB_NUMERO = txtCLB_NUMERO.Text;
      Tab.CLB_BAIRRO = cmbCLB_BAIRRO.Text;
      Tab.CLB_CIDADE = txtCLB_CIDADE.Text;
      Tab.CLB_ESTADO = cmbCLB_ESTADO.Text;
      Tab.CLB_CEP = txtCLB_CEP.Text;
      Tab.CLB_OBS = txtCLB_OBS.Text;
      if (imgFoto.Image != null)
      { Tab.CLB_FOTO = lib.Class.ProcessImage.ImageToString(imgFoto.Image); }
      Tab.CLB_SALARIO = txtCLB_SALARIO.AsDecimal;
      Tab.CLB_DTNASC = txtCLB_DTNASC.AsDateTime;
      Tab.CLB_INATIVO = cbCLB_INATIVO.Checked;
      if (!FaltaPreencher())
      {
        bool GeraOcorrenciasNovas = Tab.CLB_CODIGO == 0;
        try
        {
          Utilities.Cnn.BeginTransaction();
          ds.Save(Tab);

          if (GeraOcorrenciasNovas)
          {
            CFG_CONFIG Cfg = (new dsCFG_CONFIG(Utilities.Cnn)).Get();
            // Aviversário
            DateTime dtProximoAniversario = Tab.CLB_DTNASC;
            while (dtProximoAniversario < DateTime.Now)
            { dtProximoAniversario = dtProximoAniversario.AddYears(1); }

            dsALT_ALERTAS dsAlt = new dsALT_ALERTAS(Utilities.Cnn);
            ALT_ALERTAS Alt = new ALT_ALERTAS();

            Alt.ALT_EMP_CODIGO = Tab.CLB_EMP_CODIGO;
            Alt.ALT_CLB_CODIGO = Tab.CLB_CODIGO;
            Alt.ALT_DATA = dtProximoAniversario;
            Alt.ALT_DATA_FINAL = dtProximoAniversario;
            Alt.ALT_MENSAGEM = string.Format(Cfg.CFG_ALERTA_ANIVERSARIO, dtProximoAniversario.ToString("dd/MM/yy"));
            dsAlt.Save(Alt);

            //Ocorrencias
            if (!string.IsNullOrEmpty(Cfg.CFG_OCORRENCIAS_AUTOMATICAS))
            {
              Conversion cnv = new Conversion();
              string[] CodOcorrencias = Cfg.CFG_OCORRENCIAS_AUTOMATICAS.Split(new char[] { ',' });
              for (int i = 0; i < CodOcorrencias.Length; i++)
              {
                HTR_HISTORICO h = new HTR_HISTORICO();
                h.HTR_EMP_CODIGO = (int)cmbEmpresa.SelectedValue;
                h.EMP_NOME = cmbEmpresa.Text;
                h.HTR_CLB_CODIGO = Tab.CLB_CODIGO;
                h.HTR_DATA = DateTime.Now;
                h.HTR_OCR_CODIGO = cnv.ToInt(CodOcorrencias[i]);

                (new dsHTR_HISTORICO(Utilities.Cnn)).Save(h);                
                dsAlt.Remove_FromOCR(h.HTR_CLB_CODIGO, h.HTR_OCR_CODIGO);

                ALT_ALERTAS NewAlt = Utilities.GeraNovoAlerta(h);
                dsAlt.Save(NewAlt);
              }
            }
          }
          Utilities.Cnn.CommitTransaction();
        }
        catch { Utilities.Cnn.RollbackTransaction(); }

        base.OnConfirm();
      }
    }
    #endregion

    #region private void CarregaImagem()
    private void CarregaImagem()
    {
      try
      {
        if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        {

          int max_size = 200;
          int limite = max_size * 100;

          Image img = Bitmap.FromFile(dlgOpen.FileName);          
          int percent = max_size * 100 / (img.Width + img.Height);

          if (percent == 0)
          {
            lib.Visual.Msg.Warning("A imagem é muito grande!");
            return;
          }

          if ((img.Width + img.Height) > max_size)
          { img = lib.Class.ProcessImage.ResizeImage(img, percent); }

          imgFoto.Image = img;
        }
      }
      catch
      { lib.Visual.Msg.Warning("Erro ao carregar a imagem"); }
    }
    #endregion

    #region private void PesquisaCEP()
    private void PesquisaCEP() 
    {
      cmbCLB_LOGRADOURO.Enabled = true;
      cmbCLB_BAIRRO.Enabled = true;
      txtCLB_CIDADE.Enabled = true;
      cmbCLB_ESTADO.Enabled = true;
      cmbCLB_LOGRADOURO.DropDownStyle = ComboBoxStyle.DropDown;
      cmbCLB_BAIRRO.DropDownStyle = ComboBoxStyle.DropDown;

      cmbCLB_LOGRADOURO.Items.Clear();
      cmbCLB_BAIRRO.Items.Clear();
      cmbCLB_LOGRADOURO.Text = "";
      cmbCLB_BAIRRO.Text = "";
      cmbCLB_ESTADO.Text = "";
      txtCLB_CIDADE.Text = "";

      if (!string.IsNullOrEmpty(txtCLB_CEP.Text))
      {
        dsADDRESS dsAddress = new dsADDRESS(Utilities.CnnAddress);
        ADDRESS[] AddressList = dsAddress.GetList_FromZIPCODE(txtCLB_CEP.OriginalText);
        if (AddressList.Length != 0)
        {
          if (AddressList.Length == 1)
          {
            cmbCLB_LOGRADOURO.Items.Add(AddressList[0].NAME);
            cmbCLB_BAIRRO.Items.Add(AddressList[0].NEIGHBORHOOD);
            txtCLB_CIDADE.Text = AddressList[0].CITY;
            cmbCLB_ESTADO.Text = AddressList[0].STATE;

            cmbCLB_LOGRADOURO.SelectedIndex = 0;
            cmbCLB_BAIRRO.SelectedIndex = 0;
            cmbCLB_LOGRADOURO.Enabled = false;
            cmbCLB_BAIRRO.Enabled = false;
            txtCLB_CIDADE.Enabled = false;
            cmbCLB_ESTADO.Enabled = false;
            txtCLB_NUMERO.Select();
          }
          else
          {
            for (int i = 0; i < AddressList.Length; i++)
            {
              if (!string.IsNullOrEmpty(AddressList[i].NAME))
              { cmbCLB_LOGRADOURO.Items.Add(AddressList[i].NAME); }
            }

            if (cmbCLB_LOGRADOURO.Items.Count != 0)
            { cmbCLB_LOGRADOURO.DropDownStyle = ComboBoxStyle.DropDownList; }

            cmbCLB_LOGRADOURO.Select();

            string LastCidade = "";
            string LastEstado = "";
            for (int i = 0; i < AddressList.Length; i++)
            {
              if (!string.IsNullOrEmpty(AddressList[i].NEIGHBORHOOD))
              {
                cmbCLB_BAIRRO.Items.Add(AddressList[i].NEIGHBORHOOD);
                cmbCLB_BAIRRO.DropDownStyle = ComboBoxStyle.DropDownList;
                if (i == 0)
                {
                  txtCLB_CIDADE.Text = AddressList[i].CITY;
                  cmbCLB_ESTADO.Text = AddressList[i].STATE;
                  txtCLB_CIDADE.Enabled = false;
                  cmbCLB_ESTADO.Enabled = false;
                  LastCidade = AddressList[i].CITY;
                  LastEstado = AddressList[i].STATE;
                }
                else if (LastCidade != AddressList[i].CITY || LastEstado != AddressList[i].STATE)
                {
                  txtCLB_CIDADE.Enabled = true;
                  cmbCLB_ESTADO.Enabled = true;
                }
              }
            }
          }
        }
      }
    }
    #endregion

    #region HISTORICOS E ALERTAS
    #region private void CarregaHistoricos()
    private void CarregaHistoricos()
    {
      grdHistorico.Clear();
      if (cmbEmpresa.SelectedIndex != -1 && Tab.CLB_CODIGO != 0)
      {                
        grdHistorico.AddColumn(new FieldColumn("Data", "HTR_DATA", enmFieldType.DateTime));
        grdHistorico.AddColumn(new FieldColumn("Loja", "EMP_NOME", enmFieldType.String, 120));
        grdHistorico.AddColumn(new FieldColumn("Ocorrência", "OCR_DESCRICAO", enmFieldType.String, 120));
        grdHistorico.AddColumn(new FieldColumn("Observação", "HTR_OBSERVACAO", enmFieldType.String, 120));
        grdHistorico.AddItems(new dsHTR_HISTORICO(Utilities.Cnn).GetList_FrmEmpClb(Tab.CLB_CODIGO));
      }
    }
    #endregion

    #region private void CarregaAlertas()
    private void CarregaAlertas()
    {
      grdAlertas.Clear();
      if (cmbEmpresa.SelectedIndex != -1 && Tab.CLB_CODIGO != 0)
      {
        grdAlertas.AddColumn(new FieldColumn("1ª Data", "ALT_DATA", enmFieldType.Date));
        grdAlertas.AddColumn(new FieldColumn("Data Final", "ALT_DATA_FINAL", enmFieldType.Date));
        grdAlertas.AddColumn(new FieldColumn("Mensagem", "ALT_MENSAGEM", enmFieldType.String, 120));
        grdAlertas.AddColumn(new FieldColumn("Origem", "OCR_DESCRICAO", enmFieldType.String, 120));
        grdAlertas.AddItems(new dsALT_ALERTAS(Utilities.Cnn).GetList_FrmEmpClb(Tab.CLB_CODIGO));
      }
    }
    #endregion

    #region private void AdicionarHistorico()
    private void AdicionarHistorico()
    {
      if (cmbEmpresa.SelectedIndex != -1 && Tab.CLB_CODIGO != 0)
      {
        ItemHistorico f = new ItemHistorico();
        if (f.Exec())
        {
          f.Tab.HTR_EMP_CODIGO = (int)cmbEmpresa.SelectedValue;
          f.Tab.EMP_NOME = cmbEmpresa.Text;
          f.Tab.HTR_CLB_CODIGO = Tab.CLB_CODIGO;

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
      if (cmbEmpresa.SelectedIndex != -1 && Tab.CLB_CODIGO != 0)
      {
        dsALT_ALERTAS dsAlt = new dsALT_ALERTAS(Utilities.Cnn);
        ItemAlerta f = new ItemAlerta();

        if (f.Exec())
        {
          f.Tab.ALT_EMP_CODIGO = (int)cmbEmpresa.SelectedValue;
          f.Tab.ALT_CLB_CODIGO = Tab.CLB_CODIGO;
          dsAlt.Save(f.Tab);
          grdAlertas.AddItem(f.Tab);
        }
      }
    }
    #endregion

    #region private void AlterarHistorico()
    private void AlterarAlerta()
    {
      if (grdAlertas.SelectedRows.Count != 0)
      {
        int idx = grdAlertas.SelectedRows[0].Index;
        if (idx != -1)
        {
          ALT_ALERTAS a = grdAlertas.GetItem<ALT_ALERTAS>(idx);
          ItemAlerta f = new ItemAlerta();
          f.Tab.Assign(a);
          if (f.Exec())
          {
            dsALT_ALERTAS dsAlt = new dsALT_ALERTAS(Utilities.Cnn);
            a.Assign(f.Tab);
            dsAlt.Save(a);
            grdAlertas.AlterItem(idx, a);
          }
        }
      }
    }
    #endregion

    #region private void RemoverAlerta()
    private void RemoverAlerta()
    {
      if (grdAlertas.SelectedRows.Count != 0)
      {
        int idx = grdAlertas.SelectedRows[0].Index;
        if (idx != -1)
        {
          ALT_ALERTAS a = grdAlertas.GetItem<ALT_ALERTAS>(idx);
          if (lib.Visual.Msg.Question("Tem certeza que deseja remover este alerta?"))
          {
            (new dsALT_ALERTAS(Utilities.Cnn)).Remove(a.ALT_CODIGO);
            grdAlertas.Rows.RemoveAt(idx);
          }
        }
      }
    }
    #endregion
    #endregion

    #region Events
    private void Form_Search(object sender, lib.Visual.Components.sknGrid Grid, string TextSearch)
    {
      Grid.Clear();
      //Grid.AddColumn(new FieldColumn("CLB_EMP_CODIGO", "CLB_EMP_CODIGO", enmFieldType.Int));
      Grid.AddColumn(new FieldColumn("Nome", "CLB_NOME", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Fone", "CLB_FONE", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Fone Recado", "CLB_RECADO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Endereço", "CLB_LOGRADOURO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Número", "CLB_NUMERO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Bairro", "CLB_BAIRRO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Cidade", "CLB_CIDADE", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Estado", "CLB_ESTADO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("CEP", "CLB_CEP", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("OBS", "CLB_OBS", enmFieldType.String));
      //Grid.AddColumn(new FieldColumn("CLB_FOTO", "CLB_FOTO", enmFieldType.String));
      //Grid.AddColumn(new FieldColumn("Salário", "CLB_SALARIO", enmFieldType.Decimal));
      Grid.AddItems(ds.Search(TextSearch));
    }
    
    private void pictureBox1_Click(object sender, EventArgs e)
    {
      CarregaImagem();
    }
    
    private void btnPesquisaCEP_Click(object sender, EventArgs e)
    {
      PesquisaCEP();
    }
    
    private void btnAdicionarHistorico_Click(object sender, EventArgs e)
    {
      AdicionarHistorico();
    }

    private void btnEditarHistorico_Click(object sender, EventArgs e)
    {
      AlterarHistorico();
    }

    private void btnRemoverHistorico_Click(object sender, EventArgs e)
    {
      RemoverHistorico();
    }

    private void btnAdicionarAlertas_Click(object sender, EventArgs e)
    {
      AdicionarAlerta();
    }

    private void btnEditarAlerta_Click(object sender, EventArgs e)
    {
      AlterarAlerta();
    }

    private void btnRemoverAlertas_Click(object sender, EventArgs e)
    {
      RemoverAlerta();
    }
    
    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (tbcCadastro.SelectedIndex != 0 && Tab.CLB_CODIGO == 0)
      {
        tbcCadastro.SelectedIndex = 0;
        Msg.Warning("É necessário salvar o cadastro para gerar os históricos e alertas");
      }
    }
    
    private void grdHistorico_DoubleClick(object sender, EventArgs e)
    {
      AlterarHistorico();
    }

    private void lstAlertas_DoubleClick(object sender, EventArgs e)
    {
      AlterarAlerta();
    }

    private void grdHistorico_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter) 
      {
        e.Handled = true;
        AlterarHistorico();
      }
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

