using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RckEventos
{
  public static class Utilities
  {
    private static string ArqConfig = System.Windows.Forms.Application.StartupPath + "\\Config.json";
    private static string ArqMensagens = System.Windows.Forms.Application.StartupPath + "\\Mensagens.json";
    private static string ArqFotos = System.Windows.Forms.Application.StartupPath + "\\Fotos.json";
    private static string ArqWaves = System.Windows.Forms.Application.StartupPath + "\\Waves.txt";

    public static List<string> Mensagens { get; set; }
    public static List<FotoData> Fotos { get; set; }

    public static string GetToken(string code) 
    {
      return lib.Class.WebUtils.GetWebResponse("http://www.rcksoftware.com.br/Service.aspx?code=" + code);
    }
   
    public static void Start()
    {
      Mensagens = OpenMensagens();
      Fotos = OpenFotos();
    }
   
    public static void Stop()
    {
      SaveMensagens(Mensagens);
      SaveFotos(Fotos);
    }
   
    private static T OpenFile<T>(string file)
    {
      lib.Class.TextFile tf = new lib.Class.TextFile();
      try
      {
        lib.Class.JSON json = new lib.Class.JSON();
        tf.Open(lib.Class.enmOpenMode.Reading, file);
        return json.Deserialize<T>(tf.Read());
      }
      catch
      { return Activator.CreateInstance<T>(); }
      finally
      { tf.Close(); }
    }
   
    private static void SaveFile<T>(T Obj, string file)
    {
      lib.Class.TextFile tf = new lib.Class.TextFile();
      try
      {
        if (System.IO.File.Exists(file))
        { System.IO.File.Delete(file); }

        lib.Class.JSON json = new lib.Class.JSON();
        tf.Open(lib.Class.enmOpenMode.Writing, file);
        tf.Write(json.Serialize(Obj));
      }
      catch { return; }
      finally
      { tf.Close(); }
    }
   
    public static Config OpenConfig()
    {
      return OpenFile<Config>(ArqConfig);
    }

    public static void SaveConfig(Config cfg)
    {
      SaveFile<Config>(cfg, ArqConfig);
    }
   
    public static List<string> OpenMensagens()
    {
      return OpenFile<List<string>>(ArqMensagens);
    }

    public static void SaveMensagens(List<string> cfg)
    {
      SaveFile<List<string>>(cfg, ArqMensagens);
    }
   
    public static List<FotoData> OpenFotos()
    {
      return OpenFile<List<FotoData>>(ArqFotos);
    }

    public static void SaveFotos(List<FotoData> cfg)
    {
      SaveFile<List<FotoData>>(cfg, ArqFotos);
    }
   
    public static string PostMessage(string token, string Mensagem)
    {
      lib.Class.JSON json = new lib.Class.JSON();
      FbMessage m = new FbMessage();
      m.Message = Mensagem;
      string link = string.Format("http://www.rcksoftware.com.br/SocialPost/system/Post.aspx?type=facebook&token={0}&secret=&json={1}",
        token, json.Serialize(m));
      return lib.Class.WebUtils.GetWebResponse(link);
    }
   
    public static string PostFoto(string token, string caption, System.Drawing.Image bmp)
    {
      //string link = "http://localhost:13441/SocialPost/system/PostPhoto.aspx?type=facebook";
      string link = "http://www.rcksoftware.com.br/SocialPost/system/PostPhoto.aspx?type=facebook";
      StringBuilder sb = new StringBuilder();
      sb.Append("caption=" + caption);

      string strImage = lib.Class.ProcessImage.ImageToString(bmp);
      //sb.Append("&image="+strImage);
      
      do
      {
        int max_size = 20000;
        if (strImage.Length >= max_size)
        {
          sb.Append(string.Format("&image={0}", strImage.Substring(0, max_size)));
          strImage = strImage.Remove(0, max_size);
        }
        else
        {
          sb.Append(string.Format("&image={0}", strImage));
          strImage = "";
        }
      }
      while (!string.IsNullOrEmpty(strImage));

      sb.Append("&token=" + token);

      return lib.Class.WebUtils.GetWebResponse(link, sb.ToString());
    }
   
    public static void SaveWave(string Code, string Token, string Response)
    {
      lib.Class.TextFile tf = new lib.Class.TextFile();
      tf.Open(lib.Class.enmOpenMode.Writing, ArqWaves);
      tf.WriteLine(
        string.Format("{0} Code:{1} Token:{2} Response:{3}",
        DateTime.Now.ToString("dd/MM/yy HH:mm:ss"), Code, Token, Response)
      );
      tf.Close();
    }
  }

  public class FotoData
  {
    public bool Posted { get; set; }
    public string BarCode { get; set; }
    public string PathImage { get; set; }
  }
  
  public class FbMessage
  {
    public string Message { get; set; }
    public string Link { get; set; }
    public string Description { get; set; }
    public string Picture { get; set; }
    public string LikeID { get; set; }
    public bool PostImageOnFbUser { get; set; }
    public bool PostImageOnFbOwner { get; set; }
    public string ImageCaption { get; set; }
    public string ImageUid { get; set; }
    public string ImageAid { get; set; }
  }

}
