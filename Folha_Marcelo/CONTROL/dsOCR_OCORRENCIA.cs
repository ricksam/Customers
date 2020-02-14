using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Folha_Marcelo
{
  public partial class dsOCR_OCORRENCIA : DefaultDataSource<OCR_OCORRENCIA>
  {
    public dsOCR_OCORRENCIA(Connection cnn)
      : base(cnn)
    { }

    public OCR_OCORRENCIA Get(int id)
    {
      return Get("select * from OCR_OCORRENCIA where OCR_CODIGO = " + id.ToString());
    }

    public bool Save(OCR_OCORRENCIA Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "OCR_OCORRENCIA";
      this.sb.AddField("OCR_DESCRICAO", Tab.OCR_DESCRICAO, 40);
      this.sb.AddField("OCR_DIAS_ALERTA", Tab.OCR_DIAS_ALERTA);
      this.sb.AddField("OCR_DIAS_FINAL_ALERTA", Tab.OCR_DIAS_FINAL_ALERTA);
      this.sb.AddField("OCR_MENSAGEM_ALERTA", Tab.OCR_MENSAGEM_ALERTA, 100);

      bool Gravou = false;
      if (Tab.OCR_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.OCR_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where OCR_CODIGO = " + Tab.OCR_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int OCR_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "OCR_OCORRENCIA";
      return this.cnn.Exec(this.sb.getDelete("where OCR_CODIGO = " + OCR_CODIGO));
    }
  }
}
