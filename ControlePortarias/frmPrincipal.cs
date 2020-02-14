using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Visual;
using lib.Visual.Models;
using lib.Database.Query;
using lib.Database.Drivers;

namespace ControlePortarias
{
  public partial class frmPrincipal : lib.Visual.Models.frmBase
  {
    public frmPrincipal()
    {
      InitializeComponent();
      Processo = new System.Threading.Thread(new System.Threading.ThreadStart(ProcessoAtualizacao));
      Processo.Start();
    }

    bool BloquearProcesso = false;
    System.Threading.Thread Processo { get; set; }
    int DownloadData { get; set; }

    private void Display(string msg)
    {
      try
      {
        BeginInvoke((Action)delegate()
        {
          try
          {
            lblInfo.Text = msg;
          }
          catch { }
        });
      }
      catch { }
    }

    private void ProcessoAtualizacao()
    {
      dsCAS_CASA dsCas = new dsCAS_CASA(Utilities.Cnn);
      dsMRD_MORADOR dsMrd = new dsMRD_MORADOR(Utilities.Cnn);
      dsRVT_REGISTRO_VISITAS dsRvt = new dsRVT_REGISTRO_VISITAS(Utilities.Cnn);
      dsAUT_AUTORIZADOS dsAut = new dsAUT_AUTORIZADOS(Utilities.Cnn);

      DownloadData = 15;
      Display("Start");

      while (true)
      {
        if (DownloadData == 15)
        {
          #region Baixa Moradores
          try 
          {
            CTP_MRD_MORADOR[] lst = Service.RetornaMoradores(dsMrd.LastUpdate());
            for (int i = 0; i < lst.Length; i++)
            {
              try
              {
                Utilities.Cnn.BeginTransaction();
                CAS_CASA cas = new CAS_CASA();
                cas.Assign(lst[i]);
                cas.CAS_CODIGO = dsCas.Get_FromHashMD5(lst[i].CAS_HASHMD5).CAS_CODIGO;
                dsCas.Save(cas);

                MRD_MORADOR mrd = new MRD_MORADOR();
                mrd.Assign(lst[i]);
                mrd.MRD_CODIGO = dsMrd.Get_FromHashMD5(lst[i].MRD_HASHMD5).MRD_CODIGO;
                mrd.MRD_CAS_CODIGO = cas.CAS_CODIGO;
                dsMrd.Save(mrd);
                Utilities.Cnn.CommitTransaction();
              }
              catch { Utilities.Cnn.RollbackTransaction(); }
            }
          }
          catch (Exception ex)
          { Display(ex.Message); }
          #endregion

          #region Baixa Visitantes Autorizados
          try
          {
            CTP_AUT_AUTORIZADOS[] lst = Service.RetornaAutorizados(dsAut.LastUpdate());
            for (int i = 0; i < lst.Length; i++)
            {
              AUT_AUTORIZADOS aut = new AUT_AUTORIZADOS();
              aut.Assign(lst[i]);
              aut.AUT_CODIGO = dsAut.Get_FromHashMD5(lst[i].AUT_HASHMD5).AUT_CODIGO;
              aut.AUT_CAS_CODIGO = dsCas.Get_FromHashMD5(lst[i].AUT_CAS_HASHMD5).CAS_CODIGO;
              dsAut.Save(aut);
            }
          }
          catch (Exception ex)
          { Display(ex.Message); }
          #endregion

          DownloadData = 0;
        }

        #region Envia Moradores
        try
        {
          MRD_MORADOR[] mrd_list = dsMrd.GetList_FromSincronizar();
          for (int i = 0; i < mrd_list.Length; i++)
          {
            if (BloquearProcesso)
            { return; }

            Display("Morador:" + mrd_list[i].MRD_NOME);
            CAS_CASA cas = dsCas.Get(mrd_list[i].MRD_CAS_CODIGO);
            
            CTP_MRD_MORADOR ctp_mrd = new CTP_MRD_MORADOR();
            mrd_list[i].Fill(ctp_mrd);
            cas.Fill(ctp_mrd);
            Service.AdicionaMorador(ctp_mrd);
            
            mrd_list[i].MRD_SINCRONIZAR = false;
            dsMrd.Save(mrd_list[i]);
          }
        }
        catch (Exception ex) 
        { Display(ex.Message); }
        #endregion

        #region Envia Visitantes Autorizados
        try
        {
          AUT_AUTORIZADOS[] aut_list = dsAut.GetList_FromSincronizar();
          for (int i = 0; i < aut_list.Length; i++)
          {
            if (BloquearProcesso)
            { return; }

            Display("Visitante:" + aut_list[i].AUT_NOME);
            CAS_CASA cas = dsCas.Get(aut_list[i].AUT_CAS_CODIGO);
            
            CTP_AUT_AUTORIZADOS ctp_aut = new CTP_AUT_AUTORIZADOS();
            aut_list[i].Fill(ctp_aut);
            ctp_aut.AUT_CAS_HASHMD5 = cas.CAS_HASHMD5;
            Service.AdicionaAutorizados(ctp_aut);

            aut_list[i].AUT_SINCRONIZAR = false;
            dsAut.Save(aut_list[i]);
          }
        }
        catch (Exception ex)
        { Display(ex.Message); }
        #endregion 

        #region Envia Registros de Visitas
        try
        {
          RVT_REGISTRO_VISITAS[] rvt_list = dsRvt.GetList_FromSincronizar();
          for (int i = 0; i < rvt_list.Length; i++)
          {
            if (BloquearProcesso)
            { return; }

            Display("Registro Visitas:" + rvt_list[i].RVT_NOME);
            MRD_MORADOR mrd = dsMrd.Get(rvt_list[i].RVT_MRD_CODIGO);
            
            CTP_RVT_REGISTRO_VISITAS ctp_rvt = new CTP_RVT_REGISTRO_VISITAS();
            rvt_list[i].Fill(ctp_rvt);
            ctp_rvt.RVT_MRD_HASHMD5 = mrd.MRD_HASHMD5;
            Service.AdicionaRegistroVisita(ctp_rvt);

            rvt_list[i].RVT_SINCRONIZAR = false;
            dsRvt.Save(rvt_list[i]);
          }
        }
        catch (Exception ex)
        { Display(ex.Message); }
        #endregion

        #region Aguarda
        try
        {
          DownloadData ++;
          for (int i = 0; i < 10; i++)
          {
            if (BloquearProcesso)
            { return; }

            Display("Sleep:" + i);
            System.Threading.Thread.Sleep(1000);
          }
        }
        catch { continue; }
        #endregion
      }
    }

