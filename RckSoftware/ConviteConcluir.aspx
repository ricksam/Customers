<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConviteConcluir.aspx.cs" Inherits="RckSoftware.ConviteConcluir" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sucesso</title>
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script type="text/javascript" src="js/jquery.maskedinput-1.3.min.js"></script>
    <link type="text/css" rel="stylesheet" href="css/main.css" media="all"  />
</head>
<body>
  <form id="frmConcluido" runat="server">
    <div id='page'>
      <div id='title'>
        <div class='inner'>
          <img class='logo' src="img/logoConvite.png" />
          
          <div id="menu">
            <ul>            
              <li><a href=''>Contato</a></li>
              <li><a href='Privacidade.aspx'>Privacidade</a></li>
              <li><a href=''>Tutorial</a></li>
            </ul>
            <br style="clear:both" />
          </div>
        </div>        
      </div>
      <div id='main'>
        <div class='inner'>
          <div id='header'><h1>Concluído</h1></div>
          <div id="detail">            
            <div class='widget'>
              <div class='content'>
                <p class="message success">Convite cadastrado com sucesso!</p>
                <asp:HiddenField ID="txtToken" runat="server" />
                <div style="float:left;margin-right:20px ">
                  <asp:Image ID="imgFoto" runat="server" />
                </div>
                <div style="float:left">
                  <p>
                    <label>Convite</label><br />
                    <asp:TextBox ID="txtConvite" runat="server"></asp:TextBox>
                  </p>
                  <p>
                    <label>Nome</label><br />
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                  </p>                
                  <p>
                    <label>Email</label><br />
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                  </p>                
                </div>
                <br style="clear:both" />
              </div>
              <div class='footer'>  
                <asp:Label ID="lblVoltar" runat="server"></asp:Label>              
                <asp:Button ID="btnVoltar" runat="server" Text="Voltar" onclick="btnVoltar_Click" />
                <input type="button" value="Imprimir" onclick="window.print();" />
              </div>
            </div>
          </div>
        </div>        
      </div>
      <div id='footer'>
        <div class='inner'>
          <p>www.rcksoftware.com.br | jricksam@gmail.com</p>
        </div>
      </div>
    </div>
  </form>
</body>
</html>
