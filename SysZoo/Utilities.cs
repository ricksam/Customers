using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SysZoo
{
  public static class Utilities
  {
    public static lib.Entity.SQLite GetDatabase() 
    {
      string sc = string.Format("Data Source={0};Pooling=true;FailIfMissing=false", GetDirAppCondig()+"\\SysZoo.db");
      return new lib.Entity.SQLite(sc);
    }

    public static void VerificaScript()
    {
      lib.Entity.SQLite db = GetDatabase();
      lib.Entity.UpdateScript us = new lib.Entity.UpdateScript(GetDirAppCondig()+"\\Script.sql",db);
      us.Execute();
    }

    public static string GetDirAppCondig()
    {
      string Dir =
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" +
        Application.ProductName;

      if (!Directory.Exists(Dir))
      { Directory.CreateDirectory(Dir); }

      return Dir;
    }

    public static void MsgAlert(string alert) 
    {
      frmAlerta f = new frmAlerta();
      f.Carregar(alert);
      f.ShowDialog();
    }

    public static bool MsgQuestion(string question)
    {
      frmQuestion f = new frmQuestion();
      f.Carregar(question);
      return f.ShowDialog() == DialogResult.Yes;
    }

    public static string RetornaSenha() 
    {
      frmSenha f = new frmSenha();
      if (f.ShowDialog() == DialogResult.OK)
      { return f.Senha(); }
      return "";
    }

    public static SZO_OPR_OPERADORES RetornaOperador()
    {
      string senha = RetornaSenha();
      dsSZO_OPR_OPERADORES dsOpr = new dsSZO_OPR_OPERADORES(Utilities.GetDatabase());

      if (dsOpr.Count() == 0)
      { return new SZO_OPR_OPERADORES() { OPR_CANCELAR_CUPOM = true, OPR_CANCELAR_ITEM = true, OPR_GERENCIA = true }; }

      return dsOpr.Get_FromSenha(senha);
    }

    public static decimal RetornaValor() 
    {
      frmValor f = new frmValor();
      f.Titulo("Informe o Valor");
      if (f.ShowDialog() == DialogResult.OK)
      { return f.Valor(); }
      return 0;
    }

    public static int RetornaQtde()
    {
      frmValor f = new frmValor();
      f.Titulo("Informe a Quantidade");
      if (f.ShowDialog() == DialogResult.OK)
      { return (new lib.Class.Conversion()).ToInt(f.Valor()); }
      return 0;
    }

    public static void ProcuraPortas(ComboBox cmb)
    {
      try
      {
        string[] ports = System.IO.Ports.SerialPort.GetPortNames();
        cmb.Items.Clear();
        cmb.Items.AddRange(ports);

        if (cmb.Items.Count != 0)
        { cmb.SelectedIndex = 0; }
      }
      catch
      { cmb.Items.Clear(); }
    }

    private static string[] CabecalhoImpressao(EpsonCommand pc)
    {
      List<string> texto = new List<string>();
      texto.Add(pc.Center("Prefeitura Municipal de Sorocaba", 40));
      texto.Add(pc.Center("Parque Zoológico Municipal", 40));
      texto.Add(pc.Center("Quinzinho de Barros - PZMQB", 40));
      texto.Add("Emissao:" + DateTime.Now.ToString("dd/MM/yy HH:mm:ss"));
      texto.Add("----------------------------------------");
      return texto.ToArray();
    }

    private static string[] RodapeImpressao(EpsonCommand pc, string barcode)
    {
      List<string> texto = new List<string>();
      //texto.Add(pc.Barcode(barcode));
      texto.Add("----------------------------------------");
      texto.Add(pc.Center((new AnimalDay()).getAnimal(), 40));
      texto.Add("SysZoo - Atlantis".PadLeft(40));
      //for (int i = 0; i < 8; i++)
      //{ texto.Add(" "); }
      texto.Add(pc.Guillotine());
      texto.Add(pc.Pulse());
      return texto.ToArray();
    }

    public static void ImprimeFechamento(SZO_CFG_CONFIG Cfg, SZO_OPR_OPERADORES Operador) 
    {
      EpsonCommand pc = new EpsonCommand();
      List<string> texto = new List<string>();
      texto.Add("----------------------------------------");
      texto.AddRange(CabecalhoImpressao(pc));
      texto.Add(pc.Extended("Fechamento"));
      texto.Add("Operador: " + Operador.OPR_NOME); 
      texto.Add("Inicio: " + Cfg.CFG_MOVIMENTO.ToString("dd/MM/yy HH:mm:ss"));
      texto.Add("Fim   : " + DateTime.Now.ToString("dd/MM/yy HH:mm:ss"));
      texto.AddRange(RodapeImpressao(pc, Cfg.CFG_MOVIMENTO.ToString("yyMMddHHmm")));

      Imprimir(Cfg.CFG_PRINTER_PORT, Cfg.CFG_PRINTER_VELOCITY, texto);
    }

    public static void ImprimeMovimento(string Porta, int Velocidade, SZO_MCX_MOVIMENTO_CAIXA Mcx) 
    {
      try
      {
        EpsonCommand pc = new EpsonCommand();
        List<string> texto = new List<string>();
        texto.Add("----------------------------------------");
        texto.AddRange(CabecalhoImpressao(pc));
        texto.Add(pc.Extended(Mcx.MCX_TIPO));
        texto.Add("Valor:" + Mcx.MCX_VALOR.ToString("#,##0.00").PadLeft(34));
        for (int i = 0; i < 3; i++)
        { texto.Add(" "); }
        texto.Add("----------------------------------------");
        texto.Add("               Assinatura               ");
        texto.AddRange(RodapeImpressao(pc, Mcx.MCX_DATA.ToString("yyMMddHHmmss")));
        
        Imprimir(Porta, Velocidade, texto);
      }
      catch (Exception ex)
      { Utilities.MsgAlert(ex.Message); }
    }

    public static void ImprimeTicket(SZO_VTK_VENDA_TICKETS[] Itens, SZO_CTK_CADASTRO_TICKETS[] Tabela, string Porta, int Velocidade, bool Individual)
    {
      try
      {
        EpsonCommand pc = new EpsonCommand();
        List<string> texto = new List<string>();
        if (Individual) 
        {
          for (int i = 0; i < Itens.Length; i++)
          {
            texto.Add(pc.BlackOn() + "----------------------------------------" + pc.BlackOff());
            texto.AddRange(CabecalhoImpressao(pc));

            if (Itens[i].VTK_DESCRICAO.ToUpper().IndexOf("ISENT") != -1)
            { texto.Add(pc.Black(pc.Extended(Itens[i].VTK_DESCRICAO))); }
            else
            { texto.Add(pc.Extended(Itens[i].VTK_DESCRICAO)); }

            texto.Add("ticket:" + Itens[i].VTK_MD5);
            texto.Add("Item " + (i + 1).ToString("000") + ("Valor: " + Itens[i].VTK_VALOR.ToString("0.00")).PadLeft(32));

            if (Itens[i].VTK_DESCRICAO.ToUpper().IndexOf("ISENT") != -1)
            {
              texto.Add("Crianças até 5 anos completos");
              texto.Add("Alunos, professores e monitores das redes municipal e estadual de ensino público, com sede no município de Sorocaba, acompanhados pela escola");
              texto.Add("Pessoa com deficiência, garantindo-se ao seu acompanhante, quando necessário e quando comprove estar nessa condição");
              texto.Add("Participantes de instituições assistenciais, com atuação social, cultural e ambiental");
              texto.Add("Idosos com idade igual ou superior a 60 anos");
              texto.Add("Vedado: Entrada de menores de 14 anos desacompanhados de maiores de 18 anos");
            }

            texto.AddRange(RodapeImpressao(pc, Itens[i].VTK_DATA.ToString("yyMMddHHmmss")));
          }
        }
        else
        {
          texto.Add(pc.BlackOn() + "----------------------------------------" + pc.BlackOff());
          texto.AddRange(CabecalhoImpressao(pc));

          for (int i = 0; i < Itens.Length; i++)
          {
            if (Itens[i].VTK_DESCRICAO.ToUpper().IndexOf("ISENT") != -1)
            { texto.Add(pc.Black(pc.Extended(Itens[i].VTK_DESCRICAO))); }
            else
            { texto.Add(pc.Extended(Itens[i].VTK_DESCRICAO)); }

            texto.Add("ticket:" + Itens[i].VTK_MD5);
            texto.Add("Item " + (i + 1).ToString("000") + ("Valor: " + Itens[i].VTK_VALOR.ToString("0.00")).PadLeft(32));
            texto.Add("----------------------------------------");
          }

          if (Itens.Length != 0)
          {
            texto.AddRange(RodapeImpressao(pc, Itens[0].VTK_DATA.ToString("yyMMddHHmmss")));
          }
        }

        Imprimir(Porta, Velocidade, texto); 
      }
      catch (Exception ex)
      { Utilities.MsgAlert(ex.Message); }
    }

    public static void Imprimir(string Porta, int Velocidade, List<string> texto) 
    {
      if (!string.IsNullOrEmpty(Porta))
      {
        lib.Class.Conversion cnv = new lib.Class.Conversion();
        System.IO.Ports.SerialPort Serial = new System.IO.Ports.SerialPort(Porta, Velocidade, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
        Serial.Open();
        for (int i = 0; i < texto.Count; i++)
        { Serial.WriteLine(texto[i]); }
        Serial.Close();
      }
    }

    public static void SolicitarSuporte()
    {
      try
      {
        System.Diagnostics.Process prc = new System.Diagnostics.Process();
        prc.StartInfo.FileName = GetDirAppCondig() + "\\AA_v3.5.exe";
        prc.Start();
      }
      catch { }
    }

    public static void ShowReport(string ReportName) 
    {
      string ReportFile = string.Format( "{0}\\Reports\\{1}.swr",GetDirAppCondig(), ReportName);
      string LogFile = GetDirAppCondig() + "\\Debug.log";

      SqlWebReport.SwrReport Report = new SqlWebReport.SwrReport();
      Report.Cmp.SetLogFile(LogFile);
      Report.AddConnection(new SqlWebReport.ItemCfgConnection("Database", lib.Entity.ConnectionType.MySql, "Server=187.45.196.220;Database=rcksoftware;Uid=rcksoftware;Pwd=RCK6px2erjr;"));
      SwrForms.Report.ShowReport(Report, ReportFile, new List<SqlWebReport.ParamQuery>());
    }
  }
}
