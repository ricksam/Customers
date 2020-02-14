using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware
{
  public partial class Service : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (Request["CODE"] != null)
      { Response.Write(Utilities.GetToken(Request["CODE"].ToString())); }

      if (Request["RemoveCODE"] != null)
      { Response.Write(Utilities.RemoverCode(Request["RemoveCODE"].ToString())); }
    }
  }
}