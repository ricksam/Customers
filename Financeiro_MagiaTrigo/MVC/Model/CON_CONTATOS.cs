using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace MagiaTrigo
{
  public partial class CON_CONTATOS : DefaultEntity
  {
    public int CON_CODIGO { get; set; }
    public string CON_NOME { get; set; }
    public string CON_EMAIL { get; set; }
    public string CON_TEL_RESIDENCIAL { get; set; }
    public string CON_TEL_CELULAR { get; set; }
    public string CON_TEL_COMERCIAL { get; set; }
    public string CON_TEL_FAX { get; set; }
    public string CON_LOGRADOURO { get; set; }
    public string CON_NUMERO { get; set; }
    public string CON_BAIRRO { get; set; }
    public string CON_CIDADE { get; set; }
    public string CON_CEP { get; set; }
  }
}
