using System;
using System.Collections.Generic;
using System.Web;
using System.Net;
using System.Collections.Specialized;
using System.IO;

namespace RckSoftware
{
  public class Facebook_oAuth
  {
    public Facebook_oAuth(string callback)
    {
      this.CALLBACK = callback;

      // aaTag API
      //this.ConsumerKey = "c0dc59fc8c3c98702c3105fb55b235f2";
      //this.ConsumerSecret = "a71c2cc0959fab88687b9cfb5819ae21";

      // SocialPost
      this.ConsumerKey = "195991647134540";
      this.ConsumerSecret = "38f1e676f0ffce73e5ea5ebd018221a8";
    }

    //public enum Method { GET, POST };
    public const string AUTHORIZE = "https://graph.facebook.com/oauth/authorize";
    public const string ACCESS_TOKEN = "https://graph.facebook.com/oauth/access_token";
    public string CALLBACK = "";//"http://www.rcksoftware.com.br/system/redirect_facebook.aspx/";

    public string ConsumerKey { get; set; }
    public string ConsumerSecret { get; set; }
    //public string Token { get; set; }


    /*
     * ID do aplicativo:113305382056651
        Chave de API:c0dc59fc8c3c98702c3105fb55b235f2
        Chave secreta do aplicativo:a71c2cc0959fab88687b9cfb5819ae21
     */


    #region public string GetAuthorizationLink()
    /// <summary>
    /// Get the link to Facebook's authorization page for this application.
    /// </summary>
    /// <returns>The url with a valid request token, or a null string.</returns>
    public string GetAuthorizationLink()
    {

      //string scope = " user_photos,email,user_birthday,user_online_presence,offline_access";
      /*string scope =
        @"rsvp_event, manage_pages, publish_actions,sms,publish_checkins,manage_notifications,manage_friendlists,
        create_event,ads_management,xmpp_login,read_stream,read_requests,read_mailbox,read_insights,read_friendlists,
        publish_stream,offline_access,
        user_location, email, user_about_me,user_birthday,user_education_history,user_groups,user_interests,
        user_likes,user_photo_video_tags,user_photos,user_religion_politics,user_work_history,
        friends_about_me,friends_activities,friends_birthday,friends_education_history,friends_groups,
        friends_interests,friends_likes,friends_photo_video_tags,friends_photos,friends_relationships,
        friends_religion_politics,friends_work_history,friends_location,friends_hometown";*/

      System.Configuration.AppSettingsReader reader = new System.Configuration.AppSettingsReader();
      string scope = (new lib.Class.Conversion()).ToString(reader.GetValue("ScopeFacebook", (typeof(string))));

      string link = string.Format("{0}?client_id={1}&redirect_uri={2}&scope={3}",
        new object[] { AUTHORIZE, this.ConsumerKey, CALLBACK, scope.Replace("\r\n", "") }
      );

      return link;
    }
    #endregion

    #region public void GetAccessToken(string authToken)
    /// <summary>
    /// Exchange the Facebook "code" for an access token.
    /// </summary>
    /// <param name="authToken">The oauth_token or "code" is supplied by Facebook's authorization page following the callback.</param>
    public string GetAccessToken(string authToken)
    {
      //this.Token = authToken;
      string accessTokenUrl = string.Format("{0}?client_id={1}&redirect_uri={2}&client_secret={3}&code={4}",
      ACCESS_TOKEN, this.ConsumerKey, CALLBACK, this.ConsumerSecret, authToken);

      string response = lib.Class.WebUtils.GetWebResponse(accessTokenUrl);

      if (response.Length > 0)
      {
        //Store the returned access_token
        NameValueCollection qs = HttpUtility.ParseQueryString(response);

        if (qs["access_token"] != null)
        {
          //this.Token = qs["access_token"];
          return qs["access_token"];
        }
      }
      return "";
    }
    #endregion

    // As funções abaixo poderão ser subistituídas pelas funções da dll lib.Class
    

    
  }
}