using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WsPhito.Classes
{
  public static class Utilities
  {
    #region public static lib.Database.Connection GetDbPhitoConnection()
    public static lib.Database.Connection GetDbPhitoConnection()
    {
      System.Configuration.AppSettingsReader reader = new System.Configuration.AppSettingsReader();
      string DbPhitoConnection = (new lib.Class.Conversion()).ToString(reader.GetValue("DbPhitoConnection", (typeof(string))));

      lib.Database.Connection cnn = new lib.Database.Connection();
      cnn.Connect(DbPhitoConnection);
      return cnn;
    }
    #endregion
  }
}