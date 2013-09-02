<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="MessageBoard.aspx.cs" Inherits="SignalR.MessageBoard" %>

<%@ Register Src="~/Controls/MessageBoardControl.ascx" TagPrefix="uc2" TagName="MessageBoardControl" %>
<%@ Register Src="~/Controls/BottomNavigationControl.ascx" TagPrefix="uc2" TagName="BottomNavigationControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder" runat="server">
  <div class="container">
    <uc2:MessageBoardControl runat="server" id="MessageBoardControl" />
  </div>
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="NavigationPlaceholder">
  <uc2:BottomNavigationControl runat="server" ID="BottomNavigationControl" />
</asp:Content>
