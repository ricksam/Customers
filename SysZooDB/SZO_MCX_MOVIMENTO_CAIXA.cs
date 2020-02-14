using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lib.Entity;

namespace SysZoo
{
  public class SZO_MCX_MOVIMENTO_CAIXA : DefaultEntity
  {
    [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
    public int MCX_CODIGO { get; set; }
    public DateTime MCX_TIMESTAMP { get; set; }
    public string MCX_MD5 { get; set; }
    public string MCX_IDENTIFICACAO { get; set; }
    public DateTime MCX_DATA { get; set; }
    public DateTime MCX_MOVIMENTO { get; set; }
    public string MCX_TIPO { get; set; }
    public decimal MCX_VALOR { get; set; }
    public bool MCX_SINCRONIZADO { get; set; }
  }

  public class dsSZO_MCX_MOVIMENTO_CAIXA : DefaultDataSource<SZO_MCX_MOVIMENTO_CAIXA>
  {
    public dsSZO_MCX_MOVIMENTO_CAIXA(DbBase DbBase)
      : base(DbBase)
    { }

    public SZO_MCX_MOVIMENTO_CAIXA Get(int MCX_CODIGO)
    {
      return Get("SELECT * FROM SZO_MCX_MOVIMENTO_CAIXA WHERE MCX_CODIGO = " + MCX_CODIGO);
    }

    public SZO_MCX_MOVIMENTO_CAIXA Get_FromMD5(string MCX_MD5)
    {
      return Get("SELECT * FROM SZO_MCX_MOVIMENTO_CAIXA WHERE MCX_MD5 = " + DbQuoted(MCX_MD5));
    }

    public SZO_MCX_MOVIMENTO_CAIXA[] List_NaoSincronizado()
    {
      return List("SELECT * FROM SZO_MCX_MOVIMENTO_CAIXA WHERE MCX_SINCRONIZADO = 0 OR MCX_SINCRONIZADO IS NULL");
    }

    public void MarcaSincronizado(int MCX_CODIGO)
    { DbBase.DbExecute("UPDATE SZO_MCX_MOVIMENTO_CAIXA SET MCX_SINCRONIZADO = 1 WHERE MCX_CODIGO = " + MCX_CODIGO); }

    public void Save(SZO_MCX_MOVIMENTO_CAIXA tab, System.Data.Common.DbTransaction transaction = null)
    {
      if (tab.MCX_CODIGO == 0)
      {
        tab.MCX_TIMESTAMP = DateTime.UtcNow;
        if (string.IsNullOrEmpty(tab.MCX_MD5))
        { tab.MCX_MD5 = lib.Class.EncryptionDeprecated.GetMD5(Guid.NewGuid().ToString()); }

        Insert(tab, transaction);
      }
      else
      { Update(tab, new SZO_MCX_MOVIMENTO_CAIXA() { MCX_CODIGO = tab.MCX_CODIGO }, transaction); }
    }

    public void RemoveSincronizados()
    { DbBase.DbExecute("DELETE FROM SZO_MCX_MOVIMENTO_CAIXA WHERE MCX_SINCRONIZADO = 1"); }
  }
}
