using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TestePrinter
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Execute(string Comando)
    {
      ProcessStartInfo ProcessInfo;

      //O Process é onde iremos ter o nosso processo com o comando passado sendo executado
      Process Process;

      //Inicia o ProcessStartInfo passando o programa a ser executado(cmd.exe) e os parametros
      //para esse programa, neste caso o mkdir
      //o /K é um parametro do prórpio cmd que executa o comando e deixa o prompt aberto
      //já o /C executa o comando e fecha o prompt
      ProcessInfo = new ProcessStartInfo("cmd.exe", Comando);

      //Esta configuração é feita para não criar a janela do prompt
      ProcessInfo.CreateNoWindow = true;
      ProcessInfo.UseShellExecute = true;

      //Inicia o processo passando o ProcessStartInfo
      Process = Process.Start(ProcessInfo);

      if (checkBox1.Checked)
      {
        // Aguarda encerramento
        Process.WaitForExit();
      }

      //termina imediatamente o processo
      //Process.Kill();

      //libera todos os recursos alocados para o processo
      Process.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string h = new string(new char[] { ((char)10), ((char)13), ((char)14) });
      string eh = new string(new char[] { ((char)20), ((char)10), ((char)13) });

      string b = new string(new char[] { ((char)27), ((char)69) });
      string eb = new string(new char[] { ((char)27), ((char)70) });

      string nl = "\r\n";

      string bl = ((char)07).ToString();

      lib.Class.TextFile tf = new lib.Class.TextFile();
      tf.Open(lib.Class.enmOpenMode.Writing, @"C:\Teste.bat");
      tf.WriteLine(h + "Titulo" + eh);
      tf.WriteLine(b + "Negrito" + eb);
      tf.WriteLine("nova linha:" + nl);
      tf.WriteLine("nova linha:" + nl);
      tf.WriteLine("nova linha:" + nl);
      tf.WriteLine("aviso:" + bl);
      tf.Write(((char)255).ToString() + ((char)01).ToString() + ((char)01).ToString());
      tf.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      { textBox1.Text = openFileDialog1.FileName; }
    }

    

    private void button3_Click(object sender, EventArgs e)
    {
      //string Comando = string.Format("/k type \"{0}\" > d:\\arnovo.rss", textBox1.Text);
      string Comando = string.Format("/c type \"{0}\" > lpt1", textBox1.Text);
      //Execute(Comando);
      lib.Class.Instance.ExecProcess("cmd.exe", Comando, true);
    }
  }
}
