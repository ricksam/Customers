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
  public class MRD_MORADOR : DefaultEntity
  {
    public int MRD_CODIGO { get; set; }
    public int MRD_CAS_CODIGO { get; set; }
    public DateTime MRD_REGISTRO { get; set; }
    public DateTime MRD_ALTERACAO { get; set; }
    public string MRD_NOME { get; set; }
    public string MRD_FOTO { get; set; }
    public string MRD_TITULO { get; set; }
    public string MRD_EMAIL { get; set; }
    public string MRD_CELULAR { get; set; }
    public string MRD_EPC { get; set; }
    public string MRD_VEICULO { get; set; }
    public string MRD_PLACA { get; set; }
    public string MRD_OBS { get; set; }
    public bool MRD_PROPRIETARIO { get; set; }
    public string MRD_HASHMD5 { get; set; }
    public bool MRD_SINCRONIZAR { get; set; }
    public bool MRD_INATIVO { get; set; }
  }

  public class dsMRD_MORADOR : DefaultDataSource<MRD_MORADOR>
  {
    public dsMRD_MORADOR(Connection cnn)
      : base(cnn)
    { }

    public MRD_MORADOR Get(int id)
    {
      cnn.QueryParam.Add(id);
      return Get("select * from MRD_MORADOR where MRD_CODIGO = {0} and MRD_INATIVO <> 1");
    }

    public MRD_MORADOR Get_FromHashMD5(string MRD_HASHMD5)
    {
      cnn.QueryParam.Add(MRD_HASHMD5);
      return Get("select * from MRD_MORADOR where MRD_HASHMD5 = {0} and MRD_INATIVO <> 1");
    }

    public MRD_MORADOR[] Search(string s)
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add("%" + s + "%");

      return GetList(
         @"SELECT * FROM MRD_MORADOR
         WHERE
            MRD_NOME LIKE {0} 
            or MRD_TITULO LIKE {0} 
            or MRD_EMAIL LIKE {0} 
            or MRD_CELULAR LIKE {0} 
            or MRD_EPC LIKE {0} 
            or MRD_VEICULO LIKE {0} 
            or MRD_PLACA LIKE {0}  
         ", 200);
    }

    public DateTime LastUpdate() 
    {
      return cnn.Sql("SELECT MAX(MRD_ALTERACAO) FROM MRD_MORADOR WHERE MRD_INATIVO <> 1").ToDateTime();
    }

    public override LockedField[] GetLockedFields(MRD_MORADOR Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (Tab.MRD_NOME == "")
      { LockedFields.Add(new LockedField("MRD_NOME", " - Informe o campo Nome")); }

      if (Tab.MRD_CELULAR == "")
      { LockedFields.Add(new LockedField("MRD_TITULO", " - Informe o campo Titulo")); }

      return LockedFields.ToArray();
    } 

    public string[] GetList_Titulo() 
    {
      DataTable dt = cnn.GetDataTable("SELECT MRD_TITULO FROM MRD_MORADOR  where MRD_INATIVO <> 1 GROUP BY MRD_TITULO");
      string[] lst = new string[dt.Rows.Count];
      for (int i = 0; i < dt.Rows.Count; i++)
      { lst[i] = dt.Rows[i]["MRD_TITULO"].ToString(); }
      return lst;
    }

    public MRD_MORADOR[] GetList_FromSincronizar() 
    {
      return GetList("select * from MRD_MORADOR where MRD_SINCRONIZAR = 1 and MRD_INATIVO <> 1", 0);
    }

    public MRD_MORADOR[] GetList_FromCasa(int MRD_CAS_CODIGO) 
    {
      cnn.QueryParam.Add(MRD_CAS_CODIGO);
      return GetList("SELECT * FROM MRD_MORADOR WHERE MRD_CAS_CODIGO = {0} and MRD_INATIVO <> 1", 0);
    }

    public bool Save(MRD_MORADOR Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      if (string.IsNullOrEmpty(Tab.MRD_HASHMD5))
      { Tab.MRD_HASHMD5 = lib.Class.Encryption.MD5_Hash(DateTime.Now.ToString("yyyyMMddHHmmss") + DateTime.Now.Millisecond + "_" + Guid.NewGuid()); }

      this.sb.Clear();
      this.sb.Table = "MRD_MORADOR";
      this.sb.AddField("MRD_CAS_CODIGO", Tab.MRD_CAS_CODIGO);
      this.sb.AddField("MRD_NOME", Tab.MRD_NOME, 60);
      this.sb.AddField("MRD_FOTO", Tab.MRD_FOTO, 2147483647);
      this.sb.AddField("MRD_TITULO", Tab.MRD_TITULO, 40);
      this.sb.AddField("MRD_EMAIL", Tab.MRD_EMAIL, 80);
      this.sb.AddField("MRD_CELULAR", Tab.MRD_CELULAR, 20);
      this.sb.AddField("MRD_EPC", Tab.MRD_EPC, 40);
      this.sb.AddField("MRD_VEICULO", Tab.MRD_VEICULO, 60);
      this.sb.AddField("MRD_PLACA", Tab.MRD_PLACA, 20);
      this.sb.AddField("MRD_OBS", Tab.MRD_OBS, 200);
      this.sb.AddField("MRD_PROPRIETARIO", Tab.MRD_PROPRIETARIO);
      this.sb.AddField("MRD_HASHMD5", Tab.MRD_HASHMD5, 40);
      this.sb.AddField("MRD_SINCRONIZAR", Tab.MRD_SINCRONIZAR);
      this.sb.AddField("MRD_INATIVO", Tab.MRD_INATIVO);
      this.sb.AddField("MRD_ALTERACAO", DateTime.Now, enmFieldType.DateTime);
      this.sb.AddField("MRD_SINCRONIZAR", Tab.MRD_SINCRONIZAR);
      this.sb.AddField("MRD_HASHMD5", Tab.MRD_HASHMD5, 40);

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
      this.sb.Table = "MRD_MORADOR";
      this.sb.AddField("MRD_INATIVO", true);
      return this.cnn.Exec(this.sb.getUpdate("where MRD_CODIGO = " + MRD_CODIGO));
    }

    public bool Remove_FromCasa(int MRD_CAS_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "MRD_MORADOR";
      this.sb.AddField("MRD_INATIVO", true);
      return this.cnn.Exec(this.sb.getUpdate("where MRD_CAS_CODIGO = " + MRD_CAS_CODIGO));
    }

    public bool Remove_Antigos(int MRD_CAS_CODIGO, MRD_MORADOR[] Atuais)
    {
      string cod_atuais = "";
      for (int i = 0; i < Atuais.Length; i++)
      { cod_atuais += (i == 0 ? "" : ",") + Atuais[i].MRD_CODIGO; }

      this.sb.Clear();
      this.sb.Table = "MRD_MORADOR";
      this.sb.AddField("MRD_INATIVO", true);

      this.cnn.QueryParam.Add(MRD_CAS_CODIGO);
      this.cnn.QueryParam.Add(cod_atuais, enmFieldType.Undefined);

      if (string.IsNullOrEmpty(cod_atuais))
      { return this.cnn.Exec(this.sb.getUpdate("where MRD_CAS_CODIGO = {0}")); }
      else
      { return this.cnn.Exec(this.sb.getUpdate("where MRD_CAS_CODIGO = {0} and MRD_CODIGO not in ({1})")); }
    }
  }
}
