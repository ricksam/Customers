<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Erro.aspx.cs" Inherits="RckSoftware.Erro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Erro</title>
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script type="text/javascript" src="js/jquery.maskedinput-1.3.min.js"></script>
    <link type="text/css" rel="stylesheet" href="css/main.css" media="all"  />
</head>
<body>
    <form id="form1" runat="server">
    <div id='page'>
      <div id='title'>
        <div class='inner'>
          <img class='logo' src='img/logoConvite.png' />
          
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
                <p class="message error">Houve um erro ao cadastrar o convite. Tente novamente mais tarde!</p>
              </div>
              <div class='footer'>                
                <asp:Button ID="btnVoltar" runat="server" Text="Voltar" onclick="btnVoltar_Click" />
              </div>
            </div>
          </div>
        </div>        
      </div>
      <div id='footer_index'>
        <div class='inner'>
          <p>www.rcksoftware.com.br | jricksam@gmail.com</p>
        </div>
      </div>
    </div>
    </form>
</body>
</html>
