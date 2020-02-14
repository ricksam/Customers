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
  public partial class dsBAL_BALANCO : DefaultDataSource<BAL_BALANCO>
  {
    public dsBAL_BALANCO(Connection cnn)
      : base(cnn)
    { }

    public BAL_BALANCO Get(int id)
    {
      return Get("select * from BAL_BALANCO where BAL_CODIGO = " + id.ToString());
    }
    
    public bool Save(BAL_BALANCO Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "BAL_BALANCO";
      this.sb.AddField("BAL_ANTERIOR", Tab.BAL_ANTERIOR);
      this.sb.AddField("BAL_EMP_CODIGO", Tab.BAL_EMP_CODIGO);
      this.sb.AddField("BAL_ESTOQUE_INICIAL", Tab.BAL_ESTOQUE_INICIAL);
      this.sb.AddField("BAL_ESTOQUE_FINAL", Tab.BAL_ESTOQUE_FINAL);
      this.sb.AddField("BAL_COMPRAS", Tab.BAL_COMPRAS);
      this.sb.AddField("BAL_CMV", Tab.BAL_CMV);
      this.sb.AddField("BAL_DATA", Tab.BAL_DATA, enmFieldType.Date);
      this.sb.AddField("BAL_INICIO", Tab.BAL_INICIO, enmFieldType.Date);      

      bool Gravou = false;
      if (Tab.BAL_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.BAL_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where BAL_CODIGO = " + Tab.BAL_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int BAL_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "BAL_BALANCO";
      return this.cnn.Exec(this.sb.getDelete("where BAL_CODIGO = " + BAL_CODIGO));
    }
  }
}
