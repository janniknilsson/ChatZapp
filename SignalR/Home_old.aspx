<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home_old.aspx.cs" Inherits="SignalR.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Simple Chat</title>

</head>
<body>
  <form id="form1" runat="server">
    <asp:Panel runat="server" ID="UserPanel" Visible="True" CssClass="userinfo">
      <div>
        <h2>What is your name</h2>
        <asp:TextBox runat="server" ID="TxtName" required/>
        
        <h2>What is the scan radius? (km)</h2>
        <asp:TextBox runat="server" ID="TxtRadius" required />
        
        <asp:Button ID="Button1" runat="server" OnClick="SaveNameAndRadius" Text="Save"  />
      </div>
    </asp:Panel>
    <div>
      <asp:HiddenField runat="server" ID="Latitude" ClientIDMode="Static" />
      <asp:HiddenField runat="server" ID="Longitude" ClientIDMode="Static" />
      <asp:HiddenField runat="server" ID="GroupId" ClientIDMode="Static" />
    </div>
  </form>
</body>
</html>
