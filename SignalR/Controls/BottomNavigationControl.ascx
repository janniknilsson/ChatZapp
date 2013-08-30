<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BottomNavigationControl.ascx.cs" Inherits="SignalR.Controls.BottomNavigationControl" %>
<div class="navigation">
  <asp:Button ID="Button1" runat="server" OnClick="NewDiscussion" CssClass="entypo-alert" Text="New" />
  <asp:Button ID="Button2" runat="server" OnClick="ShowAllDiscussion" CssClass="entypo-right-open-big" Text="List" />
</div>
