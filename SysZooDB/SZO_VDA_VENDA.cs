using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lib.Entity;

namespace SysZoo
{
  public class SZO_VDA_VENDA : DefaultEntity
  {
    [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
    public int VDA_CODIGO { get; set; }
    public DateTime VDA_TIMESTAMP { get; set; }
    public string VDA_MD5 { get; set; }
    public string VDA_IDENTIFICACAO { get; set; }
    public string VDA_OPR_MD5 { get; set; }
    public DateTime VDA_MOVIMENTO { get; set; }
    public decimal VDA_TOTAL { get; set; }
    public decimal VDA_TOTAL_PAGO { get; set; }
    public decimal VDA_TROCO { get; set; }
    public bool VDA_SINCRONIZADO { get; set; }
  }

  public class dsSZO_VDA_VENDA : DefaultDataSource<SZO_VDA_VENDA>
  {
    public dsSZO_VDA_VENDA(DbBase DbBase)
      : base(DbBase)
    { }

    public SZO_VDA_VENDA Get(int VDA_CODIGO)
    {
      return Get("SELECT * FROM SZO_VDA_VENDA WHERE VDA_CODIGO = " + VDA_CODIGO);
    }

    public SZO_VDA_VENDA Get_FromMD5(string VDA_MD5)
    {
      return Get("SELECT * FROM SZO_VDA_VENDA WHERE VDA_MD5 = " + DbQuoted(VDA_MD5));
    }

    public SZO_VDA_VENDA[] List_NaoSincronizado()
    {
      return List("SELECT * FROM SZO_VDA_VENDA WHERE VDA_SINCRONIZADO = 0 OR VDA_SINCRONIZADO IS NULL");
    }

    public void MarcaSincronizado(int VDA_CODIGO)
    { DbBase.DbExecute("UPDATE SZO_VDA_VENDA SET VDA_SINCRONIZADO = 1 WHERE VDA_CODIGO = " + VDA_CODIGO); }

    public void Save(SZO_VDA_VENDA tab, System.Data.Common.DbTransaction transaction = null)
    {
      if (tab.VDA_CODIGO == 0)
      {
        tab.VDA_TIMESTAMP = DateTime.UtcNow;
        if (string.IsNullOrEmpty(tab.VDA_MD5))
        { tab.VDA_MD5 = lib.Class.EncryptionDeprecated.GetMD5(Guid.NewGuid().ToString()); }

        Insert(tab, transaction); 
      }
      else
      { Update(tab, new SZO_VDA_VENDA() { VDA_CODIGO = tab.VDA_CODIGO }, transaction); }
    }

    public void RemoveSincronizados()
    { DbBase.DbExecute("DELETE FROM SZO_VDA_VENDA WHERE VDA_SINCRONIZADO = 1"); }
  }
}
