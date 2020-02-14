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
  public class RVT_REGISTRO_VISITAS : DefaultEntity
  {
    public int RVT_CODIGO { get; set; }
    public int RVT_CAS_CODIGO { get; set; }
    public int RVT_MRD_CODIGO { get; set; }
    public DateTime RVT_REGISTRO { get; set; }
    public DateTime RVT_ALTERACAO { get; set; }
    public string RVT_FOTO { get; set; }
    public DateTime RVT_DATA { get; set; }
    public bool RVT_SINCRONIZAR { get; set; }
    public string RVT_NOME { get; set; }
    public string RVT_TITULO { get; set; }
    public string RVT_EMAIL { get; set; }
    public string RVT_TELEFONE { get; set; }
    public string RVT_VEICULO { get; set; }
    public string RVT_PLACA { get; set; }
    public string RVT_DOCUMENTO { get; set; }
    public string RVT_STATUS { get; set; }
    public string RVT_HASHMD5 { get; set; }

    public string MRD_NOME { get; set; }

    public string CAS_NUMERO { get; set; }
    public string CAS_LOTE { get; set; }
    public string CAS_QUADRA { get; set; }
    public string CASA { get { return string.Format("C.{0} L.{1} Q.{2}", CAS_NUMERO, CAS_LOTE, CAS_QUADRA); } }
  }

  public class dsRVT_REGISTRO_VISITAS : DefaultDataSource<RVT_REGISTRO_VISITAS>
  {
    public dsRVT_REGISTRO_VISITAS(Connection cnn)
      : base(cnn)
    { }

    public RVT_REGISTRO_VISITAS Get(int id)
    {
      cnn.QueryParam.Add(id);
      return Get("select * from RVT_REGISTRO_VISITAS where RVT_COSIGO = {0}");
    }

    public RVT_REGISTRO_VISITAS[] GetList_FromSincronizar()
    {
      return GetList("select * from RVT_REGISTRO_VISITAS where RVT_SINCRONIZAR = 1 and (RVT_STATUS is not null or RVT_STATUS <> '')", 0);
    }

    public RVT_REGISTRO_VISITAS[] GetList_FromUltimas()
    {
      return GetList(
        @"select * from RVT_REGISTRO_VISITAS
          INNER JOIN CAS_CASA ON CAS_CODIGO = RVT_CAS_CODIGO
          INNER JOIN MRD_MORADOR ON MRD_CODIGO = RVT_MRD_CODIGO
          order by RVT_CODIGO desc ", 100);
    }

    public override LockedField[] GetLockedFields(RVT_REGISTRO_VISITAS Tab)
    {
      List<LockedField> LockedFields = new List<LockedField>();

      if (Tab.RVT_NOME == "")
      { LockedFields.Add(new LockedField("RVT_NOME", " - Informe o campo Nome")); }

      if (Tab.RVT_TITULO == "")
      { LockedFields.Add(new LockedField("RVT_TITULO", " - Informe o campo Titulo/Parentesco")); }

      if (Tab.RVT_MRD_CODIGO == 0)
      { LockedFields.Add(new LockedField("RVT_MRD_CODIGO", " - Informe o campo Morador")); }

      return LockedFields.ToArray();
    }

    public bool Save(RVT_REGISTRO_VISITAS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      if (string.IsNullOrEmpty(Tab.RVT_HASHMD5))
      { Tab.RVT_HASHMD5 = lib.Class.Encryption.MD5_Hash(DateTime.Now.ToString("yyyyMMddHHmmss") + DateTime.Now.Millisecond + "_" + Guid.NewGuid()); }

      this.sb.Clear();
      this.sb.Table = "RVT_REGISTRO_VISITAS";
      this.sb.AddField("RVT_CAS_CODIGO", Tab.RVT_CAS_CODIGO);
      this.sb.AddField("RVT_MRD_CODIGO", Tab.RVT_MRD_CODIGO);
      this.sb.AddField("RVT_FOTO", Tab.RVT_FOTO);
      this.sb.AddField("RVT_DATA", Tab.RVT_DATA, enmFieldType.DateTime);
      this.sb.AddField("RVT_SINCRONIZAR", Tab.RVT_SINCRONIZAR);
      this.sb.AddField("RVT_NOME", Tab.RVT_NOME, 60);
      this.sb.AddField("RVT_TITULO", Tab.RVT_TITULO, 40);
      this.sb.AddField("RVT_EMAIL", Tab.RVT_EMAIL, 80);
      this.sb.AddField("RVT_TELEFONE", Tab.RVT_TELEFONE, 20);
      this.sb.AddField("RVT_VEICULO", Tab.RVT_VEICULO, 60);
      this.sb.AddField("RVT_PLACA", Tab.RVT_PLACA, 20);
      this.sb.AddField("RVT_DOCUMENTO", Tab.RVT_DOCUMENTO, 20);
      this.sb.AddField("RVT_STATUS", Tab.RVT_STATUS, 40);
      this.sb.AddField("RVT_ALTERACAO", DateTime.Now, enmFieldType.DateTime);
      this.sb.AddField("RVT_SINCRONIZAR", Tab.RVT_SINCRONIZAR);
      this.sb.AddField("RVT_HASHMD5", Tab.RVT_HASHMD5, 40);

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

    public bool Remove(int RVT_COSIGO)
    {
      this.sb.Clear();
      this.sb.Table = "RVT_REGISTRO_VISITAS";
      return this.cnn.Exec(this.sb.getDelete("where RVT_COSIGO = " + RVT_COSIGO));
    }
  }
}
