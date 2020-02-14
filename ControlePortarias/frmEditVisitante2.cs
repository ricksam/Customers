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

namespace ControlePortarias
{
  public partial class frmEditVisitante2 : lib.Visual.Models.frmDialog
  {
    public frmEditVisitante2()
    {
      InitializeComponent();
      Tab = new AUT_AUTORIZADOS();
    }

    public AUT_AUTORIZADOS Tab { get; set; }

    public void Carregar()
    {
      txtNome.Text = Tab.AUT_NOME;
      //if (!string.IsNullOrEmpty(Tab.AUT_FOTO))
      //{ imgFoto.Image = lib.Class.ProcessImage.StringToImage(Tab.VST_FOTO); }
      cmbTitulo.Text = Tab.AUT_TITULO;
      txtEmail.Text = Tab.AUT_EMAIL;
      txtDocumento.Text = Tab.AUT_DOCUMENTO;
      txtTelefone.Text = Tab.AUT_TELEFONE;
      txtVeiculo.Text = Tab.AUT_VEICULO;
      txtPlaca.Text = Tab.AUT_PLACA;
      //txtObs.Text = Tab.AUT_OBS;

      if (Tab.AUT_DATADE != DateTime.MinValue)
      { txtAutDe.Text = Tab.AUT_DATADE.ToString("dd/MM/yyyy HH:mm"); }

      if (Tab.AUT_DATAATE != DateTime.MinValue)
      { txtAutAte.Text = Tab.AUT_DATAATE.ToString("dd/MM/yyyy HH:mm"); }

      cbPreAutorizado.Checked = Tab.AUT_PRE_AUTORIZADO;

      cmbTitulo.Items.Clear();
      cmbTitulo.Items.AddRange((new dsVST_VISITANTES(Utilities.Cnn)).GetList_Titulo());
    }

    public bool FaltaPreencher()
    {
      LockedField[] lf = (new dsAUT_AUTORIZADOS(Utilities.Cnn)).GetLockedFields(Tab);
      if (lf.Length != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "\n"; }
        Msg.Warning("Verifique os campos abaixo:\n" + xMsg);
      }
      return lf.Length != 0;
    }

    protected override void OnConfirm()
    {
      Conversion cnv = new Conversion();
      Tab.AUT_NOME = txtNome.Text;
      //if (imgFoto.Image != null)
      //{ Tab.AUT_FOTO = lib.Class.ProcessImage.ImageToString(lib.Class.ProcessImage.ResizeImage(imgFoto.Image, 180, 240)); }
      Tab.AUT_TITULO = cmbTitulo.Text;
      Tab.AUT_EMAIL = txtEmail.Text;
      Tab.AUT_DOCUMENTO = txtDocumento.Text;
      Tab.AUT_TELEFONE = txtTelefone.Text;
      Tab.AUT_VEICULO = txtVeiculo.Text;
      Tab.AUT_PLACA = txtPlaca.Text;
      //Tab.AUT_OBS = txtObs.Text;
      Tab.AUT_DATADE = cnv.ToDateTime( txtAutDe.Text);
      Tab.AUT_DATAATE = cnv.ToDateTime( txtAutAte.Text);
      Tab.AUT_PRE_AUTORIZADO = cbPreAutorizado.Checked;
      if (!FaltaPreencher())
      { base.OnConfirm(); }
    }

    private void cmbTitulo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsLetter(e.KeyChar))
      { e.KeyChar = char.ToUpper(e.KeyChar); }
    }

    private void adicionarImagemToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        { imgFoto.Image = Image.FromFile(dlgOpen.FileName); }
      }
      catch { Msg.Warning("Erro ao abrir o arquivo de imagem"); }
    }

    private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsNumber(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ((char)0x8))
      { e.Handled = true; }
    }

    private void txtDocumento_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter) 
      {
        dsVST_VISITANTES dsVst = new dsVST_VISITANTES(Utilities.Cnn);
        VST_VISITANTES Vst = dsVst.Get_FromDocumento(txtDocumento.Text);
        txtNome.Text = Vst.VST_NOME;
        cmbTitulo.Text = Vst.VST_TITULO;
        txtEmail.Text = Vst.VST_EMAIL;
        txtTelefone.Text = Vst.VST_TELEFONE;
        txtVeiculo.Text = Vst.VST_VEICULO;
        txtPlaca.Text = Vst.VST_PLACA;
        //txtObs.Text = Vst.VST_OBS;
      }
    }

    private void frmEditVisitante_Load(object sender, EventArgs e)
    {

    }
  }
}
