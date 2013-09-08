<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BottomNavigationControl.ascx.cs" Inherits="SignalR.Controls.BottomNavigationControl" %>
<div class="navigation">
  <asp:Button ID="Button1" runat="server" OnClick="NewDiscussion" CssClass="button-new" Text="New" UseSubmitBehavior="False" />
  <asp:Button ID="Button2" runat="server" OnClick="ShowAllDiscussion" CssClass="button-new" Text="List" UseSubmitBehavior="False" />
</div>
