using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RckSoftwareMVC
{
  /*
  public class SNConfigList
  {
    public SNConfigList(HttpRequestBase Request)
    {
      list.Add(new SNConfig()
      {
        name = "SamsungS6",
        client_id = "195991647134540",
        client_secret = "38f1e676f0ffce73e5ea5ebd018221a8",
        redirect_uri = string.Format("https://{0}/fb/access_token/", Request.Url.Authority),
        scope = "rsvp_event, manage_pages, publish_actions,sms,publish_checkins,manage_notifications,manage_friendlists,        create_event,ads_management,xmpp_login,read_stream,read_requests,read_mailbox,read_insights,read_friendlists,        publish_stream,offline_access,        user_location, email, user_about_me,user_birthday,user_education_history,user_groups,user_interests,        user_likes,user_photo_video_tags,user_photos,user_religion_politics,user_work_history,        friends_about_me,friends_activities,friends_birthday,friends_education_history,friends_groups,        friends_interests,friends_likes,friends_photo_video_tags,friends_photos,friends_relationships,        friends_religion_politics,friends_work_history,friends_location,friends_hometown",
        callback = ""
      });
    }

    List<SNConfig> list = new List<SNConfig>();
    public SNConfig get(string name)
    {
      for (int i = 0; i < list.Count; i++)
      {
        if (list[i].name == name)
        { return list[i]; }
      }
      return null;
    }
  }

  public class SNConfig
  {
    public string name { get; set; }
    public string client_id { get; set; }
    public string client_secret { get; set; }
    public string redirect_uri { get; set; }
    public string scope { get; set; }
    public string callback { get; set; }
  }
  */
}