using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Folha_Marcelo
{
  public partial class CFG_CONFIG : DefaultEntity
  {          
    public string CFG_CAMPO_REMUNERACAO { get; set; }
    public string CFG_CAMPO_REMUNERACAO_TOTAL { get; set; }
    public string CFG_CAMPO_DESCONTO_TOTAL { get; set; }
    public string CFG_CAMPO_REMUNERACAO_LIQUIDA { get; set; }
    public string CFG_CAMPO_REFERENCIA { get; set; }
    public string CFG_ALERTA_ANIVERSARIO { get; set; }
    public string CFG_EMAIL_ALERTA { get; set; }
    public string CFG_OCORRENCIAS_AUTOMATICAS { get; set; }
  }
}
