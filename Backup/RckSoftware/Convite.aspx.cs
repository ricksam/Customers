using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware
{
  public partial class Convite : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnConectar_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txtConvite.Text))
      {
        string NomeAtivado = Utilities.GetName(txtConvite.Text);
        if (string.IsNullOrEmpty(NomeAtivado))
        {
          string site = "http://www.rcksoftware.com.br/";
          Response.Redirect(
            string.Format(
              "{0}SocialPost/system/GetToken.aspx?type=facebook&callback={1}ConviteConcluir.aspx&args=CODE={2}",
              site, Utilities.Callback(), txtConvite.Text)
          );
        }
        else
        {
          lblMsg.Text = string.Format(string.Format(
            @"<p class='message warning'>Convite já ativado para o facebook de {0}! <br /> 
            Caso o nome exibido na tela não seja seu então entre em contato com os organizadores do evento passando seu código.</p>", NomeAtivado));
        }
      }
      else
      { lblMsg.Text = string.Format("<p class='message error'>Informe o número do convite</p>"); }
    }
  }
}