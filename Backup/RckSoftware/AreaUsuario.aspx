<%@ Page AutoEventWireup="true" CodeBehind="AreaUsuario.aspx.cs" Inherits="RckSoftware.AreaUsuario" Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

    <title>Camera</title>
    <!-- Mobile Specific Metas -->
    <meta content="text/html; charset=utf-8" http-equiv="Content-Type" />
    <meta content="width=device-width, initial-scale=1.0" name="viewport" />
    <form id="form1" runat="server">
    <div>
      <asp:ScriptManager ID="scSite" runat="server">
      </asp:ScriptManager>
      <asp:Timer ID="tmrUp" runat="server" Enabled="False" Interval="200" 
        ontick="tmrUp_Tick">
      </asp:Timer>
      <asp:UpdatePanel ID="upControl" runat="server">
        <ContentTemplate>
          <table>
            <tr>
              <td>
                Datas</td>
              <td>
                <asp:ListBox ID="lstDatas" runat="server" 
                  onselectedindexchanged="lstDatas_SelectedIndexChanged"></asp:ListBox>
              </td>
            </tr>
            <tr>
              <td>
                Cameras</td>
              <td>
                <asp:DropDownList ID="cmbCameras" runat="server" 
                  onselectedindexchanged="cmbCameras_SelectedIndexChanged">
                </asp:DropDownList>
              </td>
            </tr>
          </table>
          <asp:Button ID="btnExibir" runat="server" Width="100" Height="60" onclick="btnExibir_Click" 
            Text="Exibir" />
          <asp:Button ID="btnInicio" runat="server" Width="100" Height="60" onclick="btnInicio_Click" 
            Text="Inicio" />
          <asp:Button ID="btnProxima" runat="server" Width="100" Height="60" onclick="btnProxima_Click" 
            Text="Próxima" />
          
          <br />
          <asp:Label ID="lblResp" runat="server"></asp:Label>
          <br />
          <img alt="" id="imgFoto" width="320" height="240" runat="server" src="data:image/jpg;base64,{0}" />
          <br /><br />          
          <asp:Button ID="btnApagar" runat="server" onclick="btnApagar_Click" 
            Text="Apagar esta data" />
        </ContentTemplate>
      </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>


