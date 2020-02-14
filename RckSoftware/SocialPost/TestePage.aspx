<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestePage.aspx.cs" Inherits="RckSoftware.TestePage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:Label ID="lblLinkTeste" runat="server"></asp:Label>
      <asp:Label ID="lblTesteRedirect" runat="server"></asp:Label>
      <br /><br />
      <label>O sistema recebeu o Token : </label>
      <asp:Label ID="lblToken" runat="server"></asp:Label><br />
      <label>O sistema recebeu o Token Secreto : </label>
      <asp:Label ID="lblSecret" runat="server"></asp:Label>
      <br />
      <h1>Testes</h1>
      <h2>GetInfo</h2>
        <p>
        Clique no link para buscar informações sobre a conta<br />
        <asp:Label ID="lblGetInfo" runat="server"></asp:Label>
        </p>
      <h2>Post</h2>
        <p>
        Clique no link para postar<br />
        <asp:Label ID="lblPost" runat="server"></asp:Label>
        </p>
      <h2>Post Photo</h2>
        <p>Insira uma imagem para enviar<br />
        <asp:FileUpload ID="fuImagem" runat="server" /><br />
        <asp:Button ID="btnPostarFoto" runat="server" Text="Postar Foto" 
            onclick="btnPostarFoto_Click" />
        </p>
      <br />
    </div>
    </form>
</body>
</html>
