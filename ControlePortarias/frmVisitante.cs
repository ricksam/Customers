using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Class;
using lib.Visual;
using lib.Database.Drivers;
using lib.Database.Query;

namespace ControlePortarias
{
  public partial class frmVisitante : lib.Visual.Models.frmBase
  {
    public frmVisitante()
    {
      InitializeComponent();
      dsMrd = new dsMRD_MORADOR(Utilities.Cnn);
      dsVst = new dsVST_VISITANTES(Utilities.Cnn);
      dsRvt = new dsRVT_REGISTRO_VISITAS(Utilities.Cnn);
    }

    dsMRD_MORADOR dsMrd { get; set; }
    dsVST_VISITANTES dsVst { get; set; }
    dsRVT_REGISTRO_VISITAS dsRvt { get; set; }
    RVT_REGISTRO_VISITAS[] RegistroVisitas { get; set; }

    private void ExibeVisitante(VST_VISITANTES Vst)
    {
      if (Vst.VST_TABELA == "AUT" && Vst.VST_CODIGO != 0)
      {
        dsAUT_AUTORIZADOS dsAut = new dsAUT_AUTORIZADOS(Utilities.Cnn);
        AUT_AUTORIZADOS Aut = dsAut.Get(Vst.VST_CODIGO);
        if (Aut.AUT_PRE_AUTORIZADO)
        {
          MRD_MORADOR mrd = dsMrd.Get(Aut.AUT_MRD_CODIGO);
          txtMorador.Text = mrd.MRD_NOME;
          txtMorador.Tag = mrd;
          ExibeRetorno("Autorizado pelo morador", Color.DarkGreen);
        }
        else
        { ExibeRetorno("", Color.Silver); }
      }

      if (Vst.VST_CODIGO != 0)
      {
        txtDocumento.Text = Vst.VST_DOCUMENTO;
        txtEmail.Text = Vst.VST_EMAIL;
        txtNome.Text = Vst.VST_NOME;
        txtPlaca.Text = Vst.VST_PLACA;
        txtTelefone.Text = Vst.VST_TELEFONE;
        txtVeiculo.Text = Vst.VST_VEICULO;
        cmbTitulo.Text = Vst.VST_TITULO;
      }
    }

    public void CarregarUltimasVisitas()
    {      
      grdVisitas.DataSource = null;
      lib.Visual.Functions.SetPropertiesGrid(grdVisitas);
      grdVisitas.ReadOnly = false;
      RegistroVisitas = dsRvt.GetList_FromUltimas();
      grdVisitas.DataSource = RegistroVisitas;
    }

    private void LimpaVisitante()
    {
      ExibeRetorno("", Color.Silver);
      txtDocumento.Text = "";
      txtEmail.Text = "";
      txtNome.Text = "";
      txtObs.Text = "";
      txtPlaca.Text = "";
      txtTelefone.Text = "";
      txtVeiculo.Text = "";
      cmbTitulo.Text = "";
    }

    private void ExibeRetorno(string msg, Color c)
    {
      lblInfo.Text = msg;
      lblInfo.BackColor = c;
    }

    private bool FaltaPreencher(dsRVT_REGISTRO_VISITAS dsRvt, RVT_REGISTRO_VISITAS Rvt)
    {
      LockedField[] lf = dsRvt.GetLockedFields(Rvt);
      if (lf.Length != 0 || txtMorador.Tag == null)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "\n"; }

        if (txtMorador.Tag == null)
        { xMsg += " - O campo Morador"; }

        Msg.Warning("Verifique os campos abaixo:\n" + xMsg);

        if (lf.Length != 0 && lf[0].Field == "RVT_NOME")
        { txtNome.Select(); }
        else if (lf.Length != 0 && lf[0].Field == "RVT_TITULO")
        { txtDocumento.Select(); }
        else if (txtMorador.Tag == null)
        { txtMorador.Select(); }
      }

