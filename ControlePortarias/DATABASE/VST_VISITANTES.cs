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
  public partial class VST_VISITANTES : DefaultEntity
  {
    public int VST_CODIGO { get; set; }
    public string VST_TABELA { get; set; }
    public string VST_NOME { get; set; }
    public string VST_TITULO { get; set; }
    public string VST_EMAIL { get; set; }
    public string VST_TELEFONE { get; set; }
    public string VST_VEICULO { get; set; }
    public string VST_PLACA { get; set; }
    public string VST_DOCUMENTO { get; set; }
  }

  public partial class dsVST_VISITANTES : DefaultDataSource<VST_VISITANTES>
  {
    public dsVST_VISITANTES(Connection cnn)
      : base(cnn)
    { }

    public VST_VISITANTES Get(int id)
    {
      return Get("select * from VST_VISITANTES where VST_CODIGO = " + id.ToString());
    }

    public VST_VISITANTES Get_FromDocumento(string VST_DOCUMENTO)
    {
      cnn.QueryParam.Add(VST_DOCUMENTO);
      return Get(string.Format("select * from VST_VISITANTES where VST_DOCUMENTO = {0}"));
    }

    public string[] GetList_Titulo() 
    {
      System.Data.DataTable dt = cnn.GetDataTable(
        @"SELECT VST_TITULO FROM VST_VISITANTES
        GROUP BY VST_TITULO");

      string[] Titulos = new string[dt.Rows.Count];
      for (int i = 0; i < dt.Rows.Count; i++)
      { Titulos[i] = dt.Rows[i]["VST_TITULO"].ToString(); }
      return Titulos;
    }

    public VST_VISITANTES[] Search(string s)
    {
      this.cnn.QueryParam.Clear();
      this.cnn.QueryParam.Add("%" + s + "%");

      return GetList(
        @"SELECT * 
          FROM VST_VISITANTES
          WHERE 
             VST_TABELA LIKE {0} 
             or VST_NOME LIKE {0} 
             or VST_TITULO LIKE {0} 
             or VST_EMAIL LIKE {0} 
             or VST_TELEFONE LIKE {0} 
             or VST_VEICULO LIKE {0} 
             or VST_PLACA LIKE {0} 
             or VST_DOCUMENTO LIKE {0} ", 200);
    }
  }
}
