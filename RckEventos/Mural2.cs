using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RckEventos
{
  public partial class Mural2 : Form
  {
    public Mural2()
    {
      InitializeComponent();
      this.DirFotos = @"D:\FOTOS";
      Deletar = new List<string>();
    }

    bool BlockTimer = false;
        
    public Mural2(string DirFotos)
      : this()
    {
      this.DirFotos = DirFotos;
      Deletar = new List<string>();
    }

    #region Fields
    //int TimeContato = 0;
    int Index { get; set; }
    string FotoAtual { get; set; }
    string DirFotos { get; set; }
    List<string> Deletar { get; set; }
    Image imgFotoAtual { get; set; }
    string[] arquivos_fotos { get; set; }
    #endregion

    private void ColocaContato(Bitmap imagem) 
    {/*
        Graphics gr = Graphics.FromImage(imagem);
        Font font_small = new Font("Arial Black", 8);
        //Font font_normal = new Font("Arial Black", 16);
        Font font_big = new Font("Arial Black", 24);
        int e_sombra = 2;

        //string texto_servicos = "Serviços: Album Personalizado / Foto Telão / Vídeo Vida / App do Evento ( Android, IOs e Windows Phone )";
        //string texto_contatos = "Contato: (15) 98127-0060 (whatsapp)";
        //string texto_rck = "RCK Eventos";

        //gr.DrawString(texto_servicos, font_small, Brushes.Black, new Rectangle(20 - e_sombra, imagem.Height - 60 - e_sombra, imagem.Width, 20));
        //gr.DrawString(texto_servicos, font_small, Brushes.Black, new Rectangle(20 + e_sombra, imagem.Height - 60 + e_sombra, imagem.Width, 20));
        //gr.DrawString(texto_servicos, font_small, Brushes.Yellow, new Rectangle(20, imagem.Height - 60, imagem.Width, 20));

        //gr.DrawString(texto_contatos, font_normal, Brushes.Black, new Rectangle(20 - e_sombra, imagem.Height - 45 - e_sombra, imagem.Width, 40));
        gr.DrawString(texto_contatos, font_big, Brushes.Black, new Rectangle(20 + e_sombra, imagem.Height - 60 + e_sombra, imagem.Width, 60));
        gr.DrawString(texto_contatos, font_big, Brushes.Yellow, new Rectangle(20, imagem.Height - 60, imagem.Width, 60));

        if (imagem.Height > imagem.Width)
        {
            //gr.DrawString(texto_rck, font_big, Brushes.Black, new Rectangle(imagem.Width - 280 - e_sombra, 60 - e_sombra, 350, 60));
            gr.DrawString(texto_rck, font_big, Brushes.Black, new Rectangle(imagem.Width - 280 + e_sombra, 60 + e_sombra, 350, 60));
            gr.DrawString(texto_rck, font_big, Brushes.Yellow, new Rectangle(imagem.Width - 280, 60, 350, 240));
        }
        else 
        {
            //gr.DrawString(texto_rck, font_big, Brushes.Black, new Rectangle(imagem.Width - 280 - e_sombra, imagem.Height - 60 - e_sombra, 350, 60));
            gr.DrawString(texto_rck, font_big, Brushes.Black, new Rectangle(imagem.Width - 280 + e_sombra, imagem.Height - 60 + e_sombra, 350, 60));
            gr.DrawString(texto_rck, font_big, Brushes.Yellow, new Rectangle(imagem.Width - 280, imagem.Height - 60, 350, 240));
        }*/
    }

    private void ExibeFoto()
    {
        try
        {
            lblInfo.Text = "";
            if (Deletar.Count != 0)
            {
                try
                {
                    if (System.IO.File.Exists(Deletar[0]))
                    {
                        System.IO.File.Delete(Deletar[0]);
                        Deletar.RemoveAt(0);
                    }
                    else { Deletar.RemoveAt(0); }
                }
                catch { }
            }

            tmrFotos.Enabled = false;

                /*
            if (TimeContato == 0)
            {
                TimeContato = 200;
                ExibeImagem(global::RckEventos.Properties.Resources.rckcontato);
                return;
            }
            else
            { TimeContato--; }*/

            if (System.IO.Directory.Exists(DirFotos))
            {
                int qtde_anterior = arquivos_fotos == null ? 0 : arquivos_fotos.Length;
                arquivos_fotos = System.IO.Directory.GetFiles(DirFotos);

                if (arquivos_fotos.Length > 0)
                {
                    if (arquivos_fotos.Length != qtde_anterior)
                    {
                        if (imgFotoAtual != null)
                        {
                            imgFotoAtual.Dispose();
                            imgFotoAtual = null;
                        }

                        imgFotoAtual = lib.Class.ProcessImage.ResizeImage(Bitmap.FromFile(arquivos_fotos[arquivos_fotos.Length - 1]), 1280, 720); //(new Bitmap(fotos[Index]));
                        //ColocaContato((Bitmap)imgFotoAtual);
                        ExibeImagem((Bitmap)imgFotoAtual);
                        return;
                    }

                    if (Index >= arquivos_fotos.Length)
                    { Index = 0; }

                    if (Index < 0)
                    { Index = arquivos_fotos.Length - 1; }

                    lblInfo.Text = string.Format("{0} de {1} {2} Aguardando:{3}",
                      Index, arquivos_fotos.Length, System.IO.Path.GetFileNameWithoutExtension(arquivos_fotos[Index]), Utilities.Fotos.Count);
                    txtCodigo.Text = "";

                    FotoAtual = arquivos_fotos[Index];
                    if (imgFotoAtual != null)
                    {
                        imgFotoAtual.Dispose();
                        imgFotoAtual = null;
                    }
                    imgFotoAtual = lib.Class.ProcessImage.ResizeImage(Bitmap.FromFile(arquivos_fotos[Index]), 1280,720); //(new Bitmap(fotos[Index]));
                    //ColocaContato((Bitmap)imgFotoAtual);
                    ExibeImagem((Bitmap)imgFotoAtual);
                }
            }
        }
        catch (Exception ex) { lblInfo.Text = ex.Message; }
        finally
        { tmrFotos.Enabled = true; }
    }


    private void ExibeImagem(Bitmap bmp)
    {
        if (imgFoto.Image != null)
        {
            imgFoto.Image.Dispose();
            imgFoto.Image = null;
        }

        imgFoto.Image = bmp;
    }

    private void VirarImagem(RotateFlipType r) 
    {
        try
        {
            tmrFotos.Enabled = false;
            
            Graphics gr = Graphics.FromImage(imgFoto.Image);
            Bitmap bmp1 = new Bitmap(FotoAtual);
            imgFotoAtual =new Bitmap(bmp1);
            bmp1.Dispose();
            bmp1 = null;


            //gr.DrawImage(bmp, new Rectangle(0, 0, imgFoto.Image.Width, imgFoto.Image.Height));
            //bmp.Dispose();
            //bmp = null;

            imgFotoAtual.RotateFlip(r);
            imgFotoAtual.Save(FotoAtual, System.Drawing.Imaging.ImageFormat.Jpeg);
            imgFoto.Image = imgFotoAtual;
        }
        catch (Exception ex)
        { lblInfo.Text = ex.Message; }
      finally 
      { tmrFotos.Enabled = true; }
    }
    
    
      protected override void OnKeyDown(KeyEventArgs e)
    {
      /*if (e.KeyData == Keys.Enter)
      {
        frmFacebook f = new frmFacebook();
        f.ShowDialog();
      }*/

      if (e.KeyData == Keys.Escape)
      { this.Close(); }

      if (e.KeyData == Keys.Up || e.KeyData == Keys.Down || e.KeyData == Keys.Left || e.KeyData == Keys.Right)
      {
        //lstFotos.Visible = true;

        if (e.KeyData == Keys.Up || e.KeyData == Keys.Left)
        { Index--; }

        if (e.KeyData == Keys.Down || e.KeyData == Keys.Right)
        { Index++; }

        //TimeContato = 10;
        ExibeFoto();
      }

      if (e.KeyData==Keys.F2)
      {
          //TimeContato = 10;
          VirarImagem(RotateFlipType.Rotate90FlipXY); 
      }

      if (e.KeyData == Keys.Delete)
      {
          //TimeContato = 10;
          try
          {
              if (imgFotoAtual != null)
              {
                  imgFoto.Image.Dispose();
                  imgFoto.Image = null;
                  imgFotoAtual.Dispose();
                  imgFotoAtual = null;
              }
              System.IO.File.Delete(FotoAtual); 
          }
          catch
          { Deletar.Add(FotoAtual); }

          //Index++;
          ExibeFoto();
      }

      //if (e.Shift)
      //{ VirarImagem(RotateFlipType.Rotate270FlipXY); }
      
      base.OnKeyDown(e);
    }

    private void tmrFotos_Tick(object sender, EventArgs e)
    {
      if (BlockTimer)
      { return; }
      //lstFotos.Visible = false;
      Index++;
      ExibeFoto();
    }

    private void Mural2_Load(object sender, EventArgs e)
    {
      ExibeFoto();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      tmrFotos.Enabled = false;
      tmrFotos.Enabled = true;
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      {
        BlockTimer = true;
        frmFacebook f = new frmFacebook();
        f.ShowDialog();
        BlockTimer = false;

      }
    }

    private void imgFoto_DoubleClick(object sender, EventArgs e)
    {
        if (this.FormBorderStyle == System.Windows.Forms.FormBorderStyle.None)
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog; 
        }

        if (this.FormBorderStyle != System.Windows.Forms.FormBorderStyle.None)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; 
        }
    }
    
  }
}
