using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestePostData
{
  public partial class SendGCM : Form
  {
    public SendGCM()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      AndroidGCMPushNotification server = new AndroidGCMPushNotification();
      textBox1.Text = server.SendNotification(txtRegistro.Text, "Olá Mundo");
    }
  }
}
