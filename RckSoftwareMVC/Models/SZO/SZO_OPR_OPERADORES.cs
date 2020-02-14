using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lib.Entity;

namespace SysZoo
{
  public class SZO_OPR_OPERADORES : DefaultEntity
  {
    [CustomAttributeField(KeyTypeAttribute.PrimaryKey)]
    public int OPR_CODIGO { get; set; }
    public DateTime OPR_TIMESTAMP { get; set; }
    public string OPR_MD5 { get; set; }
    public string OPR_NOME { get; set; }
    public string OPR_SENHA { get; set; }
    public bool OPR_GERENCIA { get; set; }
    public bool OPR_CANCELAR_ITEM { get; set; }
    public bool OPR_CANCELAR_CUPOM { get; set; }
    public bool OPR_INATIVO { get; set; }
    public bool OPR_SINCRONIZADO { get; set; }
  }

  public class dsSZO_OPR_OPERADORES : DefaultDataSource<SZO_OPR_OPERADORES>
  {
    public dsSZO_OPR_OPERADORES(DbBase DbBase)
      : base(DbBase)
    { }

    public SZO_OPR_OPERADORES Get(int OPR_CODIGO)
    {
      return Get("SELECT * FROM SZO_OPR_OPERADORES WHERE OPR_CODIGO = " + OPR_CODIGO);
    }

    public SZO_OPR_OPERADORES Get_FromMD5(string OPR_MD5)
    {
      return Get("SELECT * FROM SZO_OPR_OPERADORES WHERE OPR_MD5 = " + DbQuoted(OPR_MD5));
    }

    public SZO_OPR_OPERADORES Get_FromSenha(string OPR_SENHA)
    {
      return Get("SELECT * FROM SZO_OPR_OPERADORES WHERE (OPR_INATIVO = 0 OR OPR_INATIVO IS NULL) AND OPR_SENHA = " + DbQuoted(lib.Class.Encryption.getMD5Hash(OPR_SENHA)));
    }

    public SZO_OPR_OPERADORES[] List_Ativos()
    {
      return List("SELECT * FROM SZO_OPR_OPERADORES WHERE OPR_INATIVO = 0 OR OPR_INATIVO IS NULL");
    }

    public SZO_OPR_OPERADORES[] List_TimeStamp(DateTime TimeStamp)
    {
      return List("SELECT * FROM SZO_OPR_OPERADORES WHERE OPR_TIMESTAMP > " + DbQuoted(TimeStamp.ToString("yyyy-MM-dd HH:mm:ss")));
    }

    public DateTime LastTimeStamp()
    {
      return DbBase.DbGet("SELECT MAX(OPR_TIMESTAMP) FROM SZO_OPR_OPERADORES").ToDateTime();
    }

    public SZO_OPR_OPERADORES[] List_NaoSincronizado()
    {
      return List("SELECT * FROM SZO_OPR_OPERADORES WHERE OPR_SINCRONIZADO = 0 OR OPR_SINCRONIZADO IS NULL");
    }

    public void MarcaSincronizado(int OPR_CODIGO)
    { DbBase.DbExecute("UPDATE SZO_OPR_OPERADORES SET OPR_SINCRONIZADO = 1 WHERE OPR_CODIGO = " + OPR_CODIGO); }

    public void Save(SZO_OPR_OPERADORES tab, System.Data.Common.DbTransaction transaction = null)
    {
      tab.OPR_NOME = SetMaxLength(tab.OPR_NOME, 40);

      if (tab.OPR_SENHA.Length <= 8)
      { tab.OPR_SENHA = lib.Class.Encryption.getMD5Hash(tab.OPR_SENHA); }

      if (tab.OPR_CODIGO == 0)
      {
        tab.OPR_TIMESTAMP = DateTime.UtcNow;
        if (string.IsNullOrEmpty(tab.OPR_MD5))
        { tab.OPR_MD5 = lib.Class.Encryption.getMD5Hash(Guid.NewGuid().ToString()); }

        Insert(tab, transaction);
      }
      else
      { Update(tab, new SZO_OPR_OPERADORES() { OPR_CODIGO = tab.OPR_CODIGO }, transaction); }
    }
  }
}
