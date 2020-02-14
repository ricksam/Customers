using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace ControlePortarias
{
  public class AUT_AUTORIZADOS : DefaultEntity
  {
    public int AUT_CODIGO { get; set; }
    public int AUT_CAS_CODIGO { get; set; }
    public int AUT_MRD_CODIGO { get; set; }
    public DateTime AUT_REGISTRO { get; set; }
    public DateTime AUT_ALTERACAO { get; set; }
    public DateTime AUT_DATADE { get; set; }
    public DateTime AUT_DATAATE { get; set; }
    public bool AUT_PRE_AUTORIZADO { get; set; }
    public bool AUT_INATIVO { get; set; }
    public bool AUT_SINCRONIZAR { get; set; }
    public string AUT_NOME { get; set; }
    public string AUT_TITULO { get; set; }
    public string AUT_EMAIL { get; set; }
    public string AUT_TELEFONE { get; set; }
    public string AUT_VEICULO { get; set; }
    public string AUT_PLACA { get; set; }
    public string AUT_DOCUMENTO { get; set; }
    public string AUT_HASHMD5 { get; set; }
  }

  public class dsAUT_AUTORIZADOS : DefaultDataSource<AUT_AUTORIZADOS>
  {
    public dsAUT_AUTORIZADOS(Connection cnn)
      : base(cnn)
    { }

    public AUT_AUTORIZADOS Get(int id)
    {
      cnn.QueryParam.Add(id);
      return Get("select * from AUT_AUTORIZADOS where AUT_CODIGO = {0} AND AUT_INATIVO <> 1");
    }

    public AUT_AUTORIZADOS Get_FromHashMD5(string AUT_HASHMD5)
    {
      cnn.QueryParam.Add(AUT_HASHMD5);
      return Get("select * from AUT_AUTORIZADOS where AUT_HASHMD5 = {0} AND AUT_INATIVO <> 1");
    }

    public DateTime LastUpdate()
    {
      return cnn.Sql("SELECT MAX(AUT_ALTERACAO) FROM AUT_AUTORIZADOS WHERE AUT_INATIVO <> 1").ToDateTime();
    }

    public override LockedField[] GetLockedFields(AUT_AUTORIZADOS Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (string.IsNullOrEmpty(Tab.AUT_NOME))
      { LockedFields.Add(new LockedField("AUT_NOME", " - Informe o campo Nome")); }

      if (string.IsNullOrEmpty(Tab.AUT_TITULO))
      { LockedFields.Add(new LockedField("AUT_TITULO", " - Informe o campo Titulo/Parentesco")); }

      if ((Tab.AUT_DATADE == DateTime.MinValue || Tab.AUT_DATAATE == DateTime.MinValue) && !Tab.AUT_PRE_AUTORIZADO)
      { LockedFields.Add(new LockedField("AUT_DATADE", " - Informe o período de visitas ou o campo pre autorizado")); }

      return LockedFields.ToArray();
    }

    public AUT_AUTORIZADOS[] GetList_FromSincronizar()
    {
      return GetList("select * from AUT_AUTORIZADOS where AUT_SINCRONIZAR = 1 AND AUT_INATIVO <> 1", 0);
    }

    public AUT_AUTORIZADOS[] GetList_FromCasa(int AUT_CAS_CODIGO)
    {
      cnn.QueryParam.Add(AUT_CAS_CODIGO);
      cnn.QueryParam.Add(DateTime.Now, enmFieldType.DateTime);
      return GetList("select * from AUT_AUTORIZADOS where AUT_CAS_CODIGO = {0} AND AUT_INATIVO <> 1 AND (AUT_PRE_AUTORIZADO = 1 OR AUT_DATAATE > {1})", 0);
    }

    public bool Save(AUT_AUTORIZADOS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      if (string.IsNullOrEmpty(Tab.AUT_HASHMD5))
      { Tab.AUT_HASHMD5 = lib.Class.Encryption.MD5_Hash(DateTime.Now.ToString("yyyyMMddHHmmss") + DateTime.Now.Millisecond + "_" + Guid.NewGuid()); }

      this.sb.Clear();
      this.sb.Table = "AUT_AUTORIZADOS";
      this.sb.AddField("AUT_CAS_CODIGO", Tab.AUT_CAS_CODIGO);
      this.sb.AddField("AUT_MRD_CODIGO", Tab.AUT_MRD_CODIGO);
      this.sb.AddField("AUT_PRE_AUTORIZADO", Tab.AUT_PRE_AUTORIZADO);
      this.sb.AddField("AUT_INATIVO", Tab.AUT_INATIVO);
      this.sb.AddField("AUT_NOME", Tab.AUT_NOME, 60);
      this.sb.AddField("AUT_TITULO", Tab.AUT_TITULO, 40);
      this.sb.AddField("AUT_EMAIL", Tab.AUT_EMAIL, 80);
      this.sb.AddField("AUT_TELEFONE", Tab.AUT_TELEFONE, 20);
      this.sb.AddField("AUT_VEICULO", Tab.AUT_VEICULO, 60);
      this.sb.AddField("AUT_PLACA", Tab.AUT_PLACA, 20);
      this.sb.AddField("AUT_DOCUMENTO", Tab.AUT_DOCUMENTO, 20);
      this.sb.AddField("AUT_ALTERACAO", DateTime.Now, enmFieldType.DateTime);
      this.sb.AddField("AUT_SINCRONIZAR", Tab.AUT_SINCRONIZAR);
      this.sb.AddField("AUT_HASHMD5", Tab.AUT_HASHMD5, 40);

      if (Tab.AUT_DATADE.Subtract(Convert.ToDateTime("1970-01-01")).TotalDays < 0)
      { this.sb.AddField("AUT_DATADE", null); }
      else
      { this.sb.AddField("AUT_DATADE", Tab.AUT_DATADE, enmFieldType.DateTime); }

      if (Tab.AUT_DATAATE.Subtract(Convert.ToDateTime("1970-01-01")).TotalDays < 0)
      { this.sb.AddField("AUT_DATAATE", null); }
      else
      { this.sb.AddField("AUT_DATAATE", Tab.AUT_DATAATE, enmFieldType.DateTime); }

      bool Gravou = false;
      if (Tab.AUT_CODIGO == 0)
      {
        this.sb.AddField("AUT_REGISTRO", DateTime.Now, enmFieldType.DateTime);
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.AUT_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where AUT_CODIGO = " + Tab.AUT_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int AUT_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "AUT_AUTORIZADOS";
      this.sb.AddField("AUT_INATIVO", true);
      return this.cnn.Exec(this.sb.getUpdate("where AUT_CODIGO = " + AUT_CODIGO));
    }

    public bool Remove_FromCasa(int AUT_CAS_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "AUT_AUTORIZADOS";
      this.sb.AddField("AUT_INATIVO", true);
      return this.cnn.Exec(this.sb.getUpdate("where MRD_CAS_CODIGO = " + AUT_CAS_CODIGO));
    }

    public bool Remove_Antigos(int AUT_CAS_CODIGO, AUT_AUTORIZADOS[] Atuais)
    {
      string cod_atuais = "";
      for (int i = 0; i < Atuais.Length; i++)
      { cod_atuais += (i == 0 ? "" : ",") + Atuais[i].AUT_CODIGO; }

      this.sb.Clear();
      this.sb.Table = "AUT_AUTORIZADOS";
      this.sb.AddField("AUT_INATIVO", true);

      this.cnn.QueryParam.Add(AUT_CAS_CODIGO);
      this.cnn.QueryParam.Add(cod_atuais, enmFieldType.Undefined);
      
      if (string.IsNullOrEmpty(cod_atuais))
      { return this.cnn.Exec(this.sb.getUpdate("where AUT_CAS_CODIGO = {0}")); }
      else
      { return this.cnn.Exec(this.sb.getUpdate("where AUT_CAS_CODIGO = {0} and AUT_CODIGO not in ({1})")); }
    }
  }
}
