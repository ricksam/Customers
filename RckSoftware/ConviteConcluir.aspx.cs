using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware
{
  public partial class ConviteConcluir : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      try
      {
        if (Request["CODE"] != null)
        { txtConvite.Text = Request["CODE"].ToString(); }

        string token = "";
        if (Request["token"] != null)
        { token = Request["token"].ToString(); }

        lib.Class.JSON json = new lib.Class.JSON();
        string link = string.Format("http://www.rcksoftware.com.br/SocialPost/system/GetInfo.aspx?type=facebook&token={0}&secret=", token);
        string str_fb_info = lib.Class.WebUtils.GetWebResponse(link);
        Facebook_UserInfo FbInfo = json.Deserialize<Facebook_UserInfo>(str_fb_info);
        imgFoto.ImageUrl = FbInfo.GetFoto();
        txtNome.Text = FbInfo.full_name;
        txtEmail.Text = FbInfo.email;

        Utilities.AddToken(txtConvite.Text, token, txtNome.Text, txtEmail.Text);
        txtToken.Value = token;
        //lblVoltar.Text = string.Format("http://www.rcksoftware.com.br/SocialPost/system/Logout.aspx?type=facebook&token={0}&callback=" + Utilities.Callback(), token);
      }
      catch
      { Response.Redirect("Erro.aspx"); }
    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {
      Response.Redirect(string.Format("http://www.rcksoftware.com.br/SocialPost/system/Logout.aspx?type=facebook&token={0}&callback=" + Utilities.Callback(), txtToken.Value));
    }
  }
}