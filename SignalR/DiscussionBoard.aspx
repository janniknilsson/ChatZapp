<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DiscussionBoard.aspx.cs" Inherits="SignalR.DiscussionBoard" %>

<%@ Register Src="~/Controls/DiscussionControl.ascx" TagPrefix="uc1" TagName="DiscussionControl" %>
<%@ Register Src="~/Controls/BottomNavigationControl.ascx" TagPrefix="uc2" TagName="BottomNavigationControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder" runat="server">
  <uc1:DiscussionControl runat="server" ID="DiscussionControl" />
</asp:Content>
<asp:Content ID="Content3" runat="server" ContentPlaceHolderID="NavigationPlaceholder">
  <uc2:BottomNavigationControl runat="server" ID="BottomNavigationControl" />
</asp:Content>