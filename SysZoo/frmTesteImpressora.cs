using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SysZoo
{
  public partial class frmTesteImpressora : frmBase
  {
    public frmTesteImpressora()
    {
      InitializeComponent();
    }





    private void TesteEpsonPrint()
    {
      EpsonCommand ec = new EpsonCommand();

      lib.Class.Conversion cnv = new lib.Class.Conversion();
      System.IO.Ports.SerialPort Serial = new System.IO.Ports.SerialPort(cmbPorta.Text, cnv.ToInt(txtVelocity.Text), System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
      Serial.Open();
      Serial.WriteLine("BEGIN");
      Serial.WriteLine(ec.ExtOn() + "EXTENDED" + ec.ExtOff());
      Serial.WriteLine("NORMAL");
      Serial.WriteLine(ec.BlackOn() + "BLACK" + ec.BlackOff());
      Serial.WriteLine("NORMAL");
      Serial.WriteLine(ec.ExtOn() + ec.BlackOn() + "EXTENDED BLACK" + ec.ExtOff() + ec.BlackOff());
      Serial.WriteLine("END");
      Serial.WriteLine(" ");
      Serial.WriteLine(" ");
      Serial.Close();
    }

    private void btnPagamento_Click(object sender, EventArgs e)
    {
      lib.Class.Conversion cnv = new lib.Class.Conversion();
      Utilities.ImprimeTicket(
        new SZO_VTK_VENDA_TICKETS[]{
          new SZO_VTK_VENDA_TICKETS(){VTK_DESCRICAO="INTEIRA", VTK_VALOR=10},
          new SZO_VTK_VENDA_TICKETS(){VTK_DESCRICAO="INTEIRA", VTK_VALOR=10},
          new SZO_VTK_VENDA_TICKETS(){VTK_DESCRICAO="MEIA", VTK_VALOR=5}
        },
        new SZO_CTK_CADASTRO_TICKETS[] 
        { 
          new SZO_CTK_CADASTRO_TICKETS() { CTK_DESCRICAO = "INTEIRA", CTK_VALOR = 10 }, 
          new SZO_CTK_CADASTRO_TICKETS() { CTK_DESCRICAO = "MEIA", CTK_VALOR = 5 } 
        },
        cmbPorta.Text,
        cnv.ToInt(txtVelocity.Text), cbIndividual.Checked);
    }

    private void TesteImpressora_Load(object sender, EventArgs e)
    {
      Utilities.ProcuraPortas(cmbPorta);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      lib.Class.Conversion cnv = new lib.Class.Conversion();
      EpsonCommand pc = new EpsonCommand();
      
      List<string> Texto= new List<string>();
      Texto.Add("Teste guilhotina");
      Texto.Add(pc.Guillotine());

      Utilities.Imprimir(cmbPorta.Text, cnv.ToInt(txtVelocity.Text), Texto);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      lblInternet.BackColor = (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() ? Color.Green : Color.Red);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      lib.Class.Conversion cnv = new lib.Class.Conversion();
      EpsonCommand pc = new EpsonCommand();

      List<string> Texto = new List<string>();
      Texto.Add("Teste gaveta");
      Texto.Add(pc.Pulse());

      Utilities.Imprimir(cmbPorta.Text, cnv.ToInt(txtVelocity.Text), Texto);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      string animal = (new AnimalDay()).getAnimal(29, 12, 15);
    }
  }
}
