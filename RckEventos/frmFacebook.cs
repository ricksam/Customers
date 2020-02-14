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
  public partial class frmFacebook : Form
  {
    public frmFacebook()
    {
      InitializeComponent();
    }

    public string Token = "";

    private void frmCadastro_Load(object sender, EventArgs e)
    {
      wbSite.Navigate("https://socialpost01.azurewebsites.net/system/GetToken.aspx?type=facebook&callback=http://socialpost01.azurewebsites.net/TestePage.aspx");
      wbSite.Focus();
    }

    private string GetKey(string search, string pagina)
    {
      string pagefile = Application.StartupPath + @"\Page.html";
      if (System.IO.File.Exists(pagefile))
      { System.IO.File.Delete(pagefile); }

      lib.Class.TextFile tf = new lib.Class.TextFile();
      tf.Open(lib.Class.enmOpenMode.Writing, pagefile);
      tf.Write(pagina);
      tf.Close();

      if (pagina.IndexOf(search) != -1)
      {
        pagina = pagina.Remove(0, pagina.IndexOf(search) + search.Length);
        if (pagina.IndexOf("\"") != -1)
        {
          return pagina.Substring(0, pagina.IndexOf("\""));
        }
      }

      return "";
    }

    private void Pausa(int Milisecounds)
    {
      Application.DoEvents();
      System.Threading.Thread.Sleep(Milisecounds);
    }

    private bool EncerrarFacebook()
    {
      wbSite.Navigate("http://facebook.com");

      Pausa(500);

      while (wbSite.Url.AbsoluteUri.IndexOf("facebook.com") == -1)
      { Pausa(200); }

      Pausa(500);

      string page = wbSite.DocumentText;

      string key1 = GetKey("<INPUT name=\"fb_dtsg\" type=\"hidden\" value=\"", page);
      string key2 = GetKey("<INPUT name=\"h\" type=\"hidden\" value=\"", page);
      if (!string.IsNullOrEmpty(key1) && !string.IsNullOrEmpty(key1))
      {
        string linklogout = string.Format("https://www.facebook.com/logout.php?fb_dtsg={0}&ref=mb&h={1}", key1, key2);
        wbSite.Navigate(linklogout);

        Pausa(500);
        while (wbSite.DocumentText.IndexOf("name=\"xhpc_message\" title=\"No que você está pensando?\"") != -1)
        { Pausa(200); }
        Pausa(500);
        return true;
      }
      return false;
    }

    private string FormataToken(string s)
    {
      string r = "";
      for (int i = 0; i < s.Length; i++)
      {
        if (char.IsLetter(s[i]) || char.IsNumber(s[i]))
        { r += s[i].ToString(); }
      }
      return r;
    }

    private void wbSite_Navigated(object sender, WebBrowserNavigatedEventArgs e)
    {
      try
      {
        if (!string.IsNullOrEmpty(wbSite.Url.AbsoluteUri) && wbSite.Url.AbsoluteUri.IndexOf("token=") != -1)
        {
          Token = FormataToken(wbSite.Url.AbsoluteUri.Remove(0, wbSite.Url.AbsoluteUri.IndexOf("token=") + 6));

          this.BeginInvoke((Action)delegate()
          {
            try
            {
              this.WindowState = FormWindowState.Minimized;
              if (!EncerrarFacebook())
              { EncerrarFacebook(); }
              this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch { }
          });
        }
      }
      catch { }
    }
  }
}

