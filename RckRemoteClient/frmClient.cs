using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RckRemoteClient
{
  public partial class frmClient : Form
  {
    public frmClient()
    {
      InitializeComponent();
    }

    public bool Controlado = false;
    lib.Class.Conversion cnv = new lib.Class.Conversion();
    lib.Class.JSON json = new lib.Class.JSON();
    lib.Class.Sock.ClientSock Client = new lib.Class.Sock.ClientSock();

    protected override void OnKeyDown(KeyEventArgs e)
    {
      CallDesktop();
      base.OnKeyDown(e);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      try
      {
        timer1.Enabled = false;
        string dados = Client.Receive();

        if (dados!=null && dados.IndexOf("}{") != -1)
        { dados.Substring(0, dados.IndexOf("}{")); }
        
        Mensagem m = json.Deserialize<Mensagem>(dados);

        if (m != null)
        {
          if (m.Command == Command.YOURID)
          { txtSender.Text = m.Text; }

          if (m.Command == Command.CONTROL)
          {
            Controlado = true;
            btnControlar.Enabled = false;
            btnNaoControlar.Enabled = false;
            txtId.Text = m.Sender.ToString();
          }

          if (m.Command == Command.NOTCONTROL)
          {
            Controlado = false;
            btnControlar.Enabled = true;
          }

          if (m.Command == Command.DESK)
          { pictureBox1.Image = lib.Class.ProcessImage.StringToImage(m.Text); }

          if (m.Command == Command.CALLDESK)
          { EnviaDeskTop(); }
        }
      }
      catch { }
      finally { timer1.Enabled = true; }
    }

    private void frmClient_Load(object sender, EventArgs e)
    {
      Client.Start("127.0.0.1", 7425, "***", 256, System.Net.Sockets.ProtocolType.Tcp);
      timer1.Enabled = true;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      btnControlar.Enabled = false;
      btnNaoControlar.Enabled = true;
      Client.Send(json.Serialize(new Mensagem(cnv.ToInt(txtSender.Text), cnv.ToInt(txtId.Text), Command.CONTROL, "")));
    }

    private static System.Drawing.Imaging.ImageCodecInfo GetEncoderInfo(String mimeType)
    {
      int j;
      System.Drawing.Imaging.ImageCodecInfo[] encoders;
      encoders = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders();
      for (j = 0; j < encoders.Length; ++j)
      {
        if (encoders[j].MimeType == mimeType)
          return encoders[j];
      }
      return null;
    }
  

    private void EnviaDeskTop() 
    {
      Bitmap bmp = lib.Visual.Functions.GetDesktopImage();

      /*************************************/
      /******* converter para jpg **********/
      //System.Drawing.Imaging.ImageCodecInfo myImageCodecInfo = GetEncoderInfo("image/jpeg");
      //System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
      //System.Drawing.Imaging.EncoderParameters myEncoderParameters = new System.Drawing.Imaging.EncoderParameters(1);

      //System.Drawing.Imaging.EncoderParameter myEncoderParameter = new System.Drawing.Imaging.EncoderParameter(myEncoder, 25L);
      //myEncoderParameters.Param[0] = myEncoderParameter;
      //bmp.Save(@"d:\tmp\Shapes025.jpg", myImageCodecInfo, myEncoderParameters);
      /****************************************/


      Image img = lib.Class.ProcessImage.ResizeImage(bmp, 50);
      string ImageText = lib.Class.ProcessImage.ImageToString(img);
      Client.Send(json.Serialize(new Mensagem(cnv.ToInt(txtSender.Text), cnv.ToInt(txtId.Text), Command.DESK, ImageText)));
    } 

    private void btnNaoControlar_Click(object sender, EventArgs e)
    {
      btnControlar.Enabled = true;
      btnNaoControlar.Enabled = false;
      Client.Send(json.Serialize(new Mensagem(cnv.ToInt(txtSender.Text), cnv.ToInt(txtId.Text), Command.NOTCONTROL, "")));
    }

    private void button1_Click(object sender, EventArgs e)
    {
      
    }

    private void CallDesktop() 
    {
      Client.Send(json.Serialize(new Mensagem(cnv.ToInt(txtSender.Text), cnv.ToInt(txtId.Text), Command.CALLDESK, "")));
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
      CallDesktop();
    }
  }

  public enum Command{ YOURID, CONTROL, NOTCONTROL, CALLDESK, DESK } 
  public class Mensagem
  {
    public Mensagem() { }

    public Mensagem(int sender, int id, Command command, string text)
    {
      this.Sender = sender;
      this.Id = id;
      this.Command = command;
      this.Text = text;
    }

    public int Sender = 0;
    public int Id = 0;
    public Command Command;
    public string Text = "";
  }
}
