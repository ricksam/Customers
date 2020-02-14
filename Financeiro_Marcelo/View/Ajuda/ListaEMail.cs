using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lib.Visual;

namespace Financeiro_Marcelo.View.Ajuda
{
  public partial class ListaEMail : lib.Visual.Models.frmBase
  {
    public ListaEMail()
    {
      InitializeComponent();
      dsEml = new dsEML_EMAIL(Utilities.Cnn);
    }

    dsEML_EMAIL dsEml { get; set; }

    private void Listar() 
    {
      lstEMail.DisplayMember = "EML_CONTATO";
      lstEMail.ValueMember = "EML_COIGO";
      lstEMail.DataSource = dsEml.GetList();
    }

    private void Adicionar() 
    {
      if(string.IsNullOrEmpty(txtEMail.Text))
      {
        Msg.Warning("Informe um e-mail");
        return;
      }

      if (dsEml.Get_FromContato(txtEMail.Text).EML_CODIGO == 0)
      {
        EML_EMAIL Eml = new EML_EMAIL();
        Eml.EML_CONTATO = txtEMail.Text;
        dsEml.Save(Eml);        
        txtEMail.Clear();
        txtEMail.Focus();
      }
      else
      { Msg.Warning("Email já cadastrado"); }

      Listar();
    }

    private void Remover() 
    {
      int idx = lstEMail.SelectedIndex; 
      if (lstEMail.SelectedIndex != 0)
      {
        int cod = ((EML_EMAIL)lstEMail.SelectedItem).EML_CODIGO;
        if (Msg.Question("Tem certeza que deseja remover o email " + lstEMail.Text))
        {
          dsEml.Remove(cod);
          Listar();
        }
      }

      Listar();
    }
    
    private void txtEMail_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      { Adicionar(); }
    }

    private void lstEMail_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Delete)
      { Remover(); }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      Adicionar();
    }

    private void ListaEMail_Load(object sender, EventArgs e)
    {
      Listar();     
    }
  }
}
