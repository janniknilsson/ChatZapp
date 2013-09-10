<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BottomNavigationControl.ascx.cs" Inherits="SignalR.Controls.BottomNavigationControl" %>
<div class="navigation">
  <asp:LinkButton ID="Button1" runat="server" OnClick="NewDiscussion" CssClass="button-new icon-client-pencil" Text="" UseSubmitBehavior="False"></asp:LinkButton>
  <asp:LinkButton ID="Button2" runat="server" OnClick="ShowAllDiscussion" CssClass="button-new icon-client-list" Text="" UseSubmitBehavior="False" />
  <asp:LinkButton ID="Button3" runat="server" OnClick="ChangeRadius" CssClass="button-new icon-client-target" Text="" UseSubmitBehavior="False"/>
</div>
