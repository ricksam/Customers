using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using lib.Entity;

namespace SysZoo
{
  public class SZO_KPA_KEEP_ALIVE : DefaultEntity
  {
    [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
    public int KPA_CODIGO { get; set; }
    public DateTime KPA_TIMESTAMP { get; set; }
    public string KPA_IDENTIFICACAO { get; set; }
    public string KPA_VERSAO { get; set; }
  }

  public class dsSZO_KPA_KEEP_ALIVE : DefaultDataSource<SZO_KPA_KEEP_ALIVE>
  {
    public dsSZO_KPA_KEEP_ALIVE(DbBase DbBase)
      : base(DbBase)
    { }

    public void Save(SZO_KPA_KEEP_ALIVE tab, System.Data.Common.DbTransaction transaction = null)
    {
      tab.KPA_TIMESTAMP = DateTime.UtcNow;
      Insert(tab, transaction);
    }
  }
}
