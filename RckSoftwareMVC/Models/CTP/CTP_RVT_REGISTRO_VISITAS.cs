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
  public partial class CTP_RVT_REGISTRO_VISITAS : DefaultEntity
  {
    public int RVT_CODIGO { get; set; }
    public string RVT_MRD_HASHMD5 { get; set; }
    public DateTime RVT_REGISTRO { get; set; }
    public DateTime RVT_ALTERACAO { get; set; }
    public string RVT_FOTO { get; set; }
    public DateTime RVT_DATA { get; set; }
    public string RVT_NOME { get; set; }
    public string RVT_TITULO { get; set; }
    public string RVT_EMAIL { get; set; }
    public string RVT_TELEFONE { get; set; }
    public string RVT_VEICULO { get; set; }
    public string RVT_PLACA { get; set; }
    public string RVT_DOCUMENTO { get; set; }
    public string RVT_HASHMD5 { get; set; }
    public string RVT_STATUS { get; set; }
  }

  public partial class dsCTP_RVT_REGISTRO_VISITAS : DefaultDataSource<CTP_RVT_REGISTRO_VISITAS>
  {
    public dsCTP_RVT_REGISTRO_VISITAS(Connection cnn)
      : base(cnn)
    { }

    public CTP_RVT_REGISTRO_VISITAS Get(int id)
    {
      return Get("select * from CTP_RVT_REGISTRO_VISITAS where RVT_CODIGO = " + id.ToString());
    }

    public CTP_RVT_REGISTRO_VISITAS Get_FromMD5HASH(string RVT_HASHMD5)
    {
      cnn.QueryParam.Add(RVT_HASHMD5);
      return Get("select * from CTP_RVT_REGISTRO_VISITAS where RVT_HASHMD5 = {0}");
    }

    public CTP_RVT_REGISTRO_VISITAS[] Search(string s)
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add("%" + s + "%");

      return GetList(
        @"SELECT * FROM CTP_RVT_REGISTRO_VISITAS
         WHERE 
           RVT_MRD_HASHMD5 LIKE {0} 
           or RVT_REGISTRO LIKE {0} 
           or RVT_ALTERACAO LIKE {0} 
           or RVT_FOTO LIKE {0} 
           or RVT_DATA LIKE {0} 
           or RVT_NOME LIKE {0} 
           or RVT_TITULO LIKE {0} 
           or RVT_EMAIL LIKE {0} 
           or RVT_TELEFONE LIKE {0} 
           or RVT_VEICULO LIKE {0} 
           or RVT_PLACA LIKE {0} 
           or RVT_DOCUMENTO LIKE {0} 
         ", 200);
    }

    public override LockedField[] GetLockedFields(CTP_RVT_REGISTRO_VISITAS Tab)
    {
      return base.GetLockedFields(Tab);
    }

    public bool Save(CTP_RVT_REGISTRO_VISITAS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "CTP_RVT_REGISTRO_VISITAS";
      this.sb.AddField("RVT_MRD_HASHMD5", Tab.RVT_MRD_HASHMD5, 40);
      this.sb.AddField("RVT_FOTO", Tab.RVT_FOTO);
      this.sb.AddField("RVT_DATA", Tab.RVT_DATA, enmFieldType.DateTime);
      this.sb.AddField("RVT_NOME", Tab.RVT_NOME, 60);
      this.sb.AddField("RVT_TITULO", Tab.RVT_TITULO, 40);
      this.sb.AddField("RVT_EMAIL", Tab.RVT_EMAIL, 80);
      this.sb.AddField("RVT_TELEFONE", Tab.RVT_TELEFONE, 20);
      this.sb.AddField("RVT_VEICULO", Tab.RVT_VEICULO, 60);
      this.sb.AddField("RVT_PLACA", Tab.RVT_PLACA, 20);
      this.sb.AddField("RVT_DOCUMENTO", Tab.RVT_DOCUMENTO, 20);
      this.sb.AddField("RVT_HASHMD5", Tab.RVT_HASHMD5, 40);
      this.sb.AddField("RVT_STATUS", Tab.RVT_STATUS, 40);

      this.sb.AddField("RVT_ALTERACAO", DateTime.Now, enmFieldType.DateTime);

      bool Gravou = false;
      if (Tab.RVT_CODIGO == 0)
      {
        this.sb.AddField("RVT_REGISTRO", DateTime.Now, enmFieldType.DateTime);
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.RVT_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where RVT_CODIGO = " + Tab.RVT_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int RVT_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "CTP_RVT_REGISTRO_VISITAS";
      return this.cnn.Exec(this.sb.getDelete("where RVT_CODIGO = " + RVT_CODIGO));
    }
  }
}
