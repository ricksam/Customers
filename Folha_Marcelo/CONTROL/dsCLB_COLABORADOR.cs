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
  public partial class dsCLB_COLABORADOR : DefaultDataSource<CLB_COLABORADOR>
  {
    public dsCLB_COLABORADOR(Connection cnn)
      : base(cnn)
    { }

    public CLB_COLABORADOR Get(int id)
    {
      return Get("select * from CLB_COLABORADOR where CLB_CODIGO = " + id.ToString());
    }

    public bool Save(CLB_COLABORADOR Tab)
    {
      if (GetLockedFields(Tab).Length != 0)
      { return false; }

      this.sb.Clear();
      this.sb.Table = "CLB_COLABORADOR";
      this.sb.AddField("CLB_EMP_CODIGO", Tab.CLB_EMP_CODIGO);
      this.sb.AddField("CLB_NOME", Tab.CLB_NOME, 60);
      this.sb.AddField("CLB_FONE", Tab.CLB_FONE, 20);
      this.sb.AddField("CLB_RECADO", Tab.CLB_RECADO, 20);
      this.sb.AddField("CLB_LOGRADOURO", Tab.CLB_LOGRADOURO, 60);
      this.sb.AddField("CLB_NUMERO", Tab.CLB_NUMERO, 20);
      this.sb.AddField("CLB_BAIRRO", Tab.CLB_BAIRRO, 40);
      this.sb.AddField("CLB_CIDADE", Tab.CLB_CIDADE, 40);
      this.sb.AddField("CLB_ESTADO", Tab.CLB_ESTADO, 2);
      this.sb.AddField("CLB_CEP", Tab.CLB_CEP, 20);
      this.sb.AddField("CLB_OBS", Tab.CLB_OBS, 400);
      this.sb.AddField("CLB_FOTO", Tab.CLB_FOTO, 2147483647);
      this.sb.AddField("CLB_SALARIO", Tab.CLB_SALARIO);
      this.sb.AddField("CLB_CPF", Tab.CLB_CPF, 20);
      this.sb.AddField("CLB_RG", Tab.CLB_RG, 20);
      //this.sb.AddField("CLB_ADMISSAO", Tab.CLB_ADMISSAO, enmFieldType.DateTime);
      //this.sb.AddField("CLB_DEMISSAO", Tab.CLB_DEMISSAO, enmFieldType.DateTime);
      
      //this.sb.AddField("CLB_EXPERIENCIA", Tab.CLB_EXPERIENCIA);
      //this.sb.AddField("CLB_TERMINO_EXPERIENCIA", Tab.CLB_TERMINO_EXPERIENCIA, enmFieldType.DateTime);

      this.sb.AddField("CLB_DTNASC", Tab.CLB_DTNASC, enmFieldType.Date);
      this.sb.AddField("CLB_INATIVO", Tab.CLB_INATIVO);

      bool Gravou = false;
      if (Tab.CLB_CODIGO == 0)
      {
        Gravou = this.cnn.Exec(this.sb.getInsert());
        Tab.CLB_CODIGO = this.cnn.GetLastId().ToInt();
      }
      else
      { Gravou = this.cnn.Exec(this.sb.getUpdate("where CLB_CODIGO = " + Tab.CLB_CODIGO)); }

      return Gravou;
    }

    public bool Remove(int CLB_CODIGO)
    {
      this.sb.Clear();
      this.sb.Table = "CLB_COLABORADOR";
      return this.cnn.Exec(this.sb.getDelete("where CLB_CODIGO = " + CLB_CODIGO));
    }
  }
}
