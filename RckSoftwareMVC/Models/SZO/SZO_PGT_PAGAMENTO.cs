using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lib.Entity;

namespace SysZoo
{
  public class SZO_PGT_PAGAMENTO : DefaultEntity
  {
    [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
    public int PGT_CODIGO { get; set; }
    public DateTime PGT_TIMESTAMP { get; set; }
    public string PGT_MD5 { get; set; }
    public string PGT_IDENTIFICACAO { get; set; }
    public string PGT_VDA_MD5 { get; set; }
    public string PGT_OPR_MD5 { get; set; }
    public string PGT_FPG_MD5 { get; set; }
    public DateTime PGT_MOVIMENTO { get; set; }
    public string PGT_DESCRICAO { get; set; }
    public decimal PGT_VALOR { get; set; }
    public bool PGT_SINCRONIZADO { get; set; }

    public override string ToString()
    {
      return PGT_DESCRICAO.PadRight(10) + PGT_VALOR.ToString("0.00").PadLeft(10);
    }
  }

  public class dsSZO_PGT_PAGAMENTO : DefaultDataSource<SZO_PGT_PAGAMENTO>
  {
    public dsSZO_PGT_PAGAMENTO(DbBase DbBase)
      : base(DbBase)
    { }

    public SZO_PGT_PAGAMENTO Get(int PGT_CODIGO)
    {
      return Get("SELECT * FROM SZO_PGT_PAGAMENTO WHERE PGT_CODIGO = " + PGT_CODIGO);
    }

    public SZO_PGT_PAGAMENTO Get_FromMD5(string PGT_MD5)
    {
      return Get("SELECT * FROM SZO_PGT_PAGAMENTO WHERE PGT_MD5 = " + DbQuoted(PGT_MD5));
    }

    public SZO_PGT_PAGAMENTO[] List_NaoSincronizado()
    {
      return List("SELECT * FROM SZO_PGT_PAGAMENTO WHERE PGT_SINCRONIZADO = 0 OR PGT_SINCRONIZADO IS NULL");
    }

    public void MarcaSincronizado(int PGT_CODIGO)
    { DbBase.DbExecute("UPDATE SZO_PGT_PAGAMENTO SET PGT_SINCRONIZADO = 1 WHERE PGT_CODIGO = " + PGT_CODIGO); }

    public void Save(SZO_PGT_PAGAMENTO tab, System.Data.Common.DbTransaction transaction = null)
    {
      if (tab.PGT_CODIGO == 0)
      {
        tab.PGT_TIMESTAMP = DateTime.UtcNow;
        if (string.IsNullOrEmpty(tab.PGT_MD5))
        { tab.PGT_MD5 = lib.Class.Encryption.getMD5Hash(Guid.NewGuid().ToString()); }

        Insert(tab, transaction); 
      }
      else
      { Update(tab, new SZO_PGT_PAGAMENTO() { PGT_CODIGO = tab.PGT_CODIGO }, transaction); }
    }

    public void RemoveSincronizados()
    { DbBase.DbExecute("DELETE FROM SZO_PGT_PAGAMENTO WHERE PGT_SINCRONIZADO = 1"); }
  }
}
