using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Visual;
using lib.Class;
using lib.Database.Drivers;
using lib.Database.Query;

namespace ControlePortarias
{
  public partial class frmMorador : lib.Visual.Models.frmBaseCadastro
  {
    public frmMorador()
    {
      InitializeComponent();
      ds = new dsMRD_MORADOR(Utilities.Cnn);
    }

    MRD_MORADOR Tab { get; set; }
    dsMRD_MORADOR ds { get; set; }

    private void Carregar()
    {
      cmbCasa.Items.Clear();
      cmbCasa.Items.AddRange((new dsCAS_CASA(Utilities.Cnn)).GetList());

      cmbTitulo.Items.Clear();
      cmbTitulo.Items.AddRange(ds.GetList_Titulo());

      for (int i = 0; i < cmbCasa.Items.Count; i++)
      {
        if (((CAS_CASA)cmbCasa.Items[i]).CAS_CODIGO == Tab.MRD_CAS_CODIGO)
        { cmbCasa.SelectedIndex = i; }
      }

      if (!string.IsNullOrEmpty(Tab.MRD_FOTO))
      { imgFoto.Image = lib.Class.ProcessImage.StringToImage(Tab.MRD_FOTO); }
      else
      { imgFoto.Image = null; }
      cmbTitulo.Text = Tab.MRD_TITULO;
      txtNome.Text = Tab.MRD_NOME;
      txtEmail.Text = Tab.MRD_EMAIL;
      txtCelular.Text = Tab.MRD_CELULAR;
      txtEPC.Text = Tab.MRD_EPC;
      txtVeiculo.Text = Tab.MRD_VEICULO;
      txtPlaca.Text = Tab.MRD_PLACA;
      txtObs.Text = Tab.MRD_OBS;
      txtNome.Select();
    }

    protected override void OnNewRecord()
    {
      Tab = new MRD_MORADOR();
      Carregar();
      base.OnNewRecord();
      cmbCasa.Select();
    }

    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      Tab = Grid.GetItem<MRD_MORADOR>();
      Carregar();
      base.OnAlterRecord(Grid);
    }

    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover o registro {0}", Tab.MRD_CODIGO)))
      { ds.Remove(Tab.MRD_CODIGO); }
      base.OnRemoveRecord();
    }

    private bool FaltaPreencher()
    {
      LockedField[] lf = ds.GetLockedFields(Tab);
      if (lf.Length != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "\n"; }
        Msg.Warning("Verifique os campos abaixo:\n" + xMsg);

        if (lf[0].Field == "MRD_CAS_CODIGO")
        { cmbCasa.Select(); }
        else if (lf[0].Field == "MRD_NOME")
        { txtNome.Select(); }
        else if (lf[0].Field == "MRD_EMAIL")
        { txtEmail.Select(); }
        else if (lf[0].Field == "MRD_CELULAR")
        { txtCelular.Select(); }
        else if (lf[0].Field == "MRD_EPC")
        { txtEPC.Select(); }
        else if (lf[0].Field == "MRD_VEICULO")
        { txtVeiculo.Select(); }
        else if (lf[0].Field == "MRD_PLACA")
        { txtPlaca.Select(); }
        else if (lf[0].Field == "MRD_OBS")
        { txtObs.Select(); }
      }

      return lf.Length != 0;
    }

    protected override void OnConfirm()
    {
      Tab.MRD_CAS_CODIGO = cmbCasa.SelectedItem == null ? 0 : ((CAS_CASA)cmbCasa.SelectedItem).CAS_CODIGO;
      if (imgFoto.Image != null)
      { Tab.MRD_FOTO = lib.Class.ProcessImage.ImageToString(lib.Class.ProcessImage.ResizeImage(imgFoto.Image, 180, 240)); }
      Tab.MRD_TITULO = cmbTitulo.Text;
      Tab.MRD_NOME = txtNome.Text;
      Tab.MRD_EMAIL = txtEmail.Text;
      Tab.MRD_CELULAR = txtCelular.Text;
      Tab.MRD_EPC = txtEPC.Text;
      Tab.MRD_VEICULO = txtVeiculo.Text;
      Tab.MRD_PLACA = txtPlaca.Text;
      Tab.MRD_OBS = txtObs.Text;
      if (!FaltaPreencher())
      {
        Tab.MRD_SINCRONIZAR = true;
        ds.Save(Tab);
        base.OnConfirm();
      }
    }

    private void Form_Search(object sender, lib.Visual.Components.sknGrid Grid, string TextSearch)
    {
      Grid.Clear();
      //Grid.AddColumn(new FieldColumn("MRD_CAS_CODIGO", "MRD_CAS_CODIGO", enmFieldType.Int));
      //Grid.AddColumn(new FieldColumn("MRD_FOTO", "MRD_FOTO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Nome", "MRD_NOME", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Email", "MRD_EMAIL", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Celular", "MRD_CELULAR", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("EPC", "MRD_EPC", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Veiculo", "MRD_VEICULO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Placa", "MRD_PLACA", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Obs", "MRD_OBS", enmFieldType.String));
      Grid.AddItems(ds.Search(TextSearch));
    }

    private void frmMorador_Load(object sender, EventArgs e)
    {
      
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
