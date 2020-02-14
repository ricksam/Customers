using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Financeiro_Marcelo.Senha
{
  public partial class CadastroSenha : lib.Visual.Models.frmDialog
  {
    public CadastroSenha()
    {
      InitializeComponent();
    }

    private bool Validacao() 
    {
      lib.Visual.Components.ValidateField vf = new lib.Visual.Components.ValidateField();
      vf.Add(txtSenhaEntrada, " - A senha de entrada não pode ser nula", string.IsNullOrEmpty(txtSenhaEntrada.Text.Trim()));
      vf.Add(txtConfirmarSenhaEntrada, " - A confirmação da senha de entrada deve ser idêntica a senha de entrada.", txtSenhaEntrada.Text != txtConfirmarSenhaEntrada.Text);
      vf.Add(txtSenhaExclusiva, " - A senha exclusiva não pode ser nula", string.IsNullOrEmpty(txtSenhaExclusiva.Text.Trim()));
      vf.Add(txtConfirmarSenhaExclusiva, " - A confirmação da senha exclusiva deve ser idêntica a senha exclusiva.", txtSenhaExclusiva.Text != txtConfirmarSenhaExclusiva.Text);
      vf.Add(txtSenhaExclusiva, " - A senha exclusiva não pode ser igual a senha de entrada", txtSenhaExclusiva.Text == txtSenhaEntrada.Text);
      return !vf.Blocked("Verifique os campos");
    }

    protected override void OnConfirm()
    {
      if (Validacao())
      {
        dsCFG_CONFIG bsCfg = new dsCFG_CONFIG(Utilities.Cnn);
        CFG_CONFIG Cfg = bsCfg.Get();
        Cfg.CFG_SENHA_ENTRADA = lib.Class.EncryptionDeprecated.GetSHA1(txtSenhaEntrada.Text);
        Cfg.CFG_SENHA_EXCLUSIVA = lib.Class.EncryptionDeprecated.GetSHA1(txtSenhaExclusiva.Text);
        bsCfg.Save(Cfg);
        base.OnConfirm();
      }
    }
  }
}
