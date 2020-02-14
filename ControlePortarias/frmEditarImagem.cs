using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlePortarias
{
  public partial class frmEditarImagem : lib.Visual.Models.frmBase
  {
    public frmEditarImagem()
    {
      InitializeComponent();
    }
    
    int PosX = 0;
    int PosY = 0;
    public Image Image { get; set; }

    private void ProcessaImagem() 
    {
      Image Clone = (Image)Image.Clone();
      Clone = lib.Class.ProcessImage.ResizeImage(Clone, tbImagem.Value * 100 / Image.Width);
      Graphics g = Graphics.FromImage(Clone);

      int rX = PosX - this.Left - 5 - (tbSelecao.Value / 2);
      int rY = PosY - this.Top - 40 - ((int)(tbSelecao.Value * 1.2D) / 2);
      g.DrawRectangle(Pens.Red, rX, rY, tbSelecao.Value, (int)(tbSelecao.Value * 1.2D));
      imgFoto.Image = Clone;
    }
    
    protected override void OnKeyDown(KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      {
        Image Clone = (Image)Image.Clone();
        Clone = lib.Class.ProcessImage.ResizeImage(Clone, tbImagem.Value * 100 / Image.Width);

        Image = new Bitmap(tbSelecao.Value, (int)(tbSelecao.Value * 1.2D), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
        Graphics g = Graphics.FromImage(Image);

        int rX = PosX - this.Left - 5 - (tbSelecao.Value / 2);
        int rY = PosY - this.Top - 40 - ((int)(tbSelecao.Value * 1.2D) / 2);

        g.DrawImage(
          Clone,
          new Rectangle(0, 0, imgFoto.Width, imgFoto.Height),
          new Rectangle(rX, rY, imgFoto.Width, imgFoto.Height),
          GraphicsUnit.Pixel);
        this.DialogResult = System.Windows.Forms.DialogResult.OK;
      }
      base.OnKeyDown(e);
    }

    private void frmEditarImagem_Load(object sender, EventArgs e)
    {
      ProcessaImagem();
    }

    private void imgFoto_Click(object sender, EventArgs e)
    {
      PosX = MousePosition.X;
      PosY = MousePosition.Y;
      ProcessaImagem();      
    }

    private void tbImagem_Scroll(object sender, EventArgs e)
    {
      ProcessaImagem();
    }

    private void tbSelecao_Scroll(object sender, EventArgs e)
    {
      ProcessaImagem();
    }
  }
}
