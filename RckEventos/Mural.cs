using System;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RckEventos
{
  public partial class Mural : lib.Visual.Models.frmBase
  {
    protected Mural()
    {
      InitializeComponent();
    }

    public Mural(string DirFotos)
      : this()
    {
      this.DirFotos = DirFotos;
    }

    public int CurrentIndex = 0;
    public Image CurrentImage = null;
    int NivelEscuro = 0;
    double Amplicacao = 0;
    public string DirFotos { get; set; }
    public string[] Imagens = new string[] { };

    #region private void Carregar()
    private void Carregar()
    {
      try
      { Imagens = System.IO.Directory.GetFiles(DirFotos, "*.jpg"); }
      catch 
      { Imagens = new string[] { }; }

      tmrFoto.Enabled = true;
    }
    #endregion

    #region private void MarcaFotoFacebook()
    private void MarcaFotoFacebook(string[] ListaAnterior, List<string> NovaLista) 
    {
      string FotoNova = "";

      List<string> List=new List<string>();
      List.AddRange(ListaAnterior);

      for (int i = 0; i < NovaLista.Count; i++)
      {
        if (List.IndexOf(NovaLista[i]) == -1)
        {
          FotoNova = NovaLista[i];
          break;
        }
      }

      if (!string.IsNullOrEmpty(FotoNova))
      {
        // Utilities.Fotos.Add(FotoNova);
      }
    }
    #endregion

    #region Events
    protected override void OnKeyDown(KeyEventArgs e)
    {
      if (e.KeyData == Keys.Escape)
      { this.Close(); }
      base.OnKeyDown(e);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      tmrFoto.Enabled = false;
      try
      {
        #region Captura Imagens
        string[] files = System.IO.Directory.GetFiles(DirFotos, "*.jpg");

        bool NovaImagem = false;
        if (Imagens.Length != files.Length)
        {
          if (files.Length > Imagens.Length)
          {
            int Len = Imagens.Length + 1;
            List<string> NovaLista = new List<string>();
            for (int i = 0; i < Len; i++)
            { NovaLista.Add(files[i]); }

            MarcaFotoFacebook(Imagens, NovaLista);

            Imagens = NovaLista.ToArray();
          }
          else
          { Imagens = files; }

          NovaImagem = true;
          //CurrentIndex = Imagens.Length - 1;
        }
        #endregion

        #region Garante que o CurrentIndex sempre será um index válido
        if (CurrentIndex == -1)
        { CurrentIndex = 0; }
        else if (CurrentIndex >= Imagens.Length)
        { CurrentIndex = Imagens.Length - 1; }
        #endregion

        if (CurrentImage != null)
        {
          for (int i = 0; i < 600; i++)
          {
            Amplicacao += 0.0003;
            imgFoto.Invalidate();
            Application.DoEvents();
          }
        }

        if (Imagens.Length != 0)
        {
          // escurece
          if (CurrentImage != null)
          {
            for (int i = 0; i < 255; i += 6)
            {
              NivelEscuro = i;
              imgFoto.Invalidate();
              Application.DoEvents();
            }
          }

          Image img = Image.FromFile(Imagens[(NovaImagem ? Imagens.Length - 1 : CurrentIndex)]);
          int Percent = (int)((double)this.Height / (double)img.Height * 100);
          CurrentImage = lib.Class.ProcessImage.ResizeImage(img, Percent + 1);
          Amplicacao = 1;
          imgFoto.Invalidate();
          Application.DoEvents();

          // clareia
          if (CurrentImage != null)
          {
            for (int i = 255; i >= 0; i -= 12)
            {
              NivelEscuro = i;
              imgFoto.Invalidate();
              Application.DoEvents();
            }
          }

          if (!NovaImagem)
          {
            CurrentIndex++;
            if (CurrentIndex == Imagens.Length)
            { CurrentIndex = 0; }
          }
        }
      }
      catch { }
      finally
      {
        tmrFoto.Enabled = true;
      }
    }
    
    private void imgFoto_Paint(object sender, PaintEventArgs e)
    {
      // Draw image.
      if (CurrentImage != null)
      {
        int img_width = (int)(CurrentImage.Width * Amplicacao);
        int img_height = (int)(CurrentImage.Height * Amplicacao);
        int dif_width = (img_width - imgFoto.Width) / 2;
        int dif_height = (img_height - imgFoto.Height) / 2;

        Rectangle imageRect = new Rectangle(-dif_width, -dif_height, img_width, img_height);
        // Place it on the window.
        e.Graphics.DrawImage(CurrentImage, imageRect);
        // Create gradient brush from black to window's back color.        
        LinearGradientBrush brush = new
          LinearGradientBrush(new
          Rectangle(0, 0, imgFoto.Width, imgFoto.Height),
          Color.FromArgb(NivelEscuro, 0, 0, 0),
          Color.FromArgb(NivelEscuro, 0, 0, 0),
          0, false);
        // And paint it over image...
        e.Graphics.FillRectangle(brush, imageRect);
        // ...voila!
      }
    }

    private void imgFoto_DoubleClick(object sender, EventArgs e)
    {
      if (this.WindowState == FormWindowState.Maximized)
      {
        this.WindowState = FormWindowState.Normal;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
      }
      else 
      {
        this.WindowState = FormWindowState.Maximized;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      }
    }
    #endregion

    private void Mural_Load(object sender, EventArgs e)
    {
      Carregar();
    }
  }
}
