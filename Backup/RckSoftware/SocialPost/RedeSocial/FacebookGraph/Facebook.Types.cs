using System;
using System.Collections.Generic;
using System.Web;

namespace RckSoftware
{
  #region public class getInfo
  /// <summary>
  /// Type that can be serialised from JSON to a .net class
  /// http://wiki.developers.facebook.com/index.php/Users.getInfo
  /// </summary>
  [Serializable]
  public class Facebook_UserInfo
  {
    public string id { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string full_name { get { return String.Format("{0} {1}", first_name, last_name); } }
    public string email { get; set; }
    //public string pic_big { get; set; }
    //public string pic_small { get; set; }
    public string picture { get; set; }
    public string profile_url { get; set; }
    public Facebook_Location hometown { get; set; }
    public Facebook_Location location { get; set; }
    //public status status { get; set; }

    public string GetFoto()
    {
      string url = string.Format(
          "https://api.facebook.com/method/fql.query?" +
          "query=select pic_big from user where uid={0}&format=json",
          id);
      Facebook_Picture[] pic = (new JSON()).Deserialize<Facebook_Picture[]>(
        lib.Class.WebUtils.GetWebResponse(url));
      return pic[0].pic_big;
    }
  }
  #endregion

  #region public class Facebook_Picture
  public class Facebook_Picture
  {
    public string pic_big { get; set; }
    public string pic_small { get; set; }
  }
  #endregion

  #region public class location
  /// <summary>
  /// "Hometown" profile fields. Contains three children: city, state, and country. 
  /// </summary>
  [Serializable]
  public class Facebook_Location
  {
    public string name { get; set; }
    public string city { get { return name.Substring(0, name.IndexOf(",")); } }
    //public string state { get; set; }
    public string country
    {
      get
      {
        int pos_i = name.IndexOf(",") + 1;
        return name.Substring(pos_i, name.Length - pos_i);
      }
    }
    //public string zip { get; set; }
  }
  #endregion

  #region public class InfoIdFacebook
  public class InfoIdFacebook
  {
    public string id { get; set; }
  }
  #endregion
}