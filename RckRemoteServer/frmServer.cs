using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RckRemoteServer
{
  public partial class frmServer : Form
  {
    public frmServer()
    {
      InitializeComponent();
    }

    int IdClient = 0;
    bool ProcessoAtivo = false;
    lib.Class.JSON json = new lib.Class.JSON();
    lib.Class.Sock.ServerSock Server = new lib.Class.Sock.ServerSock();

    private void Conectar() 
    {
      button1.Enabled = false;
      Server.ReceiveClient += new lib.Class.Sock.ReceiveClient(ReceiveClient);
      Server.Start(txtIP.Text, 7425, "***",3600);
      tmrTimer.Enabled = true;
      ProcessoAtivo = true;
    } 

    private void button1_Click(object sender, EventArgs e)
    {
      Conectar();
    }

    private void ReceiveClient(lib.Class.Sock.VirtualClient Client)
    {
      IdClient ++;
      Client.ID = IdClient;
      Client.Send(json.Serialize(new Mensagem(0, 0, Command.YOURID, IdClient.ToString())));
    }

    private void tmrTimer_Tick(object sender, EventArgs e)
    {
      try
      {
        tmrTimer.Enabled = false;
        int clients = Server.ClientCount();
        
        for (int i = 0; i < clients; i++)
        {
          string dados = Server.Receive(i);
          if (!string.IsNullOrEmpty(dados))
          {
            try
            {
              if (dados != null && dados.IndexOf("}{") != -1)
              { dados = dados.Replace("}{","},{"); }

              dados = string.Format("[{0}]", dados);

              textBox1.Text = dados;
              Mensagem[] Retornos = json.Deserialize<Mensagem[]>(dados);
              for (int d = 0; d < Retornos.Length; d++)
              {
                lib.Class.Sock.VirtualClient Client = Server.GetClient(Retornos[d].Id);
                if (Client != null)
                { Client.Send(json.Serialize(Retornos[d])); }  
              }
              
            }
            catch { continue; }
          }
        }

        Server.CleanInactiveClients();
        Server.CleanLazyClients();
      }
      catch { }
      finally
      {
        if (ProcessoAtivo)
        { tmrTimer.Enabled = true; }
      }
    }

    private void frmServer_Load(object sender, EventArgs e)
    {
      //Conectar();
    }
  }

  public enum Command { YOURID, CONTROL, NOTCONTROL, CALLDESK, DESK }
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
