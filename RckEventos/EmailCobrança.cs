using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RckEventos
{
  public partial class EmailCobrança : Form
  {
    public EmailCobrança()
    {
      InitializeComponent();
    }

    private void sknButton1_Click(object sender, EventArgs e)
    {
      lib.Class.Mail mail = lib.Class.WebUtils.GetMailDeveloper();

      string CorpoEmail =
        "<!-- INICIO FORMULARIO BOTAO PAGSEGURO -->" +
        "<form target=\"pagseguro\" action=\"https://pagseguro.uol.com.br/checkout/v2/payment.html\" method=\"post\">" +
        "<!-- NÃO EDITE OS COMANDOS DAS LINHAS ABAIXO -->" +
        "<input type=\"hidden\" name=\"code\" value=\"E0DD987891910C73348D1FB02F84536B\" />" +
        "<input type=\"image\" src=\"https://p.simg.uol.com.br/out/pagseguro/i/botoes/pagamentos/120x53-comprar-azul.gif\" name=\"submit\" alt=\"Pague com PagSeguro - é rápido, grátis e seguro!\" />" +
        "</form>" +
        "<!-- FINAL FORMULARIO BOTAO PAGSEGURO -->";
      mail.SendMail(CorpoEmail, true, "jricksam@gmail.com", "Compra");
    }
  }
}
