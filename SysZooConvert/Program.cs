using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SysZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                //ServerSZO.Server = "http://www.rcksoftware.com.br/SZO";
                //SZO_FPG_FORMA_PAGAMENTO[] listf = ServerSZO.RetornaFormasPagamento("0", "2001-01-01");
                //SZO_OPR_OPERADORES[] listo = ServerSZO.RetornaOperadores("0", "2001-01-01");
                //SZO_CTK_CADASTRO_TICKETS[] listi = ServerSZO.RetornaIngressos("0", "2001-01-01");
                
                //ServerSZO.Server = "http://localhost:8080/SZO";
                //SZO_FPG_FORMA_PAGAMENTO[] listf2 = ServerSZO.RetornaFormasPagamento("0", "2001-01-01");
                //SZO_OPR_OPERADORES[] listo2 = ServerSZO.RetornaOperadores("0", "2001-01-01");
                //SZO_CTK_CADASTRO_TICKETS[] listi2 = ServerSZO.RetornaIngressos("0", "2001-01-01");

                ServerSZO.Server = "http://www.ricksam.esy.es/SZO";
                ServerSZO.php = true;
                SZO_FPG_FORMA_PAGAMENTO[] listf = ServerSZO.RetornaFormasPagamento("0", "2001-01-01");
                SZO_OPR_OPERADORES[] listo = ServerSZO.RetornaOperadores("0", "2001-01-01");
                SZO_CTK_CADASTRO_TICKETS[] listi = ServerSZO.RetornaIngressos("0", "2001-01-01");
                bool ret = ServerSZO.EnviaKeepAlive("RICKSAM", "2.0");

                SZO_FPG_FORMA_PAGAMENTO forma = new SZO_FPG_FORMA_PAGAMENTO();
                forma.FPG_DESCRICAO = "Dinheiro";
                forma.FPG_INATIVO = false;
                ServerSZO.EnviaFormaPagamento("RICKSAM", forma);

                //SZO_OPR_OPERADORES operador = new SZO_OPR_OPERADORES();
                //ope
                //bool resp = ServerSZO.EnviaOperador("RICKSAM", item);
            }
            catch { }
            
            /*try
            {
                ServerSZO.Server = "http://www.rcksoftware.com.br/SZO";
                bool ret =ServerSZO.EnviaKeepAlive("RICKSAM", "2.0");

                ServerSZO.Server = "http://localhost:8080/SZO";
                bool ret2 = ServerSZO.EnviaKeepAlive("RICKSAM", "2.0");
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }*/

            /*try
            {
                ServerSZO.Server = "http://localhost:8080/SZO";
                SZO_FPG_FORMA_PAGAMENTO[] list = ServerSZO.RetornaFormasPagamento("0", "2001-01-01");
                string response = ServerSZO.Response;
                list[0].FPG_MD5 = "111";
                list[0].FPG_DESCRICAO += "*";
                ServerSZO.EnviaFormaPagamento("RICKSAM",list[0]);
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }*/

            /*try
            {
                ServerSZO.Server = "http://localhost:8080/SZO";
                SZO_OPR_OPERADORES[] list = ServerSZO.RetornaOperadores("0", "2001-01-01");
                foreach (var item in list)
                {
                    if (item.OPR_INATIVO)
                    {
                        string response = ServerSZO.Response;
                        list[0].OPR_MD5 = "111";
                        list[0].OPR_NOME += "*";
                        bool resp = ServerSZO.EnviaOperador("RICKSAM", item);
                    }
                }

            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }*/

            try
            {
                ServerSZO.Server = "http://localhost:8080/SZO";
                SZO_CTK_CADASTRO_TICKETS[] list = ServerSZO.RetornaIngressos("0", "2001-01-01");
                foreach (var item in list)
                {
                    if (item.CTK_INATIVO)
                    {
                        string response = ServerSZO.Response;
                        list[0].CTK_MD5 = "111";
                        list[0].CTK_DESCRICAO += "*";
                        bool resp = ServerSZO.EnviaIngresso("RICKSAM", item);
                    }
                }

            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
        }
    }
}
