using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Folha_Marcelo
{
  public partial class ItemAlerta : lib.Visual.Models.frmEdit
  {
    public ItemAlerta()
    {
      InitializeComponent();
      Tab = new ALT_ALERTAS();
    }

    public ALT_ALERTAS Tab { get; set; }

    #region private void Carregar()
    private void Carregar() 
    {
      if (Tab.ALT_DATA == DateTime.MinValue)
      { dtData.Value = DateTime.Now; }
      else
      { dtData.Value = Tab.ALT_DATA; }

      if (Tab.ALT_DATA_FINAL == DateTime.MinValue)
      { dtDataFinal.Value = DateTime.Now; }
      else
      { dtDataFinal.Value = Tab.ALT_DATA_FINAL; }

      txtMensagem.Text = Tab.ALT_MENSAGEM;
    }
    #endregion

    #region public bool FaltaPreencher()
    public bool FaltaPreencher()
    {
      lib.Class.LockedField[] lf = (new dsALT_ALERTAS(Utilities.Cnn)).GetLockedFields(Tab);
      if (lf.Length != 0)
      {
        string xMsg = "";
        for (int i = 0; i < lf.Length; i++)
        { xMsg += lf[i].Message + "\n"; }
        lib.Visual.Msg.Warning("Verifique os campos abaixo:\n" + xMsg);
      }
      return lf.Length != 0;
    }
    #endregion

    #region protected override void OnConfirm()
    protected override void OnConfirm()
    {
      Tab.ALT_DATA = dtData.Value;
      Tab.ALT_DATA_FINAL = dtDataFinal.Value;
      Tab.ALT_MENSAGEM = txtMensagem.Text;
    
      if (!FaltaPreencher())
      { base.OnConfirm(); }
    }
    #endregion

    #region Events
    private void ItemAlerta_Load(object sender, EventArgs e)
    {
      Carregar();
    }
    #endregion
  }
}
