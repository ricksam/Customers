using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WsPhito
{
  public partial class _Default : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {      
      ExecutaMethod();
    }

    #region Exibe Resposta
    const string SUCCESS_MESSAGE = "successfully";

    private void ExibeResposta(object Resposta) 
    {
      Response.Write((new Classes.JSON()).Serialize(Resposta));
    }    
    #endregion

    #region private void ExecutaMethod()
    private void ExecutaMethod()
    {
      string method = Request.Form["method"];
      if (method == "add") { MethodAdd(); }
      else if (method == "list") { MethodList(); }
      else if (method == "listrejeitados") { MethodListRejeitados(); }
      else if (method == "get") { MethodGet(); }
      else if (method == "getnext") { MethodGetNext(); }
      else if (method == "iniciaratendimento") { MethodIniciarAtendimento(); }
      else if (method == "finalizaratendimento") { MethodFinalizarAtendimento(); }
      else if (method == "exibepainel") { MethodExibePainel(); }
      else if (method == "getusuario") { MethodGetUsuario(); }
      else
      {
        Response.Write("invalid method <br />");

        try
        {
          lib.Database.Connection cnn = Classes.Utilities.GetDbPhitoConnection();
          Response.Write("Banco conectado <br />");
          Response.Write(string.Format("AbsolutePath:{0} <br />", Request.Url.AbsolutePath));
          Response.Write(string.Format("AbsoluteUri:{0} <br />", Request.Url.AbsoluteUri));
          Response.Write(string.Format("Authority:{0} <br />", Request.Url.Authority));
        }
        catch (Exception ex)
        { ExibeResposta("DbError:" + ex.Message); }
      }
    }
    #endregion

    #region private void MethodAdd()
    /// <summary>
    /// adiciona ou gera senha para atendimento
    /// entrada: loja, assunto, preferencial, [senha]
    /// retorno: senha
    /// </summary>
    private void MethodAdd() 
    {
      lib.Class.Conversion cnv = new lib.Class.Conversion();

      string loja = Request.Form["loja"];
      string assunto = Request.Form["assunto"];
      string preferencial = Request.Form["preferencial"];
      string senha = Request.Form["senha"];

      ATD_ATENDIMENTO atd = new ATD_ATENDIMENTO();
      atd.ATD_ABERTURA = DateTime.Now;
      atd.ATD_LOJA = loja;
      atd.ATD_ASSUNTO = assunto;
      atd.ATD_SENHA = senha;
      atd.ATD_PREFERENCIAL = cnv.ToBool(preferencial);

      lib.Database.Connection cnn = Classes.Utilities.GetDbPhitoConnection();

      try
      {
        cnn.BeginTransaction();

        dsATD_ATENDIMENTO dsAtd = new dsATD_ATENDIMENTO(cnn);
        dsAtd.Save(atd);

        if (string.IsNullOrEmpty(atd.ATD_SENHA))
        {
          atd.ATD_SENHA = string.Format("SN{0}", atd.ATD_CODIGO.ToString("000000"));
          dsAtd.Save(atd);
        }

        cnn.CommitTransaction();

        RetornoRecepcao ret = new RetornoRecepcao();
        ret.Senha = atd.ATD_SENHA;
        ret.TempoEspera = dsAtd.GetTempoEspera();
        ExibeResposta(ret);
      }
      catch 
      {
        cnn.RollbackTransaction();
        throw;
      }
    }
    #endregion

    #region private void MethodList()
    /// <summary>
    /// lista atendimentos pendentes por assunto
    /// entrada: loja
    /// retorno: lista de assuntos com total pendente
    /// </summary>
    private void MethodList()
    {
      string loja = Request.Form["loja"];      
      dsATD_ATENDIMENTO dsAtd = new dsATD_ATENDIMENTO(Classes.Utilities.GetDbPhitoConnection());
      ExibeResposta(dsAtd.GetListAssunto(loja));
    }
    #endregion

    #region private void MethodGetNext()
    /// <summary>
    /// Retorna informações do proximo atendimento por assunto 
    /// entrada: loja, assunto 
    /// retorno: próximo atendimento do assunto priorizando atendimentos preferenciais
    /// </summary>
    private void MethodGetNext() 
    {
      string loja = Request.Form["loja"];
      string assunto = Request.Form["assunto"];
      ExibeResposta((new dsATD_ATENDIMENTO(Classes.Utilities.GetDbPhitoConnection())).GetNext(loja, assunto));
    }
    #endregion

    #region private void MethodGet()
    /// <summary>
    /// Retorna informações do atendimento
    /// entrada: código do atendimento
    /// retorno: dados do atendimento
    /// </summary>
    private void MethodGet() 
    {
      string codigo = Request.Form["codigo"];
      int iCodigo = (new lib.Class.Conversion()).ToInt(codigo);
      ExibeResposta((new dsATD_ATENDIMENTO(Classes.Utilities.GetDbPhitoConnection())).Get(iCodigo));
    }
    #endregion

    #region private void MethodListRejeitados()
    /// <summary>
    /// Lista ultimos atendimentos pulados no dia
    /// </summary>
    private void MethodListRejeitados() 
    {
      string loja = Request.Form["loja"];
      dsATD_ATENDIMENTO dsAtd = new dsATD_ATENDIMENTO(Classes.Utilities.GetDbPhitoConnection());
      ExibeResposta(dsAtd.GetListRejeitados(loja));
    }
    #endregion

    #region private void MethodIniciarAtendimento()
    /// <summary>
    /// Inicia atendimento em um guiche
    /// entrada: codigo do atendimento, nr guiche
    /// </summary>
    private void MethodIniciarAtendimento() 
    {
      string codigo = Request.Form["codigo"];
      string guiche = Request.Form["guiche"];

      lib.Class.Conversion cnv = new lib.Class.Conversion();
      int iCodigo = cnv.ToInt(codigo);
      int iGuiche = cnv.ToInt(guiche);

      dsATD_ATENDIMENTO dsAtd = new dsATD_ATENDIMENTO(Classes.Utilities.GetDbPhitoConnection());
      ATD_ATENDIMENTO atd = dsAtd.Get(iCodigo);

      atd.ATD_GUICHE = iGuiche;
      atd.ATD_INICIO = DateTime.Now;
      dsAtd.Save(atd);

      ExibeResposta(SUCCESS_MESSAGE);
    }
    #endregion

    #region private void MethodFinalizarAtendimento()
    /// <summary>
    /// encerra um atendimento podendo passar para o próximo atendimento
    /// entrada: codigo atendimento
    /// </summary>
    private void MethodFinalizarAtendimento() 
    {
      string codigo = Request.Form["codigo"];
      string concluido = Request.Form["concluido"];

      lib.Class.Conversion cnv = new lib.Class.Conversion();
      int iCodigo = cnv.ToInt(codigo);
      bool bConcluido = cnv.ToBool(concluido);

      dsATD_ATENDIMENTO dsAtd = new dsATD_ATENDIMENTO(Classes.Utilities.GetDbPhitoConnection());
      ATD_ATENDIMENTO atd = dsAtd.Get(iCodigo);

      atd.ATD_FIM = DateTime.Now;
      atd.ATD_CONCLUIDO = bConcluido;
      dsAtd.Save(atd);

      ExibeResposta(SUCCESS_MESSAGE);
    }
    #endregion

    #region private void MethodExibePainel()
    /// <summary>
    /// exibe o proximo atendimento iniciado e uma lista dos ultimos atendimentos
    /// entrada: loja
    /// </summary>
    private void MethodExibePainel() 
    {
      string loja = Request.Form["loja"];
      dsATD_ATENDIMENTO dsAtd = new dsATD_ATENDIMENTO(Classes.Utilities.GetDbPhitoConnection());
      ExibeResposta(dsAtd.GetListIniciados(loja));
    }
    #endregion

    #region private void MethodGetUsuario()
    /// <summary>
    /// Recupera nome e foto do usuário de um determinado cartão
    /// entrada: código do cartão
    /// saída: usuario(nome e foto)
    /// </summary>
    private void MethodGetUsuario()
    {
      string senha = Request.Form["senha"];
      
      Classes.UserPhito User = new Classes.UserPhito();
      string DirFotos = Server.MapPath("") + "\\FOTOS\\";
      string[] files = System.IO.Directory.GetFiles(DirFotos, "*.jpg");

      string selFile = "";
      for (int i = 0; i < files.Length; i++)
      {
        string FileName = System.IO.Path.GetFileNameWithoutExtension(files[i]);
        if (FileName.StartsWith(senha + "-"))
        {
          selFile = FileName;
          break;
        }
      }


      if (!string.IsNullOrEmpty(selFile))
      {
        User.Nome = selFile.Remove(0, senha.Length + 1);
        
        string callback = Request.Url.AbsoluteUri;
        callback = callback.Remove(callback.Length - 12, 12);
        User.Foto = string.Format("{0}FOTOS/{1}.jpg", callback, selFile);
      }

      ExibeResposta(User);
    }
    #endregion
  }
}
