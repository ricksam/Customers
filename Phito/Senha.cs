using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phito
{
  public partial class Senha : Form
  {
    #region Constructor
    public Senha()
    {
      InitializeComponent();
    }
    #endregion

    #region Fields
    public string Assunto { get; set; }
    Config Config { get; set; }
    WsPhito.Service Service { get; set; }
    string msgErro = "Houve um problema na gravação. Verifique se possui conexão de internet";
    #endregion

    

    #region private void Carregar()
    private void Carregar()
    {
      Config = new Config();
      Config.Open();

      if (string.IsNullOrEmpty(Config.PortaImpressora))
      { lib.Visual.Msg.Warning("Ainda não foi configurado a porta da impressora!"); }

      Service = new WsPhito.Service(Config.WebService);
      txtSenha.Select();
    }
    #endregion

    #region private void Imprimir(string Senha, string Porta)
    private void Imprimir(WsPhito.RetornoRecepcao ret, string Porta)
    {
      try
      {
        if (!string.IsNullOrEmpty(Porta))
        {
          string h = new string(new char[] { ((char)10), ((char)13), ((char)14) });
          string eh = new string(new char[] { ((char)20), ((char)10), ((char)13) });
          string b = new string(new char[] { ((char)27), ((char)69) });
          string eb = new string(new char[] { ((char)27), ((char)70) });
          string bl = ((char)07).ToString();

          string arqprint = lib.Visual.Functions.GetDirAppCondig() + "\\OutputPrint";

          if (System.IO.File.Exists(arqprint))
          { System.IO.File.Delete(arqprint); }

          lib.Class.TextFile tf = new lib.Class.TextFile();
          tf.Open(lib.Class.enmOpenMode.Writing, arqprint);
          tf.WriteLine(b + "Senha:" + eb + " " + h + ret.Senha + eh);
          tf.WriteLine("Chegada:" + " " + DateTime.Now.ToString("HH:mm:ss"));

          if (ret.TempoEspera.TotalHoras != 0 || ret.TempoEspera.TotalMinutos != 0)
          { tf.WriteLine("Tempo Espera:" + " " + (ret.TempoEspera.TotalHoras != 0 ? ret.TempoEspera.TotalHoras + " hora(s)" : ret.TempoEspera.TotalMinutos + " minuto(s)")); }

          tf.WriteLine(" ");
          tf.WriteLine(" ");
          tf.WriteLine(" ");
          tf.WriteLine(" ");
          tf.WriteLine(" ");
          tf.WriteLine(" ");
          tf.WriteLine(" ");
          tf.WriteLine(" ");
          tf.WriteLine(" ");
          tf.Close();

          string Comando = string.Format("/c type \"{0}\" > {1}", arqprint, Porta);
          lib.Class.Instance.ExecProcess("cmd.exe", Comando, false);
        }
      }
      catch (Exception ex)
      { lib.Visual.Msg.Warning(ex.Message); }
    }
    #endregion

    #region Events
    private void btnNormal_Click(object sender, EventArgs e)
    {
      try
      {
        WsPhito.RetornoRecepcao  ret = Service.Add(Config.Loja, Assunto, false, txtSenha.Text);
        Imprimir(ret, Config.PortaImpressora);
        this.Close();
      }
      catch
      { lib.Visual.Msg.Warning(msgErro); }
    }

    private void btnPreferencial_Click(object sender, EventArgs e)
    {
      try
      {
        WsPhito.RetornoRecepcao ret = Service.Add(Config.Loja, Assunto, true, txtSenha.Text);
        Imprimir(ret, Config.PortaImpressora);
        this.Close();
      }
      catch
      { lib.Visual.Msg.Warning(msgErro); }
    }

    private void Senha_Load(object sender, EventArgs e)
    {
      Carregar();
    }
    #endregion

    private void txtSenha_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { SendKeys.Send("{TAB}"); }
    }
  }
}
