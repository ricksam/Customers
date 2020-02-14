using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RckEventos
{
  public partial class Menu : lib.Visual.Models.frmBase
  {
    public Menu()
    {
      InitializeComponent();
    }

    bool Bloquear { get; set; }
    Config Config { get; set; }
    //System.Threading.Thread Processo { get; set; }

    #region private void Carregar()
    private void Carregar() 
    {
      Config = Utilities.OpenConfig();

      txtCaptionFotos.Text = Config.PhotoCaption;
      //txtDadosFB.Text = Config.Dados;
      txtDirFotos.Text = Config.DirFotos;
      cmbResolucao.Text = Config.Resolucao.ToString();

      //Processo = new System.Threading.Thread(new System.Threading.ThreadStart(ProcessaPosts));
      //Processo.Start();
    }
    #endregion

    private void ExibeLog(string s)
    {
      this.BeginInvoke((Action)delegate()
      {
        lstLog.Items.Add(s);
        lstLog.SelectedIndex = lstLog.Items.Count - 1;
        if (lstLog.Items.Count > 10)
        { lstLog.Items.RemoveAt(0); }
      });
    }

    #region private void ProcessaPosts()
    /*
    private void ProcessaPosts() 
    {

      while (true) 
      {
        try
        {
          if (Bloquear)
          { break; }

          while (Utilities.Mensagens.Count > 0)
          {
            try
            {
              if (Bloquear)
              { break; }

              ExibeLog("Postando Mensagem:" + Utilities.Mensagens[0]);
              ExibeLog(Utilities.PostMessage(Config.Token, Utilities.Mensagens[0]));
              Utilities.Mensagens.RemoveAt(0);
            }
            catch { break; }
          }

          for (int i = 0; i < Utilities.Fotos.Count; i++)
          {
            if (Config.Resolucao == 0)
            { continue; }

            try
            {
              ExibeLog("Postando Fotos:" + Utilities.Fotos[i].PathImage);
              Image img = Image.FromFile(Utilities.Fotos[i].PathImage);
              int Perc = Config.Resolucao * 100 / img.Height;
              img = lib.Class.ProcessImage.ResizeImage(img, Perc);

              string code = Utilities.Fotos[i].BarCode;
              string token = Utilities.GetToken(code);
              string response = Utilities.PostFoto(token, txtCaptionFotos.Text, img);

              Utilities.SaveWave(code,token,response);
              ExibeLog(response);

              Utilities.Fotos.RemoveAt(i);
              i--;
            }
            catch { continue; }
          }

          for (int i = 0; i < 30; i++)
          {
            if (Bloquear)
            { break; }

            System.Threading.Thread.Sleep(1000);
            ExibeLog("Aguardando : " + DateTime.Now.ToString("HH:mm:ss"));
          }
          
          ExibeLog("Salvando configurações");
          Utilities.SaveMensagens(Utilities.Mensagens);
          Utilities.SaveFotos(Utilities.Fotos);
        }
        catch
        { continue; }
      }
    }
          */ 
    #endregion

    #region Events
    private void button1_Click(object sender, EventArgs e)
    {
      //Mural f = new Mural(txtDirFotos.Text);
      //f.Show();
      Mural2 f = new Mural2(txtDirFotos.Text);
      f.Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (dlgFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      { txtDirFotos.Text = dlgFolder.SelectedPath; }
    }

    private void Menu_Load(object sender, EventArgs e)
    {      
      Carregar();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Mensagens f = new Mensagens();
      f.ShowDialog();
    }
    
    private void Menu_FormClosing(object sender, FormClosingEventArgs e)
    {
      Bloquear = true;
      //Processo.Interrupt();
      System.Threading.Thread.Sleep(100);
      //Processo = null;
    }
    #endregion

    private void button2_Click(object sender, EventArgs e)
    {
      Config.DirFotos = txtDirFotos.Text;
      Config.PhotoCaption = txtCaptionFotos.Text;
      Config.Resolucao = (new lib.Class.Conversion()).ToInt(cmbResolucao.SelectedItem);
      Utilities.SaveConfig(Config);
    }

    private void sknButton1_Click(object sender, EventArgs e)
    {
      EmailCobrança f = new EmailCobrança();
      f.ShowDialog();
    }
  }
}
