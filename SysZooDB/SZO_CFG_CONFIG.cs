using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lib.Entity;

namespace SysZoo
{
  public class SZO_CFG_CONFIG : DefaultEntity
  {
    [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
    public int CFG_CODIGO { get; set; }
    public DateTime CFG_MOVIMENTO { get; set; }
    public int CFG_OPR_CODIGO { get; set; }
    public string CFG_IDENTIFICACAO { get; set; }
    public string CFG_PRINTER_PORT { get; set; }
    public int CFG_PRINTER_VELOCITY { get; set; }
    public bool CFG_IMPRIMIR_INDIVIDUAL { get; set; }
    public bool CFG_IMPRIMIR_SEMFORMATACAO { get; set; }
  }

  public class dsSZO_CFG_CONFIG : DefaultDataSource<SZO_CFG_CONFIG>
  {
    public dsSZO_CFG_CONFIG(DbBase DbBase)
      : base(DbBase)
    { }

    public SZO_CFG_CONFIG Get()
    {
      return Get("SELECT * FROM SZO_CFG_CONFIG");
    }

    public SZO_CFG_CONFIG Get(int CFG_CODIGO)
    {
      return Get("SELECT * FROM SZO_CFG_CONFIG WHERE CFG_CODIGO = " + CFG_CODIGO);
    }

    public void EncerrarMovimento() 
    {
      DbBase.DbExecute("UPDATE SZO_CFG_CONFIG SET CFG_MOVIMENTO = NULL, CFG_OPR_CODIGO = NULL");
    }

    public void Save(SZO_CFG_CONFIG tab)
    {
      if (Get().CFG_CODIGO == 0)
      { Insert(tab); }
      else
      { Update(tab, new SZO_CFG_CONFIG() { CFG_CODIGO = tab.CFG_CODIGO }); }
    }
  }
}