      return lf.Length != 0 || txtMorador.Tag == null;
    }

    private void frmVisitante_Load(object sender, EventArgs e)
    {
      ExibeRetorno("", Color.Silver);
      CarregarUltimasVisitas();
    }

    private void frmVisitante_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      {
        e.Handled = true;
        SendKeys.Send("{TAB}");
      }
      else if (e.KeyData == Keys.F3)
      {
        try
        {
          frmCamera fCam = new frmCamera();
          if (fCam.ShowDialog() == System.Windows.Forms.DialogResult.OK)
          {
            frmEditarImagem fEdit = new frmEditarImagem();
            fEdit.Image = fCam.LastImage;
            if (fEdit.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { imgFoto.Image = fEdit.Image; }
          }
        }
        catch
        { Msg.Warning("Erro ao acessar a câmera"); }
      }
    }

    private void cmb_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsLetter(e.KeyChar))
      { e.KeyChar = char.ToUpper(e.KeyChar); }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      lib.Visual.Forms.FormQuery q = new lib.Visual.Forms.FormQuery();
      q.OnSearch += new lib.Visual.Forms.FormSearch.OnSearch_Handle(Morador_Search);
      if (q.Exec())
      {
        if (q.Grid.SelectedRows.Count != 0)
        {
          MRD_MORADOR mrd = q.Grid.GetItem<MRD_MORADOR>(q.Grid.SelectedRows[0].Index);
          txtMorador.Text = mrd.MRD_NOME;
          txtMorador.Tag = mrd;
        }
      }
    }

    private void Morador_Search(object sender, lib.Visual.Components.sknGrid Grid, string TextSearch)
    {
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Nome", "MRD_NOME", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Email", "MRD_EMAIL", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Celular", "MRD_CELULAR", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("EPC", "MRD_EPC", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Veiculo", "MRD_VEICULO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Placa", "MRD_PLACA", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Obs", "MRD_OBS", enmFieldType.String));
      Grid.AddItems(dsMrd.Search(TextSearch));
    }

    private void Visitante_Search(object sender, lib.Visual.Components.sknGrid Grid, string TextSearch)
    {
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Nome", "VST_NOME", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Email", "VST_EMAIL", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Telefone", "VST_TELEFONE", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Veiculo", "VST_VEICULO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Placa", "VST_PLACA", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Documento", "VST_DOCUMENTO", enmFieldType.String));
      Grid.AddItems(dsVst.Search(TextSearch));
    }

    private void btnPesquisa_Click(object sender, EventArgs e)
    {
      lib.Visual.Forms.FormQuery q = new lib.Visual.Forms.FormQuery();
      q.OnSearch += new lib.Visual.Forms.FormSearch.OnSearch_Handle(Visitante_Search);
      if (q.Exec())
      {
        if (q.Grid.SelectedRows.Count != 0)
        {
          VST_VISITANTES vst = q.Grid.GetItem<VST_VISITANTES>(q.Grid.SelectedRows[0].Index);
          ExibeVisitante(vst);
        }
      }
    }

    private void btnSalvar_Click(object sender, EventArgs e)
    {
      try
      {
        ExibeRetorno("", Color.Silver);
        dsRVT_REGISTRO_VISITAS dsRvt = new dsRVT_REGISTRO_VISITAS(Utilities.Cnn);
        RVT_REGISTRO_VISITAS Rvt = new RVT_REGISTRO_VISITAS();
        Rvt.RVT_DOCUMENTO = txtDocumento.Text;
        Rvt.RVT_EMAIL = txtEmail.Text;
        if (string.IsNullOrEmpty(Rvt.RVT_FOTO) && imgFoto.Image != null)
        { Rvt.RVT_FOTO = lib.Class.ProcessImage.ImageToString(lib.Class.ProcessImage.ResizeImage(imgFoto.Image, 360, 240)); }
        Rvt.RVT_NOME = txtNome.Text;
        //Rvt.RVT_OBS = txtObs.Text;
        Rvt.RVT_PLACA = txtPlaca.Text;
        Rvt.RVT_TELEFONE = txtTelefone.Text;
        Rvt.RVT_TITULO = cmbTitulo.Text;
        Rvt.RVT_VEICULO = txtVeiculo.Text;
        Rvt.RVT_DATA = DateTime.Now;
        
        if (txtMorador.Tag != null)
        { 
          Rvt.RVT_CAS_CODIGO = ((MRD_MORADOR)txtMorador.Tag).MRD_CAS_CODIGO; 
          Rvt.RVT_MRD_CODIGO = ((MRD_MORADOR)txtMorador.Tag).MRD_CODIGO;
        }

        if (!FaltaPreencher(dsRvt, Rvt))
        {
          Rvt.RVT_SINCRONIZAR = true;
          dsRvt.Save(Rvt);

          MRD_MORADOR mrd = ((MRD_MORADOR)txtMorador.Tag);
          lib.Class.Mail mail = lib.Class.WebUtils.GetMailDeveloper();

          string titulo = string.Format("{0}({1})", Rvt.RVT_NOME, Rvt.RVT_TITULO);
          string link_autorizar = string.Format("http://www.rcksoftware.com.br/ctp/autorizar/{0}?titulo={1}", Rvt.RVT_HASHMD5,titulo);
          string link_negar = string.Format("http://www.rcksoftware.com.br/ctp/negar/{0}?titulo={1}", Rvt.RVT_HASHMD5, titulo);

          string msg =string.Format(
            @"<h2>Sys Portaria</h2>
            <p>O sistema de portaria está solicitando autorização para a visita do visitante {0} {1}</p>
            <p>Se deseja confirmar a autorização <a href='{2}'>clique aqui</a></p>
            <p>Se deseja negar a autorização <a href='{3}'>clique aqui</a></p>",
            Rvt.RVT_NOME,Rvt.RVT_TITULO,link_autorizar,link_negar);
          mail.SendMail(msg, true, mrd.MRD_EMAIL, "SYS PORTARIA");

          LimpaVisitante();
          CarregarUltimasVisitas();
          ExibeRetorno("Visitante gravado com sucesso!", Color.DarkGreen);
        }
      }
      catch 
      { ExibeRetorno("Erro ao gravar o visitante", Color.DarkRed); }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (RegistroVisitas != null && RegistroVisitas.Length != 0)
      {
        for (int i = 0; i < RegistroVisitas.Length; i++)
        {
          if (string.IsNullOrEmpty(RegistroVisitas[i].RVT_STATUS) && !string.IsNullOrEmpty(RegistroVisitas[i].RVT_HASHMD5))
          {
            string status = Service.GetStatus(RegistroVisitas[i].RVT_HASHMD5);

            if (!string.IsNullOrEmpty(status))
            {
              SetStatus(i, status);
              return;
            }
          }
        }
      }
    }

    private void SetStatus(int index, string status) 
    {
      RegistroVisitas[index].RVT_STATUS = status;
      dsRvt.Save(RegistroVisitas[index]);
      CarregarUltimasVisitas();
    }

    private void btnAutorizar_Click(object sender, EventArgs e)
    {
      if (grdVisitas.SelectedRows.Count != 0)
      { SetStatus(grdVisitas.SelectedRows[0].Index, "AUTORIZADO"); }
    }

    private void btnRejeitar_Click(object sender, EventArgs e)
    {
      if (grdVisitas.SelectedRows.Count != 0)
      { SetStatus(grdVisitas.SelectedRows[0].Index, "NEGADO"); }
    }
  }
}
