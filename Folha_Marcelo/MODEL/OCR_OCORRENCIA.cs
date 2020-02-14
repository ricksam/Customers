using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Folha_Marcelo
{
  public partial class OCR_OCORRENCIA : DefaultEntity
  {
    public int OCR_CODIGO { get; set; }
    public string OCR_DESCRICAO { get; set; }
    public int OCR_DIAS_ALERTA { get; set; }
    public int OCR_DIAS_FINAL_ALERTA { get; set; }
    public string OCR_MENSAGEM_ALERTA { get; set; }    
  }
}
