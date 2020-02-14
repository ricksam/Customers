using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Visual;
using lib.Class;
using lib.Database.Query;
using lib.Database.Drivers;

namespace ControlePortarias
{
  public partial class frmMoradia : lib.Visual.Models.frmBaseCadastro
  {
    public frmMoradia()
    {
      InitializeComponent();
      dsCas = new dsCAS_CASA(Utilities.Cnn);
      dsMrd = new dsMRD_MORADOR(Utilities.Cnn);
      dsAut = new dsAUT_AUTORIZADOS(Utilities.Cnn);
      Moradores = new List<MRD_MORADOR>();
      Visitantes = new List<AUT_AUTORIZADOS>();
      lib.Visual.Functions.SetPropertiesGrid(grdMorador);
      lib.Visual.Functions.SetPropertiesGrid(grdVisitantes);
    }

    CAS_CASA Tab { get; set; }
    dsCAS_CASA dsCas { get; set; }
    dsMRD_MORADOR dsMrd { get; set; }
    List<MRD_MORADOR> Moradores { get; set; }
    dsAUT_AUTORIZADOS dsAut { get; set; }
    List<AUT_AUTORIZADOS> Visitantes { get; set; }

    private void Carregar()
    {
      txtCasa.Text = Tab.CAS_NUMERO;
      txtLote.Text = Tab.CAS_LOTE;
      txtQuadra.Text = Tab.CAS_QUADRA;
      txtRamal.Text = Tab.CAS_RAMAL;
      CarregarMoradores();
      CarregarVisitantes();
    }

    protected override void OnNewRecord()
    {
      Tab = new CAS_CASA();
      Carregar();
      base.OnNewRecord();
      txtCasa.Select();
    }

    protected override void OnAlterRecord(lib.Visual.Components.sknGrid Grid)
    {
      Tab = Grid.GetItem<CAS_CASA>();
      Carregar();
      base.OnAlterRecord(Grid);
    }

    protected override void OnRemoveRecord()
    {
      if (Msg.Question(string.Format("Tem certeza que deseja remover o registro {0}", Tab.CAS_CODIGO)))
      {
        try
        {
          Utilities.Cnn.BeginTransaction();
          dsMrd.Remove_FromCasa(Tab.CAS_CODIGO);
          dsAut.Remove_FromCasa(Tab.CAS_CODIGO);
          dsCas.Remove(Tab.CAS_CODIGO);
          Utilities.Cnn.CommitTransaction();
        }
        catch 
        { Utilities.Cnn.RollbackTransaction(); }
      }
      base.OnRemoveRecord();
    }

    private bool FaltaPreencher()
    {
      LockedField[] lf = dsCas.GetLockedFields(Tab);
      if (lf.Length != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "\n"; }
        Msg.Warning("Verifique os campos abaixo:\n" + xMsg);

        if (lf[0].Field == "CAS_NUMERO")
        { txtCasa.Select(); }
        else if (lf[0].Field == "CAS_LOTE")
        { txtLote.Select(); }
        else if (lf[0].Field == "CAS_QUADRA")
        { txtQuadra.Select(); }
        else if (lf[0].Field == "CAS_RAMAL")
        { txtRamal.Select(); }
      }

      return lf.Length != 0;
    }
    
    protected override void OnConfirm()
    {
      Tab.CAS_NUMERO = txtCasa.Text;
      Tab.CAS_LOTE = txtLote.Text;
      Tab.CAS_QUADRA = txtQuadra.Text;
      Tab.CAS_RAMAL = txtRamal.Text;
      if (!FaltaPreencher())
      {
        try
        {
          Utilities.Cnn.BeginTransaction();
          if (Tab.CAS_CODIGO != 0)
          {
            dsMrd.Remove_Antigos(Tab.CAS_CODIGO, Moradores.ToArray());
            dsAut.Remove_Antigos(Tab.CAS_CODIGO, Visitantes.ToArray());
          }

          dsCas.Save(Tab);

          for (int i = 0; i < Moradores.Count; i++)
          {
            Moradores[i].MRD_CAS_CODIGO = Tab.CAS_CODIGO;
            Moradores[i].MRD_SINCRONIZAR = true;
            dsMrd.Save(Moradores[i]);
          }

          dsAUT_AUTORIZADOS dsVst = new dsAUT_AUTORIZADOS(Utilities.Cnn);
          for (int i = 0; i < Visitantes.Count; i++)
          {
            Visitantes[i].AUT_CAS_CODIGO = Tab.CAS_CODIGO;
            //Visitantes[i].AUT_CAS_CODIGO = Tab.CAS_CODIGO;
            Visitantes[i].AUT_SINCRONIZAR = true;
            dsAut.Save(Visitantes[i]);
          }
          Utilities.Cnn.CommitTransaction();
        }
        catch (Exception ex)
        {
          Msg.Warning("Erro ao gravar:" + ex.Message);
          Utilities.Cnn.RollbackTransaction();
        }

        grdMorador.DataSource = null;
        grdVisitantes.DataSource = null;
        base.OnConfirm();
      }
    }

