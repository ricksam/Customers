using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lib.Entity;

namespace RckSoftwareMVC
{
  public class SOCIAL_NETWORK : DefaultEntity
  {
    [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
    public int ID { get; set; }
    public string NAME { get; set; }
    public string CLIENT_ID { get; set; }
    public string CLIENT_SECRET { get; set; }
    public string REDIRECT_URI { get; set; }
    public string SCOPE { get; set; }
    public string CALLBACK { get; set; }
  }

  public class dsSOCIAL_NETWORK : DefaultDataSource<SOCIAL_NETWORK>
  {
    public dsSOCIAL_NETWORK(DbBase DbBase)
      : base(DbBase)
    { }

    public SOCIAL_NETWORK Get(int ID)
    {
      return Get("SELECT * FROM SOCIAL_NETWORK WHERE ID = " + ID);
    }

    public SOCIAL_NETWORK Get_FromName(string Name)
    {
      return Get("SELECT * FROM SOCIAL_NETWORK WHERE NAME = " + DbQuoted(Name));
    }

    public void Save(SOCIAL_NETWORK tab, System.Data.Common.DbTransaction transaction = null)
    {
      if (tab.ID == 0)
      { Insert(tab, transaction); }
      else
      { Update(tab, new SOCIAL_NETWORK() { ID = tab.ID }, transaction); }
    }
  }
}
