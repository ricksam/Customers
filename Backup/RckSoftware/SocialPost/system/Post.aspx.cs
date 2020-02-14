using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware.system
{
  public partial class Post : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      //post : type=<rede_social>&token=<token>&secret=<secreto>&json=<json_args>
      if (!Page.IsPostBack)
      { Carregar(); }
    }

    private void Carregar()
    {
      string type = Request["type"].ToString();
      string token = Request["token"].ToString();
      string secret = Request["secret"].ToString();
      string json = Request["json"].ToString();

      JSON j = new JSON();

      string link = "";
      if (type == "twitter")
      {
        /*TwitterPost_Args ta = j.Deserialize<TwitterPost_Args>(json);

        SocialMediaLibrary.TwitterInfo ti = new SocialMediaLibrary.TwitterInfo(token, secret);
        ti.ConsumerKey = "76Saa5x400QgGa7GHZtH5Q";
        ti.ConsumerSecret = "Kl0cHWTxBUTBa5Iq7xgBBRoU885ZBmv3JQb6sRhSmiA";
        ti.CallbackUrl = "http://aatag.com";
        SocialMediaLibrary.TwitterInfo.TwitterInfoStatus status = ti.PostTweet(ta.Status, false);
        return;*/
        //link = string.Format("{0}system/Method.aspx?type=twitter&token={1}&secret={2}&method=POST&command=http://twitter.com/statuses/update.json&args={3}", 
        //Utilities.Callback(), token, secret, ta.GetArgs());
      }
      else if (type == "facebook")
      {
        SocialPost_Types.FacebookPost_Args fa = j.Deserialize<SocialPost_Types.FacebookPost_Args>(json);
        string command = "";

        if (string.IsNullOrEmpty(fa.Link))
        { command = "feed"; }
        else
        { command = "feed"; }


        link = string.Format("{0}SocialPost/system/Method.aspx?type=facebook&token={1}&secret={2}&method=POST&command=https://graph.facebook.com/me/{3}?access_token={1}&args={4}",
          Utilities.Callback(), token, secret, command, fa.GetArgs());
      }
      else if (type == "foursquare")
      {
        /*// docs: https://developer.foursquare.com/docs/checkins/add.html
        FoursquarePost_Args fa = j.Deserialize<FoursquarePost_Args>(json);
        link = string.Format("{0}system/Method.aspx?type=foursquare&token={1}&secret={2}&method=POST&command=https://api.foursquare.com/v2/checkins/add?oauth_token={1}&args={3}",
          Utilities.Callback(), token, secret, fa.GetArgs());*/
      }
      else if (type == "orkut")
      {
        /*OrkutPost_Args oa = j.Deserialize<OrkutPost_Args>(json);
        string cmbOrkut = "[{\"params\":{\"messageType\":\"public_message\",\"groupId\":\"@self\",\"userId\":\"@me\",\"message\":{\"body\":\"" + oa.Body + "\"}},\"id\":\"2-scrp.c\",\"method\":\"messages.create\"}]";
        link = string.Format("{0}system/Method.aspx?type=orkut&token={1}&secret={2}&method=POST&command={3}",
          Utilities.Callback(), token, secret, cmbOrkut);*/
      }

      if (!string.IsNullOrEmpty(link))
      { Response.Write(lib.Class.WebUtils.GetWebResponse(link)); }
    }
  }
}