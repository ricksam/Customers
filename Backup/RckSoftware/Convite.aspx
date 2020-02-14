<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Convite.aspx.cs" Inherits="RckSoftware.Convite" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Convite</title>
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script type="text/javascript" src="js/jquery.maskedinput-1.3.min.js"></script>
    <link type="text/css" rel="stylesheet" href="css/main.css" media="all"  />
  </head>
<body>
  <div id='page'>
    <form id="frmConvite" runat="server" >
      <div id='title'>
        <div class='inner'>
          <img alt='' class='logo' src='img/logoConvite.png' />
          
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
          <div id='header'><h1>Cadastro</h1></div>
          <div id="detail">            
            <div class='widget'>
              <div class='header'><h2>Convite</h2></div>
              <div class='content'>
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                <p>
                  <label>Código do convite</label><br />
                  <asp:TextBox CssClass="upper" ID="txtConvite" runat="server"></asp:TextBox>
                </p>                
              </div>
              <div class='footer'>    
                <asp:Button ID="btnConectar" runat="server" Text="Conectar-se com o facebook" 
                  onclick="btnConectar_Click" />  
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
    </form>
  </div>
</body>
</html>
