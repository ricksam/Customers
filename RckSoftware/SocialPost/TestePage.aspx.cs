using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware
{
  public partial class TestePage : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      string type = "";
      string token = "";
      string secret = "";
      JSON json = new JSON();

      if (Request["type"] != null)
      { type = Request["type"]; }

      if (Request["token"] != null)
      { token = Request["token"]; }

      if (Request["secret"] != null)
      { secret = Request["secret"]; }

      if (!Page.IsPostBack)
      {
        lblLinkTeste.Text = string.Format("{0}SocialPost/system/GetToken.aspx?type=[rede]&callback={0}SocialPost/TestePage.aspx", Utilities.Callback());

        //GetInfo        
        lblGetInfo.Text = string.Format("{0}SocialPost/system/GetInfo.aspx?type={1}&token={2}&secret={3}", Utilities.Callback(), type, token, secret);
        lblGetInfo.Text = string.Format("<a href='{0}'>{0}</a>", lblGetInfo.Text);

        //Post
        string args_json = "";
        if (type == "twitter")
        { args_json = "{Status:\"Olá Mundo!!!\"}"; }
        else if (type == "facebook")
        {
          SocialPost_Types.FacebookPost_Args fa = new SocialPost_Types.FacebookPost_Args();
          fa.Message = "Olá Mundo";
          fa.Picture = "http://www.rcksoftware.com.br/img/logo.png";
          fa.Description = "Teste app";
          fa.Link = "http://www.rcksoftware.com.br/";
          args_json = json.Serialize(fa);
        }
        else if (type == "foursquare")
        { args_json = "{Shout:\"Olá Mundo!!!\"}"; }
        else if (type == "orkut")
        { args_json = "{Body:\"Olá Mundo!!!\"}"; }

        lblPost.Text = string.Format("{0}SocialPost/system/Post.aspx?type={1}&token={2}&secret={3}&json={4}", Utilities.Callback(), type, token, secret, args_json);
        lblPost.Text = string.Format("<a href='{0}'>{0}</a>", lblPost.Text);
      }

      lblToken.Text = token;
      lblSecret.Text = secret;
    }

    protected void btnPostarFoto_Click(object sender, EventArgs e)
    {
      if (fuImagem.HasFile) 
      {
        System.IO.MemoryStream _ms = new System.IO.MemoryStream();
        //lib.Class.ProcessImage.ImageToString(fuImagem.PostedFile.InputStream);

      }
    }

    /*protected void btnTestePostPhoto_Click(object sender, EventArgs e)
    { 
      //http://stackoverflow.com/questions/3654987/upload-photo-to-facebook-from-silverlight
      //http://facebooksdk.codeplex.com/
      string access_token = "AAABnDPcMcssBAAik9HMitu5zZCesjrOIKlDZBmpuZB28TGn1qYaw24bAItJAokhuFLrKCt8ZCmas7tRT5D3nZAhyra9IA6ZA5IZC1peT7IxjgZDZD";
      string photoPath = @"D:\BKP\Arquivos\LOGO aaTag.png";
      byte[] photo = System.IO.File.ReadAllBytes(photoPath);
      Facebook.FacebookApp app = new Facebook.FacebookApp();
      dynamic parameters = new System.Dynamic.ExpandoObject();
      parameters.access_token = access_token;
      parameters.caption = "Test Photo";
      parameters.method = "facebook.photos.upload";
      parameters.uid = "100001322122794";// ConfigurationManager.AppSettings["UserId"];

      var mediaObject = new Facebook.FacebookMediaObject
      {
        FileName = "monkey.jpg",
        ContentType = "image/jpeg",
      };
      mediaObject.SetValue(photo);
      parameters.source = mediaObject;

      Facebook.FacebookAsyncCallback del_async = new Facebook.FacebookAsyncCallback(Method_FacebookAsyncCallback);
      app.ApiAsync(del_async, null, "LOGO aaTag.png", parameters, Facebook.HttpMethod.Post);

      app.ApiAsync((ar, state) =>
      {
        var postId = (string)ar.Result;
      },null, parameters, Facebook.HttpMethod.Post);
    }

    void Method_FacebookAsyncCallback(Facebook.FacebookAsyncResult asyncResult)
    {
    }*/
  }
}