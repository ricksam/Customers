using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SqlWebReport;

namespace GravaVendaArquivo
{
  public partial class Principal : lib.Visual.Models.frmBase
  {
    public Principal()
    {
      InitializeComponent();
    }

    private void Carregar()
    {
      try
      {
        lib.Visual.Forms.FormConnection fc = new lib.Visual.Forms.FormConnection(lib.Visual.Functions.GetDirAppCondig());
        fc.LoadCfg();

        lib.Entity.MySQL db = new lib.Entity.MySQL("");
        //lib.Database.Connection cnn = new lib.Database.Connection();
        //cnn.Connect(fc.DbType, fc.InfoConnection);
        //lib.Visual.Msg.Information(cnn.Sql("SELECT EMP_DESCRICAO FROM EMP_EMPRESAS").ToString());

        lib.Class.TextFile FILE = new lib.Class.TextFile();

        SwrReport report = new SwrReport();
        report.OnStatus += new EventHandlerStatus(rp_Status);
        report.AddConnection(new ItemConnection("Database", db));

        string Report = System.IO.Directory.GetCurrentDirectory() + string.Format("\\Report_{0}.html", db.ConnectionType.ToString());
        report.LoadCode(Report, new List<ParamQuery>());

        string PastaBkp = System.IO.Directory.GetCurrentDirectory() + "\\Backup";

        if (!System.IO.Directory.Exists(PastaBkp))
        { System.IO.Directory.CreateDirectory(PastaBkp); }

        string ArqBkp = PastaBkp + string.Format("\\Report_{0}.html", DateTime.Now.ToString("ddMMyy_HHmmss"));
        FILE.Open(lib.Class.enmOpenMode.Writing, ArqBkp);
        FILE.Write(report.GetReport());
        FILE.Close();        
      }
      catch (Exception ex)
      {
        lblAguarde.Text = ex.Message;
        lblAguarde.Refresh();
        System.Threading.Thread.Sleep(3000);
      }

      this.Close();
    }

    public void rp_Status(object sender, EventArgsStatus e)
    {
      prgBand.Maximum = e.CountBand;
      prgBand.Value = e.NrBand;
      prgDst.Maximum = e.DstCount;
      prgDst.Value = e.DstRow;

      prgBand.Refresh();
      prgDst.Refresh();
      this.Refresh();
    }

    private void tmrReport_Tick(object sender, EventArgs e)
    {
      tmrReport.Enabled = false;
      Carregar();
    }
  }
}
