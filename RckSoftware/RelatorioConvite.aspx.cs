using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware
{
  public partial class RelatorioConvite : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      ConviteCadastrado[] arr = Utilities.RetornaConvitesCadastrados();
      grdConvites.DataSource = arr;
      grdConvites.DataBind();
    }
  }
}