using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lib.Entity;

namespace SysZoo
{
  public class SZO_CTK_CADASTRO_TICKETS : DefaultEntity
  {
    [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
    public int CTK_CODIGO { get; set; }
    public DateTime CTK_TIMESTAMP { get; set; }
    public string CTK_MD5 { get; set; }
    public string CTK_DESCRICAO { get; set; }
    public decimal CTK_VALOR { get; set; }
    public bool CTK_DOM { get; set; }
    public bool CTK_SEG { get; set; }
    public bool CTK_TER { get; set; }
    public bool CTK_QUA { get; set; }
    public bool CTK_QUI { get; set; }
    public bool CTK_SEX { get; set; }
    public bool CTK_SAB { get; set; }
    public bool CTK_INATIVO { get; set; }
    public bool CTK_SINCRONIZADO { get; set; }
    public string CTK_ATALHO { get; set; }

    public override string ToString()
    {
      return string.Format("{0} [{1}]", CTK_DESCRICAO, CTK_ATALHO);
    }
  }

  public class dsSZO_CTK_CADASTRO_TICKETS : DefaultDataSource<SZO_CTK_CADASTRO_TICKETS>
  {
    public dsSZO_CTK_CADASTRO_TICKETS(DbBase DbBase)
      : base(DbBase)
    { }

    public SZO_CTK_CADASTRO_TICKETS Get(int CTK_CODIGO)
    {
      return Get("SELECT * FROM SZO_CTK_CADASTRO_TICKETS WHERE CTK_CODIGO = " + CTK_CODIGO);
    }

    public SZO_CTK_CADASTRO_TICKETS Get_FromMD5(string CTK_MD5, System.Data.Common.DbTransaction transaction = null)
    {
        return Get("SELECT * FROM SZO_CTK_CADASTRO_TICKETS WHERE CTK_MD5 = " + DbQuoted(CTK_MD5), transaction);
    }

    public SZO_CTK_CADASTRO_TICKETS[] List_Ativos() 
    {
      return List("SELECT * FROM SZO_CTK_CADASTRO_TICKETS WHERE CTK_INATIVO = 0 OR CTK_INATIVO IS NULL");
    }

    public SZO_CTK_CADASTRO_TICKETS[] List_TimeStamp(DateTime TimeStamp)
    {
      return List("SELECT * FROM SZO_CTK_CADASTRO_TICKETS WHERE CTK_TIMESTAMP > " + DbQuoted(TimeStamp.ToString("yyyy-MM-dd HH:mm:ss")));
    }

    public DateTime LastTimeStamp()
    {
      return DbBase.DbGet("SELECT MAX(CTK_TIMESTAMP) FROM SZO_CTK_CADASTRO_TICKETS").ToDateTime();
    }

    public SZO_CTK_CADASTRO_TICKETS[] List_NaoSincronizado()
    {
      return List("SELECT * FROM SZO_CTK_CADASTRO_TICKETS WHERE CTK_SINCRONIZADO = 0 OR CTK_SINCRONIZADO IS NULL");
    }

    public void MarcaSincronizado(int CTK_CODIGO)
    { DbBase.DbExecute("UPDATE SZO_CTK_CADASTRO_TICKETS SET CTK_SINCRONIZADO = 1 WHERE CTK_CODIGO = " + CTK_CODIGO); }

    public SZO_CTK_CADASTRO_TICKETS[] List_Hoje()
    {
      string WH = "";
      switch (DateTime.Now.DayOfWeek)
      {
        case DayOfWeek.Sunday: { WH = "AND CTK_DOM = 1"; break; }
        case DayOfWeek.Monday: { WH = "AND CTK_SEG = 1"; break; }
        case DayOfWeek.Tuesday: { WH = "AND CTK_TER = 1"; break; }
        case DayOfWeek.Wednesday: { WH = "AND CTK_QUA = 1"; break; }
        case DayOfWeek.Thursday: { WH = "AND CTK_QUI = 1"; break; }
        case DayOfWeek.Friday: { WH = "AND CTK_SEX = 1"; break; }
        case DayOfWeek.Saturday: { WH = "AND CTK_SAB = 1"; break; }
        default: { break; }
      }
      return List("SELECT * FROM SZO_CTK_CADASTRO_TICKETS WHERE (CTK_INATIVO = 0 OR CTK_INATIVO IS NULL)" + WH);
    }

    public void Save(SZO_CTK_CADASTRO_TICKETS tab, System.Data.Common.DbTransaction transaction = null)
    {
      tab.CTK_DESCRICAO = SetMaxLength(tab.CTK_DESCRICAO, 40);

      if (tab.CTK_CODIGO == 0)
      {
        tab.CTK_TIMESTAMP = DateTime.UtcNow;
        if (string.IsNullOrEmpty(tab.CTK_MD5))
        { tab.CTK_MD5 = lib.Class.Encryption.getMD5Hash(Guid.NewGuid().ToString()); }

        Insert(tab, transaction);
      }
      else
      { Update(tab, new SZO_CTK_CADASTRO_TICKETS() { CTK_CODIGO = tab.CTK_CODIGO }, transaction); }
    }

    public void InativaIngressos(System.Data.Common.DbTransaction transaction)
    {
        DbBase.DbExecute("UPDATE SZO_CTK_CADASTRO_TICKETS SET CTK_INATIVO = 1 WHERE CTK_SINCRONIZADO = 1", transaction);
    }
  }
}
