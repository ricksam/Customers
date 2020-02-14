using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using lib.Database;
using lib.Database.MVC;
using lib.Database.Drivers;

namespace Folha_Marcelo
{
  public partial class CLB_COLABORADOR : DefaultEntity
  {
    public int CLB_CODIGO { get; set; }
    public int CLB_EMP_CODIGO { get; set; }
    public string CLB_NOME { get; set; }
    public string CLB_FONE { get; set; }
    public string CLB_RECADO { get; set; }
    public string CLB_LOGRADOURO { get; set; }
    public string CLB_NUMERO { get; set; }
    public string CLB_BAIRRO { get; set; }
    public string CLB_CIDADE { get; set; }
    public string CLB_ESTADO { get; set; }
    public string CLB_CEP { get; set; }
    public string CLB_OBS { get; set; }
    public string CLB_FOTO { get; set; }
    public decimal CLB_SALARIO { get; set; }
    public string CLB_CPF { get; set; }
    public string CLB_RG { get; set; }
    //public DateTime CLB_ADMISSAO { get; set; }
    //public DateTime CLB_DEMISSAO { get; set; }
    //public bool CLB_EXPERIENCIA { get; set; }
    //public DateTime CLB_TERMINO_EXPERIENCIA { get; set; }
    public bool CLB_INATIVO { get; set; }
    public DateTime CLB_DTNASC { get; set; }
  }
}