    #region private void Carregar()
    private void Carregar()
    {
      try
      {
        this.Text = string.Format("Sistema Financeiro [versão:{0}]", lib.Class.Utils.GetVersion());
        lblInfo.Text = Utilities.Cnn.dbType.ToString() + ":" + Utilities.Cnn.Info.Server + "." + Utilities.Cnn.Info.Database;
      }
      catch (Exception ex)
      { Utilities.FormError.ShowError(ex); }
    }
    #endregion

    #region private string GetLastName(string FormName)
    private string GetLastName(string FormName)
    {
      if (FormName.IndexOf('.') == -1)
      { return FormName; }

      string[] Names = FormName.Split(new char[] { '.' });
      return Names[Names.Length - 1];
    }
    #endregion

    #region private Form GetMDIForm(string FormName)
    private Form GetMDIForm(string FormName)
    {
      for (int i = 0; i < this.MdiChildren.Length; i++)
      {
        if (this.MdiChildren[i].Name == GetLastName(FormName))
        { return this.MdiChildren[i]; }
      }

      return null;
    }
    #endregion

    #region private void ShowForm(enmFormName enm)
    private void ShowForm(string FormName)
    {
      Form f = GetMDIForm(FormName);

      if (f == null)
      {
        Type tp = Type.GetType("ControlePortarias." + FormName);
        f = (frmBase)Activator.CreateInstance(tp);
        f.Icon = this.Icon;
        f.MdiParent = this;
        f.MinimizeBox = false;

        f.StartPosition = FormStartPosition.Manual;
        f.Top = this.MdiChildren.Length * 10;
        f.Left = this.MdiChildren.Length * 10;
        //f.WindowState = FormWindowState.Maximized;

        f.Show();
      }

      f.BringToFront();
    }
    #endregion

    #region private void CloseMdiForms()
    private void CloseMdiForms()
    {
      while (this.MdiChildren.Length != 0)
      { this.MdiChildren[0].Close(); }
    }
    #endregion

    private void frmPrincipal_Load(object sender, EventArgs e)
    {
      ToolStripManager.Renderer = new lib.Visual.Style.Office2007Renderer();
      Carregar();
    }

    private void frmPrincipal_Resize(object sender, EventArgs e)
    {
      this.BackgroundImageLayout = ImageLayout.None;
      this.BackgroundImageLayout = ImageLayout.Stretch;
    }

    private void fazerBackupToolStripMenuItem_Click(object sender, EventArgs e)
    {    
      lib.Visual.Forms.Backup b = new lib.Visual.Forms.Backup(Utilities.Cnn, Utilities.ScriptFile);
      b.MdiParent = this;
      b.Show();
    }

    private void sairToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void pastaDeArquivosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      lib.Class.Instance.ExecProcess(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", Utilities.PastaDados(), false);
    }

    private void casaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("frmMoradia");
    }

    private void visitantesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("frmVisitante");
    }

    private void moradoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowForm("frmMorador");
    }

    private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
    {
      
    }

    private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {
      BloquearProcesso = true;
    }
  }
}
