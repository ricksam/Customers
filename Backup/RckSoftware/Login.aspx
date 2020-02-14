<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RckSoftware.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <!-- Mobile Specific Metas -->
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Login</h1>
    <p>
      <label>Login</label><br />
      <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>  
    </p>

    <p>
      <label>Senha</label><br />
      <asp:TextBox ID="txtSenha" TextMode="Password" runat="server"></asp:TextBox>
    </p>

    <p>
      <asp:Button ID="btnAcessar" Text="Acessar" runat="server" 
        onclick="btnAcessar_Click" /><br />
      <asp:Label ID="lblResp" runat="server"></asp:Label>
    </p>
    
    </div>
    </form>
</body>
</html>
