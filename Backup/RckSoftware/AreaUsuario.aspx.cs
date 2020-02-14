using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RckSoftware
{
  public partial class AreaUsuario : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!Page.IsPostBack)
      {
        if (authentication_key == null)
        { Response.Redirect(Utilities.Callback() + "Login.aspx"); }
        else
        { Carregar(); }
      }
    }

    public string authentication_key
    {
      get
      {
        if (Session["authentication_key"] != null)
        { return Session["authentication_key"].ToString(); }
        else { return null; }
      }
      set { Session["authentication_key"] = value; }
    }

    private const string Service = "http://www.rcksoftware.com.br/app/security/service.php";
    private const string ListImage = "method=list_image&lastdate={0}&count={1}&code={2}&authenticate={3}&camera={4}";
    private const string DeleteImage = "method=delete_image&date={0}&authenticate={1}";
    private const string ListDate = "method=list_date&count={0}&authenticate={1}";
    private const string ListCameras = "method=list_cameras&authenticate={0}";
    private const string LastImage = "method=last_image&authenticate={0}";

    private void Carregar()
    {
      //txtAuthenticate.Value = authentication_key;
      string[] datas = (new JSON()).Deserialize<string[]>(lib.Class.WebUtils.GetWebResponse(Service, string.Format(ListDate, 1, authentication_key)));
      lstDatas.Items.Clear();
      for (int i = 0; i < datas.Length; i++)
      { lstDatas.Items.Add(datas[i]); }

      string[] cameras = (new JSON()).Deserialize<string[]>(lib.Class.WebUtils.GetWebResponse(Service, string.Format(ListCameras, authentication_key)));
      cmbCameras.Items.Clear();
      for (int i = 0; i < cameras.Length; i++)
      { cmbCameras.Items.Add(cameras[i]); }
    }

    private DataImage RetornaImagem(string lastdate, string code, string authenticate, string camera) 
    {
      string link = "http://www.rcksoftware.com.br/app/security/service.php";
      string postData = string.Format("method=list_image&lastdate={0}&count=1&code={1}&authenticate={2}&camera={3}", 
        lastdate, code, authenticate, camera);
      DataImage[] imgs = (new JSON()).Deserialize<DataImage[]>(lib.Class.WebUtils.GetWebResponse(link, postData));

      if (imgs.Length != 0)
      {
        lib.Class.Encryption enc = new lib.Class.Encryption(authenticate, "/9j4AQSkZJRgBEYD2wOxIPXFhHzMc8tLyUTldvWob3pm+naVfCG1K0iN6qe5r7us=");
        imgs[0].image = enc.Descrypt(imgs[0].image.Replace(" ", "+"));
        return imgs[0];
      }
      else
      { return null; }
    }

    private void AtualizaImagem() 
    {
      tmrUp.Enabled = false;
      DataImage img = RetornaImagem(lstDatas.Text, lblResp.Text, authentication_key, cmbCameras.Text);
      if (img != null)
      {
        if (lblResp.Text != img.id.ToString())
        {
          lblResp.Text = img.id.ToString();
          imgFoto.Src = string.Format("data:image/jpg;base64,{0}", img.image.Replace(" ", "+"));
        }
        else
        { lblResp.Text = "0"; }
      }
    }

    protected void btnExibir_Click(object sender, EventArgs e)
    {
      lblResp.Text = "0";
      AtualizaImagem();
      tmrUp.Enabled = true;
    }

    protected void tmrUp_Tick(object sender, EventArgs e)
    {
      AtualizaImagem();
      tmrUp.Enabled = true;
    }

    protected void lstDatas_SelectedIndexChanged(object sender, EventArgs e)
    {
      tmrUp.Enabled = false;
    }

    protected void cmbCameras_SelectedIndexChanged(object sender, EventArgs e)
    {
      tmrUp.Enabled = false;
    }

    protected void btnApagar_Click(object sender, EventArgs e)
    {
      tmrUp.Enabled = false;
      lib.Class.WebUtils.GetWebResponse(Service,string.Format(DeleteImage,lstDatas.Text,authentication_key));
      Carregar();
    }

    protected void btnInicio_Click(object sender, EventArgs e)
    {
      lblResp.Text = "0";
      AtualizaImagem();
    }

    protected void btnProxima_Click(object sender, EventArgs e)
    {
      AtualizaImagem();
    }
  }

  public class DataImage
  {
    public int id { get; set; }
    public string image { get; set; }
  }
}