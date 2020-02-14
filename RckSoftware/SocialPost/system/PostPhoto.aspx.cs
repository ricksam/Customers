using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware.system
{
  public partial class PostPhoto : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      try
      {
        if (Request.Form.Count != 0)
        {
          string[] lsImg = Request.Form.GetValues("image");
          string[] lsTk = Request.Form.GetValues("token");

          string Caption = "";
          if (Request.Form["caption"] != null)
          { Caption = Request.Form["caption"].ToString(); }

          string uid = "";
          if (Request.Form["uid"] != null)
          { uid = Request.Form["uid"].ToString(); }

          string aid = "";
          if (Request.Form["aid"] != null)
          { aid = Request.Form["aid"].ToString(); }

          System.Text.StringBuilder sb = new System.Text.StringBuilder();
          for (int i = 0; i < lsImg.Length; i++)
          { sb.Append(lsImg[i].Replace(" ", "+")); }

          System.Drawing.Image img = lib.Class.ProcessImage.StringToImage(sb.ToString());
          if (img != null)
          {
            for (int i = 0; i < lsTk.Length; i++)
            {
              try
              { PostFacebook(img, lsTk[i], Caption, uid, aid); }
              catch
              { continue; }
            }
            Response.Write("successfully");
          }
          else
          { Response.Write("image is null"); }
        }
      }
      catch (Exception ex)
      {
        Response.Write(ex.Message);
        if (ex.InnerException != null)
        { Response.Write(ex.InnerException.Message); }
      }
    }

    //string SocialPost_GetInfo = "http://app.aatag.com/SocialPost/system/GetInfo.aspx";

    #region public string LinkSocialPost_GetInfo(string token)
    public string LinkSocialPost_GetInfo(string token)
    {
      return string.Format("https://graph.facebook.com/me?access_token={0}", token);
    }
    #endregion

    #region private void PostFacebook(System.Drawing.Image Image, string access_token,string Caption)
    private void PostFacebook(System.Drawing.Image Image, string access_token, string Caption, string uid, string aid)
    {
      //http://stackoverflow.com/questions/3654987/upload-photo-to-facebook-from-silverlight
      //http://facebooksdk.codeplex.com/
      //string access_token = "AAABnDPcMcssBAAik9HMitu5zZCesjrOIKlDZBmpuZB28TGn1qYaw24bAItJAokhuFLrKCt8ZCmas7tRT5D3nZAhyra9IA6ZA5IZC1peT7IxjgZDZD";

      byte[] photo = lib.Class.ProcessImage.ImageToByteArray(Image); //System.IO.File.ReadAllBytes(photoPath);

      dynamic parameters = new System.Dynamic.ExpandoObject();
      parameters.access_token = access_token;
      parameters.caption = string.IsNullOrEmpty(Caption) ? "Photo" : Caption;
      parameters.method = "facebook.photos.upload";

      if (!string.IsNullOrEmpty(uid))
      { parameters.uid = uid; }
      else
      {
        string link = LinkSocialPost_GetInfo(access_token);
        string json_user_info = lib.Class.WebUtils.GetWebResponse(link);
        InfoIdFacebook infoFb = (new JSON()).Deserialize<InfoIdFacebook>(json_user_info);
        parameters.uid = infoFb.id;
      }

      if (!string.IsNullOrEmpty(aid))
      { parameters.aid = aid; }

      var mediaObject = new Facebook.FacebookMediaObject
      {
        FileName = "image.jpg",
        ContentType = "image/jpeg",
      };
      mediaObject.SetValue(photo);
      parameters.source = mediaObject;

      Facebook.FacebookApp app = new Facebook.FacebookApp();
      Facebook.FacebookAsyncCallback del_async = new Facebook.FacebookAsyncCallback(Method_FacebookAsyncCallback);
      app.ApiAsync(del_async, null, "image.jpg", parameters, Facebook.HttpMethod.Post);

      for (int i = 0; i < 10; i++)
      {
        if (!string.IsNullOrEmpty(response))
        { break; }
        System.Threading.Thread.Sleep(1000);
      }

      Response.Write(response);
    }

    string response = "";

    void Method_FacebookAsyncCallback(Facebook.FacebookAsyncResult asyncResult)
    {
      if (asyncResult != null)
      {
        if (asyncResult != null && asyncResult.Result != null)
        {
          response = asyncResult.Result.ToString();
        }

        if (asyncResult != null && asyncResult.Error != null)
        {
          response = asyncResult.Error.ToString();
        }

        //Response.Write(asyncResult.ToString());
        //if (asyncResult.Result != null)
        //{ Response.Write(asyncResult.Result.ToString()); }
      }
    }
    #endregion
  }
}