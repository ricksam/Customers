using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Class;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace MagiaTrigo
{
  public partial class dsNTI_ITENS : DefaultDataSource<NTI_ITENS>
  {
    public dsNTI_ITENS(Connection cnn)
      : base(cnn)
    { }

    public NTI_ITENS Get(int id)
    {
      return Get("select * from NTI_ITENS where NTI_CODIGO = " + id.ToString());
    }

    public bool Save(NTI_ITENS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "NTI_ITENS";
      this.sb.AddField("NTI_NTF_CODIGO", Tab.NTI_NTF_CODIGO);
      this.sb.AddField("NTI_PRO_CODIGO", Tab.NTI_PRO_CODIGO);

      bool Gravou = false;
      if (Tab.NTI_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.NTI_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where NTI_CODIGO = " + Tab.NTI_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int NTI_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "NTI_ITENS";
      return this.cnn.Exec(this.sb.getDelete("where NTI_CODIGO = " + NTI_CODIGO));
    }
  }
}
