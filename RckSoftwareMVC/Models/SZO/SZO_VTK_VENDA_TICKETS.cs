using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lib.Entity;

namespace SysZoo
{
  public class SZO_VTK_VENDA_TICKETS : DefaultEntity
  {
    [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
    public int VTK_CODIGO { get; set; }
    public DateTime VTK_TIMESTAMP { get; set; }
    public string VTK_MD5 { get; set; }
    public string VTK_IDENTIFICACAO { get; set; }
    public string VTK_VDA_MD5 { get; set; }
    public string VTK_OPR_MD5 { get; set; }
    public string VTK_CTK_MD5 { get; set; }
    public DateTime VDA_MOVIMENTO { get; set; }
    public DateTime VTK_DATA { get; set; }
    public string VTK_DESCRICAO { get; set; }
    public decimal VTK_VALOR { get; set; }
    public bool VTK_SINCRONIZADO { get; set; }

    public override string ToString()
    {
      return VTK_DESCRICAO.PadRight(10) + VTK_VALOR.ToString("0.00").PadLeft(10);
    }
  }

  public class dsSZO_VTK_VENDA_TICKETS : DefaultDataSource<SZO_VTK_VENDA_TICKETS>
  {
    public dsSZO_VTK_VENDA_TICKETS(DbBase DbBase)
      : base(DbBase)
    { }

    public SZO_VTK_VENDA_TICKETS Get(int VTK_CODIGO)
    {
      return Get("SELECT * FROM SZO_VTK_VENDA_TICKETS WHERE VTK_CODIGO = " + VTK_CODIGO);
    }

    public SZO_VTK_VENDA_TICKETS Get_FromMD5(string VTK_MD5)
    {
      return Get("SELECT * FROM SZO_VTK_VENDA_TICKETS WHERE VTK_MD5 = " + DbQuoted(VTK_MD5));
    }

    public SZO_VTK_VENDA_TICKETS[] List_NaoSincronizado()
    {
      return List("SELECT * FROM SZO_VTK_VENDA_TICKETS WHERE VTK_SINCRONIZADO = 0 OR VTK_SINCRONIZADO IS NULL");
    }

    public void MarcaSincronizado(int VTK_CODIGO)
    { DbBase.DbExecute("UPDATE SZO_VTK_VENDA_TICKETS SET VTK_SINCRONIZADO = 1 WHERE VTK_CODIGO = " + VTK_CODIGO); }

    public void Save(SZO_VTK_VENDA_TICKETS tab, System.Data.Common.DbTransaction transaction = null)
    {
      if (tab.VTK_CODIGO == 0)
      {
        tab.VTK_TIMESTAMP = DateTime.UtcNow;
        if (string.IsNullOrEmpty(tab.VTK_MD5))
        { tab.VTK_MD5 = lib.Class.Encryption.getMD5Hash(Guid.NewGuid().ToString()); }

        Insert(tab, transaction); 
      }
      else
      { Update(tab, new SZO_VTK_VENDA_TICKETS() { VTK_CODIGO = tab.VTK_CODIGO }, transaction); }
    }

    public void RemoveSincronizados()
    { DbBase.DbExecute("DELETE FROM SZO_VTK_VENDA_TICKETS WHERE VTK_SINCRONIZADO = 1"); }
  }
}
