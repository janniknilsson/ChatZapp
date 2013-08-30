<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DiscussionBoard.aspx.cs" Inherits="SignalR.DiscussionBoard" %>

<%@ Register Src="~/Controls/DiscussionControl.ascx" TagPrefix="uc1" TagName="DiscussionControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder" runat="server">
  <uc1:DiscussionControl runat="server" ID="DiscussionControl" />
</asp:Content>
