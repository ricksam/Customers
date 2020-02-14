using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlePortarias
{
  public static class Service
  {
    static lib.Class.JSON json = new lib.Class.JSON();

    //public static string Server = "http://www.rcksoftware.com.br/CTP/";
    public static string Server = "http://localhost:25009/CTP/";
    public static string LastRequest = "";
    public static string LastArgs = "";
    public static string LastResponse = "";

    public static string Invoke(string Method, string Args)
    {
      LastRequest = Method;
      LastArgs = Args;
      LastResponse = lib.Class.WebUtils.GetWebResponse(Server + Method + "?" + Args, "", "application/x-www-form-urlencoded", Encoding.UTF8);
      return LastResponse;
    }

    public static void AdicionaRegistroVisita(CTP_RVT_REGISTRO_VISITAS rvt)
    {
      Invoke("AdicionaAutorizados", "json=" + json.Serialize(rvt));
      if (LastResponse != "ok")
      { throw new Exception(LastResponse); }
    }

    public static void AdicionaAutorizados(CTP_AUT_AUTORIZADOS aut)
    {
      Invoke("AdicionaAutorizados", "json=" + json.Serialize(aut));
      if (LastResponse != "ok")
      { throw new Exception(LastResponse); }
    }

    public static void AdicionaMorador(CTP_MRD_MORADOR mrd)
    {
      Invoke("AdicionaMorador", "json=" + json.Serialize(mrd));
      if (LastResponse != "ok")
      { throw new Exception(LastResponse); }
    }

    public static CTP_AUT_AUTORIZADOS[] RetornaAutorizados(DateTime AUT_ALTERACAO)
    {
      CTP_AUT_AUTORIZADOS[] lst = json.Deserialize<CTP_AUT_AUTORIZADOS[]>(Invoke("RetornaAutorizados", "AUT_ALTERACAO=" + AUT_ALTERACAO.ToString("yyyy-MM-dd HH:mm:ss")));
      for (int i = 0; i < lst.Length; i++)
      { json.AdjustTimeZone(lst[i]); }
      return lst;
    }

    public static CTP_MRD_MORADOR[] RetornaMoradores(DateTime MRD_ALTERACAO)
    {
      CTP_MRD_MORADOR[] lst = json.Deserialize<CTP_MRD_MORADOR[]>(Invoke("RetornaMoradores", "MRD_ALTERACAO=" + MRD_ALTERACAO.ToString("yyyy-MM-dd HH:mm:ss")));
      for (int i = 0; i < lst.Length; i++)
      { json.AdjustTimeZone(lst[i]); }
      return lst;
    }

    public static string GetStatus(string id) 
    {
      return Invoke("GetStatus/" + id, "");
    }
  }

  public partial class CTP_AUT_AUTORIZADOS 
  {
    //public int AUT_CODIGO { get; set; }
    public DateTime AUT_REGISTRO { get; set; }
    public DateTime AUT_ALTERACAO { get; set; }
    public string AUT_NOME { get; set; }
    public string AUT_TITULO { get; set; }
    public string AUT_EMAIL { get; set; }
    public string AUT_TELEFONE { get; set; }
    public string AUT_VEICULO { get; set; }
    public string AUT_PLACA { get; set; }
    public string AUT_DOCUMENTO { get; set; }
    public DateTime AUT_DATADE { get; set; }
    public DateTime AUT_DATAATE { get; set; }
    public bool AUT_PRE_AUTORIZADO { get; set; }
    public string AUT_HASHMD5 { get; set; }
    public string AUT_CAS_HASHMD5 { get; set; }
    public bool AUT_INATIVO { get; set; }
  }

  public partial class CTP_MRD_MORADOR 
  {
    //public int MRD_CODIGO { get; set; }
    public DateTime MRD_REGISTRO { get; set; }
    public DateTime MRD_ALTERACAO { get; set; }
    public string CAS_NUMERO { get; set; }
    public string CAS_LOTE { get; set; }
    public string CAS_QUADRA { get; set; }
    public string CAS_RAMAL { get; set; }
    public string CAS_HASHMD5 { get; set; }
    public string MRD_NOME { get; set; }
    public string MRD_FOTO { get; set; }
    public string MRD_TITULO { get; set; }
    public string MRD_EMAIL { get; set; }
    public string MRD_SENHA { get; set; }
    public string MRD_CELULAR { get; set; }
    public string MRD_EPC { get; set; }
    public string MRD_VEICULO { get; set; }
    public string MRD_PLACA { get; set; }
    public string MRD_OBS { get; set; }
    public bool MRD_PROPRIETARIO { get; set; }
    public string MRD_HASHMD5 { get; set; }
    public string MRD_USR_KEY { get; set; }
    public bool MRD_INATIVO { get; set; }
  }

  public partial class CTP_RVT_REGISTRO_VISITAS 
  {
    //public int RVT_CODIGO { get; set; }
    public string RVT_MRD_HASHMD5 { get; set; }
    public DateTime RVT_REGISTRO { get; set; }
    public DateTime RVT_ALTERACAO { get; set; }
    public string RVT_FOTO { get; set; }
    public DateTime RVT_DATA { get; set; }
    public string RVT_NOME { get; set; }
    public string RVT_TITULO { get; set; }
    public string RVT_EMAIL { get; set; }
    public string RVT_TELEFONE { get; set; }
    public string RVT_VEICULO { get; set; }
    public string RVT_PLACA { get; set; }
    public string RVT_DOCUMENTO { get; set; }
  }
}
