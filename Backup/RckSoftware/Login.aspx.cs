using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware
{
  public partial class Login : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string authentication_key
    {
      get {
        if (Session["authentication_key"] != null)
        { return Session["authentication_key"].ToString(); }
        else { return null; }
      }
      set { Session["authentication_key"] = value; }
    }

    public string GetCode()
    {
      return
        lib.Class.Encryption.GetSHA1(txtLogin.Text) + "_" +
        lib.Class.Encryption.GetSHA1(txtSenha.Text);
    }

    protected void btnAcessar_Click(object sender, EventArgs e)
    {
      authentication_key = GetCode();
      Response.Redirect("AreaUsuario.aspx");
    }
  }
}