    private void Turnos_Search(object sender, lib.Visual.Components.sknGrid Grid, string TextSearch)
    {
      Grid.Clear();
      Grid.AddColumn(new FieldColumn("Casa", "CAS_NUMERO", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Lote", "CAS_LOTE", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Quadra", "CAS_QUADRA", enmFieldType.String));
      Grid.AddColumn(new FieldColumn("Ramal", "CAS_RAMAL", enmFieldType.String));
      Grid.AddItems(dsCas.Search(TextSearch));
    }

    private void CarregarMoradores()
    {
      grdMorador.DataSource = null;
      dsMRD_MORADOR dsMrd = new dsMRD_MORADOR(Utilities.Cnn);
      Moradores.Clear();
      if (Tab.CAS_CODIGO != 0)
      {
        Moradores.AddRange(dsMrd.GetList_FromCasa(Tab.CAS_CODIGO));
        grdMorador.DataSource = Moradores;
      }
    }

    private void CarregarVisitantes()
    {
      grdVisitantes.DataSource = null;
      dsAUT_AUTORIZADOS dsVst = new dsAUT_AUTORIZADOS(Utilities.Cnn);
      Visitantes.Clear();
      if (Tab.CAS_CODIGO != 0)
      {
        Visitantes.AddRange(dsVst.GetList_FromCasa(Tab.CAS_CODIGO));
        grdVisitantes.DataSource = Visitantes;
      }
    }

    private void AdicionarMorador()
    {
      frmEditMorador f = new frmEditMorador();
      f.Carregar();
      if (f.Exec())
      {        
        Moradores.Add(f.Tab);
        grdMorador.DataSource = null;
        grdMorador.DataSource = Moradores;
      }
    }

    private void AdicionarVisitante()
    {
      frmEditVisitante f = new frmEditVisitante();
      f.Carregar();
      if (f.Exec())
      {
        Visitantes.Add(f.Tab);
        grdVisitantes.DataSource = null;
        grdVisitantes.DataSource = Visitantes;
      }
    }

    private void AlterarMorador()
    {
      try
      {
        if (grdMorador.SelectedRows.Count != 0)
        {
          int idx = grdMorador.SelectedRows[0].Index;

          if (idx < 0)
          {
            Msg.Warning("Selecione um morador");
            return;
          }

          frmEditMorador f = new frmEditMorador();
          f.Tab.Assign(Moradores[idx]);
          f.Carregar();
          if (f.Exec())
          {
            Moradores[idx].Assign(f.Tab);
            grdMorador.DataSource = null;
            grdMorador.DataSource = Moradores;
          }
        }
      }
      catch { Msg.Warning("Selecione um morador"); }
    }

    private void AlterarVisitante()
    {
      try
      {
        if (grdVisitantes.SelectedRows.Count != 0)
        {
          int idx = grdVisitantes.SelectedRows[0].Index;

          if (idx < 0)
          {
            Msg.Warning("Selecione um visitante");
            return;
          }

          frmEditVisitante f = new frmEditVisitante();
          f.Tab.Assign(Visitantes[idx]);
          f.Carregar();
          if (f.Exec())
          {
            Visitantes[idx].Assign(f.Tab);
            grdVisitantes.DataSource = null;
            grdVisitantes.DataSource = Visitantes;
          }
        }
      }
      catch { Msg.Warning("Selecione um visitante"); }
    }

    private void RemoverMorador()
    {
      try
      {
        if (grdMorador.SelectedRows.Count != 0)
        {
          int idx = grdMorador.SelectedRows[0].Index;
          if (Msg.Question("tem certesa que deseja remover este morador?"))
          {
            Moradores.RemoveAt(idx);
            grdMorador.DataSource = null;
            grdMorador.DataSource = Moradores;
          }
        }
      }
      catch { Msg.Warning("Selecione um morador"); }
    }

    private void RemoverVisitante()
    {
      try
      {
        if (grdVisitantes.SelectedRows.Count != 0)
        {
          int idx = grdVisitantes.SelectedRows[0].Index;
          if (Msg.Question("tem certesa que deseja remover este visitante ?"))
          {
            Visitantes.RemoveAt(idx);
            grdVisitantes.DataSource = null;
            grdVisitantes.DataSource = Visitantes;
          }
        }
      }
      catch { Msg.Warning("Selecione um visitante"); }
    }

    private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AdicionarMorador();
    }

    private void removerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      RemoverMorador();
    }

    private void removerToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      RemoverVisitante();
    }

    private void grdMorador_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { AlterarMorador(); }
    }

    private void grdVisitantes_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { AlterarVisitante(); }
    }

    private void grdMorador_DoubleClick(object sender, EventArgs e)
    {
      AlterarMorador();
    }

    private void grdVisitantes_DoubleClick(object sender, EventArgs e)
    {
      AlterarVisitante();
    }

    private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      AdicionarVisitante();
    }

    private void grdVisitantes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (e.Value != null && e.Value is DateTime && (DateTime)e.Value == DateTime.MinValue)
      { e.Value = null; }
    }
  }
}
