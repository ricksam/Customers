using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  [Serializable]
  public class Config:lib.Class.Configuration
  {
    public Config()
      : base(lib.Class.SerializeFormat.Bin, Utilities.PastaDados() + "\\Config.bin")
    {
      Email = new CfgEmail();      
    }

    public int NrFormulariosTelaInicial { get; set; }
    public bool RemoveVendasOnLine { get; set; }
    public CfgEmail Email { get; set; }
    public string UltimoEnvioVendas { get; set; }
    public string PastaCopiaBackup { get; set; }
    
    public override bool Open()
    {
      try
      {
        bool b = base.Open();

        if (Email == null)
        { Email = new CfgEmail(); }

        if (!string.IsNullOrEmpty(Email.Senha))
        { Email.Senha = Utilities.Enc.Descrypt(Email.Senha); }
        return b;
      }
      catch { return false; }
    }

    public override bool Save()
    {
      if (!string.IsNullOrEmpty(Email.Senha))
      { Email.Senha = Utilities.Enc.Encrypt(Email.Senha); }
      return base.Save();
    }
  }
}
