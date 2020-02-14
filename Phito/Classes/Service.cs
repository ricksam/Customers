using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WsPhito
{
  public class Service
  {
    public Service(string link) 
    {
      this.linkService = link;
    }

    JSON json = new JSON();
    string linkService = "http://localhost/wsphito/Service.aspx";

    public T Invoke<T>(string method, string args)
    {
      string resp = lib.Class.WebUtils.GetWebResponse(linkService, string.Format("method={0}&{1}", method, args));
      return json.Deserialize<T>(resp);
    }

    public RetornoRecepcao Add (string loja, string assunto, bool preferencial, string senha)
    { return Invoke<RetornoRecepcao>("add", string.Format("loja={0}&assunto={1}&preferencial={2}&senha={3}", loja.ToUpper(), assunto.ToUpper(), preferencial, senha.ToUpper())); }

    public Assunto[] List(string loja)
    { return Invoke<Assunto[]>("list", string.Format("loja={0}", loja.ToUpper())); }

    public ATD_ATENDIMENTO GetNext(string loja, string assunto)
    { return Invoke<ATD_ATENDIMENTO>("getnext", string.Format("loja={0}&assunto={1}", loja.ToUpper(), assunto.ToUpper())); }

    public ATD_ATENDIMENTO Get(int codigo)
    { return Invoke<ATD_ATENDIMENTO>("getnext", string.Format("codigo={0}", codigo)); }

    public ATD_ATENDIMENTO[] ListRejeitados(string loja)
    { return Invoke<ATD_ATENDIMENTO[]>("listrejeitados", string.Format("loja={0}", loja.ToUpper())); }

    public void IniciarAtendimento(int codigo, int guiche)
    { Invoke<string>("iniciaratendimento", string.Format("codigo={0}&guiche={1}", codigo, guiche)); }

    public void FinalizarAtendimento(int codigo, bool concluido)
    { Invoke<string>("finalizaratendimento", string.Format("codigo={0}&concluido={1}", codigo, concluido)); }

    public ATD_ATENDIMENTO[] ExibePainel(string loja)
    { return Invoke<ATD_ATENDIMENTO[]>("exibepainel", string.Format("loja={0}", loja.ToUpper())); }

    public UserPhito GetUsuario(string cartao)
    { return Invoke<UserPhito>("getusuario", string.Format("senha={0}", cartao.ToUpper())); }
  }
}
