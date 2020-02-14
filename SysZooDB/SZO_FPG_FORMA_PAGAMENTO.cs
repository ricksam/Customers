using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lib.Entity;

namespace SysZoo
{
  public class SZO_FPG_FORMA_PAGAMENTO : DefaultEntity
  {
    [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
    public int FPG_CODIGO { get; set; }
    public DateTime FPG_TIMESTAMP { get; set; }
    public string FPG_MD5 { get; set; }
    public string FPG_DESCRICAO { get; set; }
    public bool FPG_INATIVO { get; set; }
    public bool FPG_SINCRONIZADO { get; set; }
    public override string ToString()
    {
      return FPG_DESCRICAO;
    }
  }

  public class dsSZO_FPG_FORMA_PAGAMENTO : DefaultDataSource<SZO_FPG_FORMA_PAGAMENTO>
  {
    public dsSZO_FPG_FORMA_PAGAMENTO(DbBase DbBase)
      : base(DbBase)
    { }

    public SZO_FPG_FORMA_PAGAMENTO Get(int FPG_CODIGO)
    {
      return Get("SELECT * FROM SZO_FPG_FORMA_PAGAMENTO WHERE FPG_CODIGO = " + FPG_CODIGO);
    }

    public SZO_FPG_FORMA_PAGAMENTO Get_FromMD5(string FPG_MD5, System.Data.Common.DbTransaction transaction = null)
    {
        return Get("SELECT * FROM SZO_FPG_FORMA_PAGAMENTO WHERE FPG_MD5 = " + DbQuoted(FPG_MD5), transaction);
    }

    public SZO_FPG_FORMA_PAGAMENTO[] List_Ativos()
    {
        //SZO_FPG_FORMA_PAGAMENTO[] list = List("SELECT * FROM SZO_FPG_FORMA_PAGAMENTO WHERE FPG_INATIVO = 0 OR FPG_INATIVO IS NULL");
      //return list;
        return List("SELECT * FROM SZO_FPG_FORMA_PAGAMENTO WHERE FPG_INATIVO = 0 OR FPG_INATIVO IS NULL");
    }

    /*private bool FormaAdicionada(List<SZO_FPG_FORMA_PAGAMENTO> list, string Descricao) 
    {
        foreach (var item in list)
        {
            if (item.FPG_DESCRICAO == Descricao)
            { return true; }
        }

        return false;
    }*/

    public SZO_FPG_FORMA_PAGAMENTO[] List_TimeStamp(DateTime TimeStamp)
    {
      return List("SELECT * FROM SZO_FPG_FORMA_PAGAMENTO WHERE FPG_TIMESTAMP > " + DbQuoted(TimeStamp.ToString("yyyy-MM-dd HH:mm:ss")));
    }

    public DateTime LastTimeStamp() 
    {
      return DbBase.DbGet("SELECT MAX(FPG_TIMESTAMP) FROM SZO_FPG_FORMA_PAGAMENTO").ToDateTime();
    }

    public SZO_FPG_FORMA_PAGAMENTO[] List_NaoSincronizado()
    {
      return List("SELECT * FROM SZO_FPG_FORMA_PAGAMENTO WHERE FPG_SINCRONIZADO = 0 OR FPG_SINCRONIZADO IS NULL");
    }

    public void MarcaSincronizado(int FPG_CODIGO)
    { DbBase.DbExecute("UPDATE SZO_FPG_FORMA_PAGAMENTO SET FPG_SINCRONIZADO = 1 WHERE FPG_CODIGO = " + FPG_CODIGO); }

    public void Save(SZO_FPG_FORMA_PAGAMENTO tab, System.Data.Common.DbTransaction transaction = null)
    {
      tab.FPG_DESCRICAO = SetMaxLength(tab.FPG_DESCRICAO, 40);

      if (tab.FPG_CODIGO == 0)
      {
        tab.FPG_TIMESTAMP = DateTime.UtcNow;
        if (string.IsNullOrEmpty(tab.FPG_MD5))
        { tab.FPG_MD5 = lib.Class.EncryptionDeprecated.GetMD5(Guid.NewGuid().ToString()); }

        Insert(tab, transaction);
      }
      else
      { Update(tab, new SZO_FPG_FORMA_PAGAMENTO() { FPG_CODIGO = tab.FPG_CODIGO }, transaction); }
    }

    public void InativaFormas(System.Data.Common.DbTransaction transaction) 
    {
        DbBase.DbExecute("UPDATE SZO_FPG_FORMA_PAGAMENTO SET FPG_INATIVO = 1 WHERE FPG_SINCRONIZADO = 1", transaction);
    }
  }
}
