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
  public partial class dsCON_CONTATOS : DefaultDataSource<CON_CONTATOS>
  {
    public dsCON_CONTATOS(Connection cnn)
      : base(cnn)
    { }

    public CON_CONTATOS Get(int id)
    {
      return Get("select * from CON_CONTATOS where CON_CODIGO = " + id.ToString());
    }

    public bool Save(CON_CONTATOS Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "CON_CONTATOS";
      this.sb.AddField("CON_NOME", Tab.CON_NOME, 60);
      this.sb.AddField("CON_EMAIL", Tab.CON_EMAIL, 200);
      this.sb.AddField("CON_TEL_RESIDENCIAL", Tab.CON_TEL_RESIDENCIAL, 20);
      this.sb.AddField("CON_TEL_CELULAR", Tab.CON_TEL_CELULAR, 20);
      this.sb.AddField("CON_TEL_COMERCIAL", Tab.CON_TEL_COMERCIAL, 20);
      this.sb.AddField("CON_TEL_FAX", Tab.CON_TEL_FAX, 20);
      this.sb.AddField("CON_LOGRADOURO", Tab.CON_LOGRADOURO, 20);
      this.sb.AddField("CON_NUMERO", Tab.CON_NUMERO, 20);
      this.sb.AddField("CON_BAIRRO", Tab.CON_BAIRRO, 20);
      this.sb.AddField("CON_CIDADE", Tab.CON_CIDADE, 20);
      this.sb.AddField("CON_CEP", Tab.CON_CEP, 20);

      bool Gravou = false;
      if (Tab.CON_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.CON_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where CON_CODIGO = " + Tab.CON_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int CON_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "CON_CONTATOS";
      return this.cnn.Exec(this.sb.getDelete("where CON_CODIGO = " + CON_CODIGO));
    }
  }
}
