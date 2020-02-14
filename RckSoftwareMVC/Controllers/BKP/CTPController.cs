using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RckSoftwareMVC.Controllers
{
  public class CTPController : Controller
  {
    //
    // GET: /CTP/

    //const int Fuzo = -3;
    const string SessionName = "UserMorador";

    /*
    private lib.Database.Connection GetConnection()
    {
      lib.Database.Connection cnn = new lib.Database.Connection();
      cnn.Connect(lib.Database.Drivers.enmConnection.MySql, new lib.Database.Drivers.InfoConnection("187.45.196.220", "rcksoftware", "rcksoftware", "RCK6px2erjr"));
      return cnn;
    }
    */
    public ActionResult Index()
    {
      if (Session[SessionName] == null)
      { return RedirectToAction("Login"); }

      //return Listar();
      return View();
    }

    /*public ActionResult Hora() 
    {
      return View();
    }

    public ActionResult Listar()
    {
      if (Session[SessionName] == null)
      { return RedirectToAction("Login"); }

      lib.Database.Connection cnn = GetConnection();
      dsCTP_AUT_AUTORIZADOS ds = new dsCTP_AUT_AUTORIZADOS(cnn);
      CTP_AUT_AUTORIZADOS[] lst = ds.GetList_Ativos(((CTP_MRD_MORADOR)Session[SessionName]).CAS_HASHMD5);
      return View("Listar", lst);
    }

    public ActionResult Incluir()
    {
      if (Session[SessionName] == null)
      { return RedirectToAction("Login"); }

      return Editar(0);
    }

    public ActionResult Alterar(string id)
    {
      if (Session[SessionName] == null)
      { return RedirectToAction("Login"); }

      return Editar((new lib.Class.Conversion(id)).ToInt());
    }

    public ActionResult Editar(int id)
    {
      if (Session[SessionName] == null)
      { return RedirectToAction("Login"); }

      lib.Database.Connection cnn = GetConnection();
      dsCTP_AUT_AUTORIZADOS ds = new dsCTP_AUT_AUTORIZADOS(cnn);
      CTP_AUT_AUTORIZADOS aut = ds.Get(id);
      //aut.Titulos = ds.GetTitulos();
      return View("Editar", aut);
    }

    public bool FaltaPreencher(CTP_AUT_AUTORIZADOS aut)
    {
      string msg = "";
      lib.Database.Connection cnn = GetConnection();
      dsCTP_AUT_AUTORIZADOS ds = new dsCTP_AUT_AUTORIZADOS(cnn);
      lib.Class.LockedField[] lf = ds.GetLockedFields(aut);
      if (lf.Length != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "<br />"; }
        msg += string.Format("<p class='error'>Verifique os campos abaixo:<br />{0}</p>", xMsg);
      }

      ViewBag.msg = msg;
      return lf.Length != 0;
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult Editar(CTP_AUT_AUTORIZADOS aut)
    {
      if (Session[SessionName] == null)
      { return RedirectToAction("Login"); }

      if (FaltaPreencher(aut))
      {
        return View("Editar", aut);
      }
      else
      {
        lib.Database.Connection cnn = GetConnection();
        dsCTP_AUT_AUTORIZADOS ds = new dsCTP_AUT_AUTORIZADOS(cnn);
        aut.AUT_CAS_HASHMD5 = ((CTP_MRD_MORADOR)Session[SessionName]).CAS_HASHMD5;
        ds.Save(aut);
        return Listar();
      }
    }

    public ActionResult Remover(string id)
    {
      if (Session[SessionName] == null)
      { return RedirectToAction("Login"); }

      lib.Database.Connection cnn = GetConnection();
      dsCTP_AUT_AUTORIZADOS ds = new dsCTP_AUT_AUTORIZADOS(cnn);
      CTP_AUT_AUTORIZADOS aut = ds.Get((new lib.Class.Conversion(id)).ToInt());
      return View(aut);
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult Remover(int id)
    {
      if (Session[SessionName] == null)
      { return RedirectToAction("Login"); }

      lib.Database.Connection cnn = GetConnection();
      dsCTP_AUT_AUTORIZADOS ds = new dsCTP_AUT_AUTORIZADOS(cnn);
      ds.Remove(id);
      return Listar();
    }

    public ActionResult Login()
    {
      return View("Login");
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult Login(string Email, string Senha)
    {
      lib.Database.Connection cnn = GetConnection();
      dsCTP_MRD_MORADOR ds = new dsCTP_MRD_MORADOR(cnn);
      CTP_MRD_MORADOR mrd = ds.Get_FromEmailSenha(Email, Senha);
      if (mrd.MRD_CODIGO != 0)
      {
        Session[SessionName] = mrd;
        return Listar();
      }
      else
      {
        ViewBag.msg = "Login/senha inválidos";
        return Login();
      }
    }

    public ActionResult LogOff()
    {
      Session[SessionName] = null;
      return Login();
    }

    public ActionResult EnviarSenha()
    {
      return View();
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult EnviarSenha(string Email)
    {
      try
      {
        lib.Database.Connection cnn = GetConnection();
        dsCTP_MRD_MORADOR ds = new dsCTP_MRD_MORADOR(cnn);
        CTP_MRD_MORADOR mrd = ds.Get_FromEmail(Email);

        if (mrd.MRD_CODIGO == 0)
        { return Mensagem("Atenção", "Email não encontrado"); }
        else
        {
          lib.Class.Mail mail = lib.Class.WebUtils.GetMailDeveloper();
          mail.SendMail(string.Format("Para gravar uma nova senha <a href='http://www.rcksoftware.com.br/CTP/GravarSenha/{0}'>clique aqui</a>", mrd.MRD_HASHMD5), true, mrd.MRD_EMAIL, "Senha");
          return Mensagem("Sucesso!", "Email enviado com sucesso!");
        }
      }
      catch { return Mensagem("Erro", "Erro ao enviar senha"); }
    }

    public ActionResult GravarSenha(string id)
    {
      lib.Database.Connection cnn = GetConnection();
      dsCTP_MRD_MORADOR ds = new dsCTP_MRD_MORADOR(cnn);
      CTP_MRD_MORADOR mrd = ds.Get_FromMD5HASH(id);
      return View("GravarSenha", mrd);
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult GravarSenha(int id, string Senha)
    {
      lib.Database.Connection cnn = GetConnection();
      dsCTP_MRD_MORADOR ds = new dsCTP_MRD_MORADOR(cnn);
      CTP_MRD_MORADOR mrd = ds.Get(id);
      mrd.MRD_SENHA = Senha;
      ds.Save(mrd);
      return Login();
    }

    public ActionResult Mensagem(string h, string msg)
    {
      ViewBag.h = h;
      ViewBag.msg = msg;
      return View("Mensagem");
    }

    public ActionResult Liberar(string id)
    {
      return Mensagem("Acesso Liberado", "Você confirmou a liberação de acesso para o Visitante");
    }

    public ActionResult ListarUsuario()
    {
      lib.Database.Connection cnn = GetConnection();
      dsCTP_USR_USERS ds = new dsCTP_USR_USERS(cnn);
      CTP_USR_USERS[] lst = ds.GetList();
      return View("ListarUsuario", lst);
    }

    public ActionResult IncluirUsuario(string id)
    {
      lib.Class.Conversion cnv = new lib.Class.Conversion();
      lib.Database.Connection cnn = GetConnection();
      dsCTP_USR_USERS ds = new dsCTP_USR_USERS(cnn);
      CTP_USR_USERS usr = ds.Get(cnv.ToInt(id));
      return View("IncluirUsuario", usr);
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult IncluirUsuario(CTP_USR_USERS usr)
    {
      lib.Database.Connection cnn = GetConnection();
      dsCTP_USR_USERS ds = new dsCTP_USR_USERS(cnn);
      usr.USR_KEY = lib.Class.Encryption.GetMD5(usr.USR_NOME);
      ds.Save(usr);
      return ListarUsuario();
    }

    public ActionResult RemoverUsuario(string id)
    {
      lib.Class.Conversion cnv = new lib.Class.Conversion();
      lib.Database.Connection cnn = GetConnection();
      dsCTP_USR_USERS ds = new dsCTP_USR_USERS(cnn);
      ds.Remove(cnv.ToInt(id));
      return ListarUsuario();
    }

    public ActionResult AdicionaMorador(string json) 
    {
      lib.Class.JSON Json = new lib.Class.JSON();
      CTP_MRD_MORADOR mrd = Json.Deserialize<CTP_MRD_MORADOR>(json);
      Json.AdjustTimeZone(mrd);
      lib.Database.Connection cnn = GetConnection();
      dsCTP_MRD_MORADOR dsMrd = new dsCTP_MRD_MORADOR(cnn);
      mrd.MRD_CODIGO = dsMrd.Get_FromMD5HASH(mrd.MRD_HASHMD5).MRD_CODIGO;
      dsMrd.Save(mrd);
      return Content("ok", "application/json");
    }

    public ActionResult AdicionaAutorizados(string json)
    {
      lib.Class.JSON Json = new lib.Class.JSON();
      CTP_AUT_AUTORIZADOS aut = Json.Deserialize<CTP_AUT_AUTORIZADOS>(json);
      Json.AdjustTimeZone(aut);
      lib.Database.Connection cnn = GetConnection();
      dsCTP_AUT_AUTORIZADOS dsAut = new dsCTP_AUT_AUTORIZADOS(cnn);
      aut.AUT_CODIGO = dsAut.Get_FromMD5HASH(aut.AUT_HASHMD5).AUT_CODIGO;
      dsAut.Save(aut);
      return Content("ok", "application/json");
    }

    public ActionResult AdicionaRegistroVisita(string json)
    {
      lib.Class.JSON Json = new lib.Class.JSON();
      CTP_RVT_REGISTRO_VISITAS rvt = Json.Deserialize<CTP_RVT_REGISTRO_VISITAS>(json);
      Json.AdjustTimeZone(rvt);
      lib.Database.Connection cnn = GetConnection();
      dsCTP_RVT_REGISTRO_VISITAS dsRvt = new dsCTP_RVT_REGISTRO_VISITAS(cnn);
      CTP_RVT_REGISTRO_VISITAS RvtBanco =dsRvt.Get_FromMD5HASH(rvt.RVT_HASHMD5);
      rvt.RVT_CODIGO = RvtBanco.RVT_CODIGO;
      
      if (!string.IsNullOrEmpty(RvtBanco.RVT_STATUS) && string.IsNullOrEmpty(rvt.RVT_STATUS))
      { rvt.RVT_STATUS = RvtBanco.RVT_STATUS; }

      dsRvt.Save(rvt);
      return Content("ok", "application/json");
    }

    public ActionResult RetornaAutorizados(DateTime AUT_ALTERACAO)
    {
      lib.Class.JSON json = new lib.Class.JSON();
      lib.Database.Connection cnn = GetConnection();
      dsCTP_AUT_AUTORIZADOS dsAut = new dsCTP_AUT_AUTORIZADOS(cnn);
      return Content(json.Serialize(dsAut.GetList_FromAlteracao(AUT_ALTERACAO)),"application/json");
    }

    public ActionResult RetornaMoradores(DateTime MRD_ALTERACAO)
    {
      lib.Class.JSON json = new lib.Class.JSON();
      lib.Database.Connection cnn = GetConnection();
      dsCTP_MRD_MORADOR dsMrd = new dsCTP_MRD_MORADOR(cnn);
      return Content(json.Serialize(dsMrd.GetList_FromAlteracao(MRD_ALTERACAO)), "application/json");
    }

    public ActionResult Autorizar(string id, string titulo) 
    {
      ViewBag.id = id;
      ViewBag.titulo = titulo;

      lib.Database.Connection cnn = GetConnection();
      dsCTP_RVT_REGISTRO_VISITAS dsRvt = new dsCTP_RVT_REGISTRO_VISITAS(cnn);
      CTP_RVT_REGISTRO_VISITAS rvt = dsRvt.Get_FromMD5HASH(id);
      rvt.RVT_STATUS = "AUTORIZADO";
      rvt.RVT_HASHMD5 = id;
      dsRvt.Save(rvt);

      return View(); 
    }

    public ActionResult Negar(string id, string titulo) 
    {
      ViewBag.id = id;
      ViewBag.titulo = titulo;

      lib.Database.Connection cnn = GetConnection();
      dsCTP_RVT_REGISTRO_VISITAS dsRvt = new dsCTP_RVT_REGISTRO_VISITAS(cnn);
      CTP_RVT_REGISTRO_VISITAS rvt = dsRvt.Get_FromMD5HASH(id);
      rvt.RVT_STATUS = "NEGADO";
      rvt.RVT_HASHMD5 = id;
      dsRvt.Save(rvt);

      return View(); 
    }

    public ActionResult GetStatus(string id) 
    {
      lib.Database.Connection cnn = GetConnection();
      dsCTP_RVT_REGISTRO_VISITAS dsRvt = new dsCTP_RVT_REGISTRO_VISITAS(cnn);
      return Content(dsRvt.Get_FromMD5HASH(id).RVT_STATUS, "application/json");
    }
    */
  }
}
