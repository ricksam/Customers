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
  public partial class LoginFB : Form
  {
    public LoginFB()
    {
      InitializeComponent();
    }

    public string Token { get; set; }

    private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
      if (e.Url.AbsoluteUri.IndexOf("token") != -1) 
      {
        if (webBrowser1.DocumentText.StartsWith("TOKEN="))
        { 
          Token = webBrowser1.DocumentText.Remove(0, 6);
          this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
      }
    }

    private void LoginFB_Load(object sender, EventArgs e)
    {
      string link_Token = "http://www.rcksoftware.com.br/SocialPost/Token.aspx";

      string callback = link_Token;// "http://www.rcksoftware.com.br";
      string link_LogOut = string.Format(string.Format("http://www.rcksoftware.com.br/SocialPost/system/logout.aspx?token={0}&callback={1}", Token, callback));

      //lib.Class.WebUtils.GetWebResponse(link_LogOut);
      webBrowser1.Navigate(link_LogOut);
      //webBrowser1.Navigate(link_Token);
    }
  }
}
