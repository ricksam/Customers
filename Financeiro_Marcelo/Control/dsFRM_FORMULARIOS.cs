using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Financeiro_Marcelo
{
  public partial class dsFRM_FORMULARIOS : DefaultDataSource<FRM_FORMULARIOS>
  {
    public dsFRM_FORMULARIOS(Connection cnn)
      : base(cnn)
    { }

    public FRM_FORMULARIOS Get(int id)
    {
      return Get("select * from FRM_FORMULARIOS where FRM_CODIGO = " + id.ToString());
    }
    
    public bool Save(FRM_FORMULARIOS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "FRM_FORMULARIOS";
      this.sb.AddField("FRM_NUMERO", Tab.FRM_NUMERO);
      this.sb.AddField("FRM_EMP_CODIGO", Tab.FRM_EMP_CODIGO);
      this.sb.AddField("FRM_DATA", Tab.FRM_DATA, enmFieldType.DateTime);
      this.sb.AddField("FRM_TROCOINICIAL", Tab.FRM_TROCOINICIAL);
      this.sb.AddField("FRM_TROCOFINAL", Tab.FRM_TROCOFINAL);
      this.sb.AddField("FRM_TOTRECEITAS", Tab.FRM_TOTRECEITAS);
      this.sb.AddField("FRM_TOTDESPESAS", Tab.FRM_TOTDESPESAS);
      this.sb.AddField("FRM_TOTCOMPRAS", Tab.FRM_TOTCOMPRAS);
      this.sb.AddField("FRM_BLOQUEADO", Tab.FRM_BLOQUEADO);
      this.sb.AddField("FRM_NUMERO_CLIENTES", Tab.FRM_NUMERO_CLIENTES);
      this.sb.AddField("FRM_VALOR_COMPARATIVO", Tab.FRM_VALOR_COMPARATIVO);
      this.sb.AddField("FRM_VALOR_CANCELADO", Tab.FRM_VALOR_CANCELADO);

      bool Gravou = false;
      if (Tab.FRM_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.FRM_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where FRM_CODIGO = " + Tab.FRM_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int FRM_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "FRM_FORMULARIOS";
      return this.cnn.Exec(this.sb.getDelete("where FRM_CODIGO = " + FRM_CODIGO));
    }
  }
}
