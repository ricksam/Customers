using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysZoo
{
    public static class ServerSZO
    {
        public static bool php = true;
        public static string Server = "http://www.ricksam.esy.es/SZO";
        //public static string Server = "http://www.rcksoftware.com.br/SZO";
        //const string Server = "http://localhost:25009/SZO";

        public static string Request = "";
        public static string PostData = "";
        public static string Response = "";

        private static string Invoke(string request, string postData = "")
        {
            Request = request;
            PostData = postData;
            Response = lib.Class.WebUtils.GetWebResponse(Request, PostData);
            return Response.Trim();
        }

        private static string ModelToArgs(object Model)
        {
            lib.Class.Conversion cnv = new lib.Class.Conversion();
            lib.Class.Reflection r = new lib.Class.Reflection(Model);

            string args = "";
            for (int i = 0; i < r.Properties.Length; i++)
            {
                if (r.Properties[i].PropertyType == typeof(DateTime)) {
                    args += (i == 0 ? "" : "&") + r.Properties[i].Name + "=" + cnv.ToDateTime( r.GetPropertyValue(r.Properties[i])).ToString("yyyy-MM-dd HH:mm:ss");
                }
                else
                {
                    args += (i == 0 ? "" : "&") + r.Properties[i].Name + "=" + r.GetPropertyValue(r.Properties[i]);
                }
            }

            return args;
        }

        public static SZO_FPG_FORMA_PAGAMENTO[] RetornaFormasPagamento(string id, string TimeStamp)
        {
            lib.Class.JSON json = new lib.Class.JSON();
            if (php)
            {
                return json.Deserialize<SZO_FPG_FORMA_PAGAMENTO[]>(Invoke(string.Format("{0}/RetornaFormasPagamento.php?Id={1}TimeStamp={2}", Server, id, TimeStamp)));
            }
            else
            {
                return json.Deserialize<SZO_FPG_FORMA_PAGAMENTO[]>(Invoke(string.Format("{0}/RetornaFormasPagamento/{1}?TimeStamp={2}", Server, id, TimeStamp)));
            }
        }

        public static SZO_OPR_OPERADORES[] RetornaOperadores(string id, string TimeStamp)
        {
            lib.Class.JSON json = new lib.Class.JSON();
            if (php)
            {
                return json.Deserialize<SZO_OPR_OPERADORES[]>(Invoke(string.Format("{0}/RetornaOperadores.php?Id={1}TimeStamp={2}", Server, id, TimeStamp)));
            }
            else
            {
                return json.Deserialize<SZO_OPR_OPERADORES[]>(Invoke(string.Format("{0}/RetornaOperadores/{1}?TimeStamp={2}", Server, id, TimeStamp)));
            }
        }

        public static SZO_CTK_CADASTRO_TICKETS[] RetornaIngressos(string id, string TimeStamp)
        {
            lib.Class.JSON json = new lib.Class.JSON();
            if (php)
            {
                return json.Deserialize<SZO_CTK_CADASTRO_TICKETS[]>(Invoke(string.Format("{0}/RetornaIngressos.php?Id={1}TimeStamp={2}", Server, id, TimeStamp)));
            }
            else
            {
                return json.Deserialize<SZO_CTK_CADASTRO_TICKETS[]>(Invoke(string.Format("{0}/RetornaIngressos/{1}?TimeStamp={2}", Server, id, TimeStamp)));
            }
        }

        public static bool EnviaKeepAlive(string id, string Versao)
        {
            lib.Class.Conversion cnv = new lib.Class.Conversion();
            if (php)
            {
                return cnv.ToBool(Invoke(string.Format("{0}/EnviaKeepAlive.php", Server), "Id=" + id + "&Versao=" + Versao));
            }
            return cnv.ToBool(Invoke(string.Format("{0}/EnviaKeepAlive", Server), "Id=" + id + "&Versao=" + Versao));
        }

        public static bool EnviaFormaPagamento(string id, SysZoo.SZO_FPG_FORMA_PAGAMENTO Forma)
        {
            lib.Class.Conversion cnv = new lib.Class.Conversion();
            if (php) {
                return cnv.ToInt(Invoke(string.Format("{0}/EnviaFormaPagamento.php", Server), "Id=" + id + "&" + ModelToArgs(Forma))) != 0;
            }
            return cnv.ToInt(Invoke(string.Format("{0}/EnviaFormaPagamento", Server), "Id=" + id + "&" + ModelToArgs(Forma))) != 0;
        }

        public static bool EnviaOperador(string id, SysZoo.SZO_OPR_OPERADORES Operador)
        {
            lib.Class.Conversion cnv = new lib.Class.Conversion();
            if (php)
            {
                return cnv.ToInt(Invoke(string.Format("{0}/EnviaOperador.php", Server), "Id=" + id + "&" + ModelToArgs(Operador))) != 0;
            }
            return cnv.ToInt(Invoke(string.Format("{0}/EnviaOperador", Server), "Id=" + id + "&" + ModelToArgs(Operador))) != 0;
        }

        public static bool EnviaIngresso(string id, SysZoo.SZO_CTK_CADASTRO_TICKETS Ingresso)
        {
            lib.Class.Conversion cnv = new lib.Class.Conversion();
            if (php)
            {
                return cnv.ToInt(Invoke(string.Format("{0}/EnviaIngresso.php", Server), "Id=" + id + "&" + ModelToArgs(Ingresso))) != 0;
            }
            return cnv.ToInt(Invoke(string.Format("{0}/EnviaIngresso", Server), "Id=" + id + "&" + ModelToArgs(Ingresso))) != 0;
        }

        public static bool EnviaVenda(string id, SysZoo.SZO_VDA_VENDA Venda)
        {
            lib.Class.Conversion cnv = new lib.Class.Conversion();
            if (php)
            {
                return cnv.ToInt(Invoke(string.Format("{0}/EnviaVenda.php", Server), "Id=" + id + "&" + ModelToArgs(Venda))) != 0;
            }
            return cnv.ToInt(Invoke(string.Format("{0}/EnviaVenda", Server), "Id=" + id + "&" + ModelToArgs(Venda))) != 0;
        }

        public static bool EnviaItem(string id, SysZoo.SZO_VTK_VENDA_TICKETS Item)
        {
            lib.Class.Conversion cnv = new lib.Class.Conversion();
            if (php)
            {
                return cnv.ToInt(Invoke(string.Format("{0}/EnviaItem.php", Server), "Id=" + id + "&" + ModelToArgs(Item))) != 0;
            }
            return cnv.ToInt(Invoke(string.Format("{0}/EnviaItem", Server), "Id=" + id + "&" + ModelToArgs(Item))) != 0;
        }

        public static bool EnviaPagamento(string id, SysZoo.SZO_PGT_PAGAMENTO Pagamento)
        {
            lib.Class.Conversion cnv = new lib.Class.Conversion();
            if (php)
            {
                return cnv.ToInt(Invoke(string.Format("{0}/EnviaPagamento.php", Server), "Id=" + id + "&" + ModelToArgs(Pagamento))) != 0;
            }
            return cnv.ToInt(Invoke(string.Format("{0}/EnviaPagamento", Server), "Id=" + id + "&" + ModelToArgs(Pagamento))) != 0;
        }

        public static bool EnviaMovimentoCaixa(string id, SysZoo.SZO_MCX_MOVIMENTO_CAIXA Movimento)
        {
            lib.Class.Conversion cnv = new lib.Class.Conversion();
            if (php)
            {
                return cnv.ToInt(Invoke(string.Format("{0}/EnviaMovimentoCaixa.php", Server), "Id=" + id + "&" + ModelToArgs(Movimento))) != 0;
            }
            return cnv.ToInt(Invoke(string.Format("{0}/EnviaMovimentoCaixa", Server), "Id=" + id + "&" + ModelToArgs(Movimento))) != 0;
        }
    }
    /*
  public static class ServerSZO
  {
    public static string Server = "http://www.rcksoftware.com.br/SZO";
    //const string Server = "http://localhost:25009/SZO";

    public static string Request = "";
    public static string PostData = "";
    public static string Response = "";

    private static string Invoke(string request, string postData = "") 
    {
      Request = request;
      PostData = postData;
      Response = lib.Class.WebUtils.GetWebResponse(Request,PostData);
      return Response;
    }

    private static string ModelToArgs(object Model) 
    {
      lib.Class.Reflection r = new lib.Class.Reflection(Model);

      string args = "";
      for (int i = 0; i < r.Properties.Length; i++)
      { args += (i == 0 ? "" : "&") + r.Properties[i].Name + "=" + r.GetPropertyValue(r.Properties[i]); }

      return args;
    }

    public static SZO_FPG_FORMA_PAGAMENTO[] RetornaFormasPagamento(string id, string TimeStamp)
    {
      lib.Class.JSON json = new lib.Class.JSON();
      return json.Deserialize<SZO_FPG_FORMA_PAGAMENTO[]>(Invoke(string.Format("{0}/RetornaFormasPagamento/{1}?TimeStamp={2}", Server, id, TimeStamp)));
    }

    public static SZO_OPR_OPERADORES[] RetornaOperadores(string id, string TimeStamp) 
    {
      lib.Class.JSON json = new lib.Class.JSON();
      return json.Deserialize<SZO_OPR_OPERADORES[]>(Invoke(string.Format("{0}/RetornaOperadores/{1}?TimeStamp={2}", Server, id, TimeStamp)));
    }

    public static SZO_CTK_CADASTRO_TICKETS[] RetornaIngressos(string id, string TimeStamp) 
    {
      lib.Class.JSON json = new lib.Class.JSON();
      return json.Deserialize<SZO_CTK_CADASTRO_TICKETS[]>(Invoke(string.Format("{0}/RetornaIngressos/{1}?TimeStamp={2}", Server, id, TimeStamp)));
    }

    public static bool EnviaKeepAlive(string id, string Versao)
    {
      lib.Class.Conversion cnv = new lib.Class.Conversion();
      //return cnv.ToInt(Invoke(string.Format("{0}/EnviaKeepAlive/{1}", Server, id), Versao)) != 0;
      return cnv.ToInt(Invoke(string.Format("{0}/EnviaKeepAlive/{1}", Server, id), "Versao="+Versao)) != 0;
      //return true;
    }

    public static bool EnviaFormaPagamento(string id, SysZoo.SZO_FPG_FORMA_PAGAMENTO Forma) 
    {
      lib.Class.Conversion cnv = new lib.Class.Conversion();
      return cnv.ToInt(Invoke(string.Format("{0}/EnviaFormaPagamento/{1}", Server, id), ModelToArgs(Forma))) != 0;
    }

    public static bool EnviaOperador(string id, SysZoo.SZO_OPR_OPERADORES Operador) 
    {
      lib.Class.Conversion cnv = new lib.Class.Conversion();
      return cnv.ToInt(Invoke(string.Format("{0}/EnviaOperador/{1}", Server, id), ModelToArgs(Operador))) != 0;
    }

    public static bool EnviaIngresso(string id, SysZoo.SZO_CTK_CADASTRO_TICKETS Ingresso) 
    {
      lib.Class.Conversion cnv = new lib.Class.Conversion();
      return cnv.ToInt(Invoke(string.Format("{0}/EnviaIngresso/{1}", Server, id), ModelToArgs(Ingresso))) != 0;
    }

    public static bool EnviaVenda(string id, SysZoo.SZO_VDA_VENDA Venda) 
    {
      lib.Class.Conversion cnv = new lib.Class.Conversion();
      return cnv.ToInt(Invoke(string.Format("{0}/EnviaVenda/{1}", Server, id), ModelToArgs(Venda))) != 0;
    }

    public static bool EnviaItem(string id, SysZoo.SZO_VTK_VENDA_TICKETS Item) 
    {
      lib.Class.Conversion cnv = new lib.Class.Conversion();
      return cnv.ToInt(Invoke(string.Format("{0}/EnviaItem/{1}", Server, id), ModelToArgs(Item))) != 0;
    }

    public static bool EnviaPagamento(string id, SysZoo.SZO_PGT_PAGAMENTO Pagamento) 
    {
      lib.Class.Conversion cnv = new lib.Class.Conversion();
      return cnv.ToInt(Invoke(string.Format("{0}/EnviaPagamento/{1}", Server, id), ModelToArgs(Pagamento))) != 0;
    }

    public static bool EnviaMovimentoCaixa(string id, SysZoo.SZO_MCX_MOVIMENTO_CAIXA Movimento) 
    {
      lib.Class.Conversion cnv = new lib.Class.Conversion();
      return cnv.ToInt(Invoke(string.Format("{0}/EnviaMovimentoCaixa/{1}", Server, id), ModelToArgs(Movimento))) != 0;
    }
  }
    */
}
