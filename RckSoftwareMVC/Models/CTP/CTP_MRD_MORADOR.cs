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
  public partial class CTP_MRD_MORADOR : DefaultEntity
  {
    public int MRD_CODIGO { get; set; }
    public DateTime MRD_REGISTRO { get; set; }
    public DateTime MRD_ALTERACAO { get; set; }
    public string CAS_NUMERO { get; set; }
    public string CAS_LOTE { get; set; }
    public string CAS_QUADRA { get; set; }
    public string CAS_RAMAL { get; set; }
    public string CAS_HASHMD5 { get; set; }
    public string MRD_NOME { get; set; }
    public string MRD_FOTO { get; set; }
    public string MRD_TITULO { get; set; }
    public string MRD_EMAIL { get; set; }
    public string MRD_SENHA { get; set; }
    public string MRD_CELULAR { get; set; }
    public string MRD_EPC { get; set; }
    public string MRD_VEICULO { get; set; }
    public string MRD_PLACA { get; set; }
    public string MRD_OBS { get; set; }
    public bool MRD_PROPRIETARIO { get; set; }
    public string MRD_HASHMD5 { get; set; }
    public string MRD_USR_KEY { get; set; }
    public bool MRD_INATIVO { get; set; }
  }

  public partial class dsCTP_MRD_MORADOR : DefaultDataSource<CTP_MRD_MORADOR>
  {
    public dsCTP_MRD_MORADOR(Connection cnn)
      : base(cnn)
    { }

    public CTP_MRD_MORADOR Get(int id)
    {
      return Get("select * from CTP_MRD_MORADOR where MRD_CODIGO = " + id.ToString());
    }

    public CTP_MRD_MORADOR[] GetList_FromAlteracao(DateTime MRD_ALTERACAO)
    {
      if (MRD_ALTERACAO == DateTime.MinValue)
      { MRD_ALTERACAO = Convert.ToDateTime("1970-01-01"); }

      cnn.QueryParam.Add(MRD_ALTERACAO, enmFieldType.DateTime);
      return GetList("select * from CTP_MRD_MORADOR where MRD_ALTERACAO > {0} ORDER BY MRD_ALTERACAO", 100);
    }

    public CTP_MRD_MORADOR Get_FromEmail(string MRD_EMAIL)
    {
      cnn.QueryParam.Add(MRD_EMAIL);
      return Get("select * from CTP_MRD_MORADOR where MRD_EMAIL = {0}");
    }

    public CTP_MRD_MORADOR Get_FromEmailSenha(string MRD_EMAIL, string MRD_SENHA)
    {
      cnn.QueryParam.Add(MRD_EMAIL);
      cnn.QueryParam.Add(MRD_SENHA);
      return Get("select * from CTP_MRD_MORADOR where MRD_EMAIL = {0} and MRD_SENHA = {1}");
    }

    public CTP_MRD_MORADOR Get_FromMD5HASH(string MRD_HASHMD5)
    {
      cnn.QueryParam.Add(MRD_HASHMD5);
      return Get("select * from CTP_MRD_MORADOR where MRD_HASHMD5 = {0}");
    }

    public CTP_MRD_MORADOR[] GetList_Ativos()
    {
      return GetList("select * from CTP_MRD_MORADOR where MRD_INATIVO = 0 or MRD_INATIVO is null ", 0);
    }


    public CTP_MRD_MORADOR[] Search(string s)
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add("%" + s + "%");

      return GetList(
        @"SELECT * FROM CTP_MRD_MORADOR
         WHERE 
           MRD_REGISTRO LIKE {0} 
           or MRD_ALTERACAO LIKE {0} 
           or MRD_CAS_NUMERO LIKE {0} 
           or MRD_CAS_LOTE LIKE {0} 
           or MRD_CAS_QUADRA LIKE {0} 
           or MRD_CAS_RAMAL LIKE {0} 
           or MRD_NOME LIKE {0} 
           or MRD_FOTO LIKE {0} 
           or MRD_TITULO LIKE {0} 
           or MRD_EMAIL LIKE {0} 
           or MRD_CELULAR LIKE {0} 
           or MRD_EPC LIKE {0} 
           or MRD_VEICULO LIKE {0} 
           or MRD_PLACA LIKE {0} 
           or MRD_OBS LIKE {0} 
           or MRD_PROPRIETARIO LIKE {0} 
           or MRD_HASHMD5 LIKE {0} 
           or MRD_USR_KEY LIKE {0} 
           or MRD_INATIVO LIKE {0} 
         ", 200);
    }

    public override LockedField[] GetLockedFields(CTP_MRD_MORADOR Tab)
    {
      return base.GetLockedFields(Tab);
    }

    public bool Save(CTP_MRD_MORADOR Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "CTP_MRD_MORADOR";
      this.sb.AddField("CAS_NUMERO", Tab.CAS_NUMERO, 20);
      this.sb.AddField("CAS_LOTE", Tab.CAS_LOTE, 20);
      this.sb.AddField("CAS_QUADRA", Tab.CAS_QUADRA, 20);
      this.sb.AddField("CAS_RAMAL", Tab.CAS_RAMAL, 20);
      this.sb.AddField("CAS_HASHMD5", Tab.CAS_HASHMD5, 40);
      this.sb.AddField("MRD_NOME", Tab.MRD_NOME, 60);
      this.sb.AddField("MRD_FOTO", Tab.MRD_FOTO, 65535);
      this.sb.AddField("MRD_TITULO", Tab.MRD_TITULO, 40);
      this.sb.AddField("MRD_EMAIL", Tab.MRD_EMAIL, 80);      
      this.sb.AddField("MRD_CELULAR", Tab.MRD_CELULAR, 20);
      this.sb.AddField("MRD_EPC", Tab.MRD_EPC, 40);
      this.sb.AddField("MRD_VEICULO", Tab.MRD_VEICULO, 60);
      this.sb.AddField("MRD_PLACA", Tab.MRD_PLACA, 20);
      this.sb.AddField("MRD_OBS", Tab.MRD_OBS, 200);
      this.sb.AddField("MRD_PROPRIETARIO", Tab.MRD_PROPRIETARIO);
      this.sb.AddField("MRD_HASHMD5", Tab.MRD_HASHMD5, 40);
      this.sb.AddField("MRD_USR_KEY", Tab.MRD_USR_KEY, 40);
      this.sb.AddField("MRD_INATIVO", Tab.MRD_INATIVO);
      this.sb.AddField("MRD_ALTERACAO", DateTime.Now, enmFieldType.DateTime);

      if (!string.IsNullOrEmpty(Tab.MRD_SENHA))
      { this.sb.AddField("MRD_SENHA", Tab.MRD_SENHA, 40); }

      bool Gravou = false;
      if (Tab.MRD_CODIGO == 0)
      {
        this.sb.AddField("MRD_REGISTRO", DateTime.Now, enmFieldType.DateTime);
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.MRD_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where MRD_CODIGO = " + Tab.MRD_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int MRD_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "CTP_MRD_MORADOR";
      return this.cnn.Exec(this.sb.getDelete("where MRD_CODIGO = " + MRD_CODIGO));
    }
  }
}
