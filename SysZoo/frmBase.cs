using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SysZoo
{
  public partial class frmBase : Form
  {
    public frmBase()
    {
      InitializeComponent();
      this.lblWindowTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
      this.TopMost = ShowInTopMost;
    }

    public static bool ShowInTopMost = false;

    private bool KeyEnterTab = false;
    public const int WM_NCLBUTTONDOWN = 0xA1; 
    public const int HT_CAPTION = 0x2; 
    [DllImportAttribute("user32.dll")] public static extern int SendMessage(IntPtr hWnd,  int Msg, int wParam, int lParam); 
    [DllImportAttribute("user32.dll")] public static extern bool ReleaseCapture();
    [DllImportAttribute("Gdi32")]
    public static extern int CreateRoundRectRgn(int X1, int Y1, int X2, int Y2, int X3, int Y3);

    public Color CorBranco = Color.FromArgb(255, 255, 255);
    public Color CorCinza = Color.FromArgb(180, 180, 180);
    public Color CorControle = Color.FromArgb(250, 250, 250);
    public Color CorVermelho = Color.FromArgb(180, 60, 60);
    public Color CorAmarelo = Color.FromArgb(180, 180, 60);
    public Color CorVerde = Color.FromArgb(60, 180, 60);
    public Color CorCiano = Color.FromArgb(0, 180, 180);

    private void frmBase_Paint(object sender, PaintEventArgs e)
    {
      Pen pen = new Pen(System.Drawing.Color.FromArgb(60, 120, 180), 6);
      e.Graphics.DrawRectangle(pen, 3, 3, ClientRectangle.Width - 6, ClientRectangle.Height - 6);

      Pen pen2 = new Pen(System.Drawing.Color.FromArgb(0, 120, 120), 1);
      e.Graphics.DrawRectangle(pen2, 0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1);

      Pen pen3 = new Pen(System.Drawing.Color.FromArgb(120, 120, 180), 1);
      e.Graphics.DrawRectangle(pen3, 1, 1, ClientRectangle.Width - 3, ClientRectangle.Height - 3);
    }

    private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        ReleaseCapture();
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Minimized;
    }

    private void frmBase_Load(object sender, EventArgs e)
    {
      this.Text = this.lblWindowTitle.Text;
      this.btnWindowClose.BackgroundImage = global::SysZoo.Properties.Resources.CLOSE;
      this.btnWindowMinimize.BackgroundImage = global::SysZoo.Properties.Resources.MINIMIZE;

      this.btnWindowClose.Top = 6;
      this.btnWindowMinimize.Top = 6;

      this.btnWindowClose.TabStop = false;
      this.btnWindowMinimize.TabStop = false;
    }

    private void btn_MouseHover(object sender, EventArgs e)
    {
      if (((Button)sender).Image == null)
      {
        ((Button)sender).Image = global::SysZoo.Properties.Resources.BUTTONGLASS;
      }
    }

    private void btn_MouseLeave(object sender, EventArgs e)
    {
      if (((Button)sender).Image != null)
      {
        ((Button)sender).Image.Dispose();
        ((Button)sender).Image = null;
      }
    }

    private void btn_MouseDown(object sender, MouseEventArgs e)
    {
      if (((Button)sender).Image != null)
      {
        ((Button)sender).Image.Dispose();
        ((Button)sender).Image = null;
      }
    }

    private void frmBase_KeyDown(object sender, KeyEventArgs e)
    {
      if ((this.ActiveControl is TextBox || this.ActiveControl is ComboBox) && e.KeyData == Keys.Enter)
      {
        KeyEnterTab = true;
        SendKeys.Send("{TAB}");
      }
      else if (e.KeyData == Keys.Escape)
      { this.Close(); }
      else
      { KeyEnterTab = false; }
    }

    private void frmBase_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (((int)e.KeyChar) == 13 && KeyEnterTab)
      { e.Handled = true; }

      //this.lblWindowTitle.Text = ((int)e.KeyChar).ToString();
    }
  }
}
