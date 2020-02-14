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
  public partial class frmEditMorador : lib.Visual.Models.frmDialog
  {
    public frmEditMorador()
    {
      InitializeComponent();
      Tab = new MRD_MORADOR();
    }

    public MRD_MORADOR Tab { get; set; }

    public void Carregar()
    {
      txtNome.Text = Tab.MRD_NOME;
      if (!string.IsNullOrEmpty(Tab.MRD_FOTO))
      { imgFoto.Image = lib.Class.ProcessImage.StringToImage(Tab.MRD_FOTO); }
      cmbTitulo.Text = Tab.MRD_TITULO;
      txtEmail.Text = Tab.MRD_EMAIL;
      txtCelular.Text = Tab.MRD_CELULAR;
      txtEPC.Text = Tab.MRD_EPC;
      txtVeiculo.Text = Tab.MRD_VEICULO;
      txtPlaca.Text = Tab.MRD_PLACA;
      txtObs.Text = Tab.MRD_OBS;
      cbProprietário.Checked = Tab.MRD_PROPRIETARIO;

      cmbTitulo.Items.Clear();
      cmbTitulo.Items.AddRange((new dsMRD_MORADOR(Utilities.Cnn)).GetList_Titulo());
    }

    public bool FaltaPreencher()
    {
      LockedField[] lf = (new dsMRD_MORADOR(Utilities.Cnn)).GetLockedFields(Tab);
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
      Tab.MRD_NOME = txtNome.Text;
      if (imgFoto.Image != null)
      { Tab.MRD_FOTO = lib.Class.ProcessImage.ImageToString(lib.Class.ProcessImage.ResizeImage(imgFoto.Image, 180, 240)); }
      Tab.MRD_TITULO = cmbTitulo.Text;
      Tab.MRD_EMAIL = txtEmail.Text;
      Tab.MRD_CELULAR = txtCelular.Text;
      Tab.MRD_EPC = txtEPC.Text;
      Tab.MRD_VEICULO = txtVeiculo.Text;
      Tab.MRD_PLACA = txtPlaca.Text;
      Tab.MRD_OBS = txtObs.Text;
      Tab.MRD_PROPRIETARIO = cbProprietário.Checked;
      if (!FaltaPreencher())
      { base.OnConfirm(); }
    }

    /*private void cmbTitulo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsLetter(e.KeyChar))
      { e.KeyChar = char.ToUpper(e.KeyChar); }
    }*/

    private void adicionarImagemToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        { imgFoto.Image = Image.FromFile(dlgOpen.FileName); }
      }
      catch { Msg.Warning("Erro ao abrir o arquivo de imagem"); }
    }

    private void acessarAWebCamToolStripMenuItem_Click(object sender, EventArgs e)
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
}
