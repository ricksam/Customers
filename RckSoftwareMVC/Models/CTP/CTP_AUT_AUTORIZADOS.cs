using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace RckSoftwareMVC
{
  public partial class CTP_AUT_AUTORIZADOS : DefaultEntity
  {
    public int AUT_CODIGO { get; set; }
    public DateTime AUT_REGISTRO { get; set; }
    public DateTime AUT_ALTERACAO { get; set; }
    public string AUT_NOME { get; set; }
    public string AUT_TITULO { get; set; }
    public string AUT_EMAIL { get; set; }
    public string AUT_TELEFONE { get; set; }
    public string AUT_VEICULO { get; set; }
    public string AUT_PLACA { get; set; }
    public string AUT_DOCUMENTO { get; set; }
    public DateTime AUT_DATADE { get; set; }
    public DateTime AUT_DATAATE { get; set; }
    public bool AUT_PRE_AUTORIZADO { get; set; }
    public string AUT_HASHMD5 { get; set; }
    public string AUT_CAS_HASHMD5 { get; set; }
    public bool AUT_INATIVO { get; set; }
    /*public string[] Titulos { get; set; }*/
  }

  public partial class dsCTP_AUT_AUTORIZADOS : DefaultDataSource<CTP_AUT_AUTORIZADOS>
  {
    public dsCTP_AUT_AUTORIZADOS(Connection cnn)
      : base(cnn)
    { }

    public CTP_AUT_AUTORIZADOS Get(int id)
    {
      return Get("select * from CTP_AUT_AUTORIZADOS where AUT_CODIGO = " + id.ToString());
    }

    public CTP_AUT_AUTORIZADOS Get_FromMD5HASH(string AUT_MRD_HASHMD5)
    {
      cnn.QueryParam.Add(AUT_MRD_HASHMD5);
      return Get("select * from CTP_AUT_AUTORIZADOS where AUT_HASHMD5 = {0}");
    }

    public CTP_AUT_AUTORIZADOS[] GetList_FromAlteracao(DateTime AUT_ALTERACAO) 
    {
      if (AUT_ALTERACAO == DateTime.MinValue)
      { AUT_ALTERACAO = Convert.ToDateTime("1970-01-01"); }

      cnn.QueryParam.Add(AUT_ALTERACAO, enmFieldType.DateTime);
      return GetList("select * from CTP_AUT_AUTORIZADOS where AUT_ALTERACAO > {0} ORDER BY AUT_ALTERACAO", 100);
    }

    public CTP_AUT_AUTORIZADOS[] GetList_Ativos(string AUT_MRD_HASHMD5)
    {
      cnn.QueryParam.Add(AUT_MRD_HASHMD5);
      cnn.QueryParam.Add(DateTime.Now, enmFieldType.DateTime);
      return GetList("select * from CTP_AUT_AUTORIZADOS where AUT_CAS_HASHMD5 = {0} and (AUT_INATIVO = 0 or AUT_INATIVO is null) and (AUT_PRE_AUTORIZADO = 1 OR AUT_DATAATE > {1})", 0);
    }

    public string[] GetTitulos()
    {
      System.Data.DataTable dt = cnn.GetDataTable("select AUT_TITULO from CTP_AUT_AUTORIZADOS group by AUT_TITULO");
      string[] titulos = new string[dt.Rows.Count];
      for (int i = 0; i < dt.Rows.Count; i++)
      { titulos[i] = dt.Rows[i]["AUT_TITULO"].ToString(); }
      return titulos;
    }

    public CTP_AUT_AUTORIZADOS[] Search(string s)
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add("%" + s + "%");

      return GetList(
        @"SELECT * FROM CTP_AUT_AUTORIZADOS
         WHERE 
           AUT_REGISTRO LIKE {0} 
           or AUT_ALTERACAO LIKE {0} 
           or AUT_NOME LIKE {0} 
           or AUT_TITULO LIKE {0} 
           or AUT_EMAIL LIKE {0} 
           or AUT_TELEFONE LIKE {0} 
           or AUT_VEICULO LIKE {0} 
           or AUT_PLACA LIKE {0} 
           or AUT_DOCUMENTO LIKE {0} 
           or AUT_DATADE LIKE {0} 
           or AUT_DATAATE LIKE {0} 
           or AUT_PRE_AUTORIZADO LIKE {0} 
           or AUT_MRD_HASHMD5 LIKE {0} 
           or AUT_INATIVO LIKE {0} 
         ", 200);
    }

    public override LockedField[] GetLockedFields(CTP_AUT_AUTORIZADOS Tab)
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

    public bool Save(CTP_AUT_AUTORIZADOS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      if (string.IsNullOrEmpty(Tab.AUT_HASHMD5))
      { Tab.AUT_HASHMD5 = lib.Class.Encryption.GetMD5(DateTime.Now.ToString("yyyyMMddHHmmss") + DateTime.Now.Millisecond + "_" + Guid.NewGuid()); }

      this.sb.Clear();
      this.sb.Table = "CTP_AUT_AUTORIZADOS";
      this.sb.AddField("AUT_NOME", Tab.AUT_NOME, 60);
      this.sb.AddField("AUT_TITULO", Tab.AUT_TITULO, 40);
      this.sb.AddField("AUT_EMAIL", Tab.AUT_EMAIL, 80);
      this.sb.AddField("AUT_TELEFONE", Tab.AUT_TELEFONE, 20);
      this.sb.AddField("AUT_VEICULO", Tab.AUT_VEICULO, 60);
      this.sb.AddField("AUT_PLACA", Tab.AUT_PLACA, 20);
      this.sb.AddField("AUT_DOCUMENTO", Tab.AUT_DOCUMENTO, 20);
      this.sb.AddField("AUT_PRE_AUTORIZADO", Tab.AUT_PRE_AUTORIZADO);
      this.sb.AddField("AUT_HASHMD5", Tab.AUT_HASHMD5, 40);
      this.sb.AddField("AUT_CAS_HASHMD5", Tab.AUT_CAS_HASHMD5, 40);
      this.sb.AddField("AUT_INATIVO", Tab.AUT_INATIVO);
      this.sb.AddField("AUT_ALTERACAO", DateTime.Now, enmFieldType.DateTime);

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
      this.sb.Table = "CTP_AUT_AUTORIZADOS";
      return this.cnn.Exec(this.sb.getDelete("where AUT_CODIGO = " + AUT_CODIGO));
    }
  }
}
