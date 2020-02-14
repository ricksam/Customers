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
  public class CAS_CASA : DefaultEntity
  {
    public int CAS_CODIGO { get; set; }
    public DateTime CAS_REGISTRO { get; set; }
    public DateTime CAS_ALTERACAO { get; set; }
    public string CAS_NUMERO { get; set; }
    public string CAS_LOTE { get; set; }
    public string CAS_QUADRA { get; set; }
    public string CAS_RAMAL { get; set; }
    public string CAS_HASHMD5 { get; set; }
    public bool CAS_INATIVO { get; set; }
    
    public override string ToString() 
    {
      return string.Format("C.{0} L.{1} Q.{2}", CAS_NUMERO, CAS_LOTE, CAS_QUADRA);
    }
  }

  public class dsCAS_CASA : DefaultDataSource<CAS_CASA>
  {
    public dsCAS_CASA(Connection cnn)
      : base(cnn)
    { }

    public CAS_CASA Get(int id)
    {
      cnn.QueryParam.Add(id);
      return Get("select * from CAS_CASA where CAS_CODIGO = {0} and CAS_INATIVO <> 1");
    }

    public CAS_CASA Get_FromHashMD5(string CAS_HASHMD5)
    {
      cnn.QueryParam.Add(CAS_HASHMD5);
      return Get("select * from CAS_CASA where CAS_HASHMD5 = {0} and CAS_INATIVO <> 1");
    }

    public CAS_CASA[] GetList_WithProprietario() 
    {
      return GetList("SELECT * FROM CAS_CASA INNER JOIN MRD_MORADOR ON MRD_CAS_CODIGO = CAS_CODIGO WHERE MRD_PROPRIETARIO = 1 and CAS_INATIVO <> 1", 0);
    }

    public CAS_CASA[] Search(string s)
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add("%" + s + "%");

      return GetList(
        @"SELECT * FROM CAS_CASA
         WHERE 
           (CAS_NUMERO LIKE {0} 
           or CAS_LOTE LIKE {0} 
           or CAS_QUADRA LIKE {0} 
           or CAS_RAMAL LIKE {0}) 
           and CAS_INATIVO <> 1
         ", 200);
    }

    public bool Save(CAS_CASA Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      if (string.IsNullOrEmpty(Tab.CAS_HASHMD5))
      { Tab.CAS_HASHMD5 = lib.Class.Encryption.MD5_Hash(DateTime.Now.ToString("yyyyMMddHHmmss") + DateTime.Now.Millisecond + "_" + Guid.NewGuid()); }

      this.sb.Clear();
      this.sb.Table = "CAS_CASA";
      this.sb.AddField("CAS_NUMERO", Tab.CAS_NUMERO, 20);
      this.sb.AddField("CAS_LOTE", Tab.CAS_LOTE, 20);
      this.sb.AddField("CAS_QUADRA", Tab.CAS_QUADRA, 20);
      this.sb.AddField("CAS_RAMAL", Tab.CAS_RAMAL, 20);
      this.sb.AddField("CAS_INATIVO", Tab.CAS_INATIVO);
      this.sb.AddField("CAS_ALTERACAO", DateTime.Now, enmFieldType.DateTime);
      this.sb.AddField("CAS_HASHMD5", Tab.CAS_HASHMD5, 40);

      bool Gravou = false;
      if (Tab.CAS_CODIGO == 0)
      {
        this.sb.AddField("CAS_REGISTRO", DateTime.Now, enmFieldType.DateTime);        
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.CAS_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where CAS_CODIGO = " + Tab.CAS_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int CAS_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "CAS_CASA";
      this.sb.AddField("CAS_INATIVO", true);
      return this.cnn.Exec(this.sb.getUpdate("where CAS_CODIGO = " + CAS_CODIGO));
    }
  }
}
