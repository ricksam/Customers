using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialPost_Types
{
  public abstract class Post_Args
  {
    public abstract string GetArgs();
  }

  public class TwitterPost_Args : Post_Args
  {
    public string Status { get; set; }
    public string Lat { get; set; }
    public string Long { get; set; }
    public override string GetArgs()
    {
      if (string.IsNullOrEmpty(Lat) && string.IsNullOrEmpty(Long))
      { return string.Format("status={0}", Status); }
      else
      { return string.Format("status={0}%26lat={1}%26long={2}", Status, Lat, Long); }
    }
  }

  public class FacebookPost_Args : Post_Args
  {
    public string Message { get; set; }
    public string Link { get; set; }
    public string Description { get; set; }
    public string Picture { get; set; }
    public string LikeID { get; set; }
    public bool PostImageOnFbUser { get; set; }
    public bool PostImageOnFbOwner { get; set; }
    public string ImageCaption { get; set; }
    public string ImageUid { get; set; }
    public string ImageAid { get; set; }
    public override string GetArgs()
    {
      if (string.IsNullOrEmpty(Link))
      { return string.Format("message={0}", Message); }
      else
      { return string.Format("message={0}%26link={1}%26description={2}%26picture={3}", Message, Link, Description, Picture); }
    }

  }

  public class FoursquarePost_Args : Post_Args
  {
    public string Shout { get; set; }
    public string Private { get; set; }
    public string Vid { get; set; }
    public override string GetArgs()
    {
      if (string.IsNullOrEmpty(Vid))
      { return string.Format("shout={0}", Shout); }
      else
      { return string.Format("shout={0}%26private={1}%26vid={2}", Shout, Private, Vid); }
    }
  }

  public class OrkutPost_Args : Post_Args
  {
    public string Body { get; set; }
    public override string GetArgs() { return string.Format("body={0}", Body); }
  }
}
