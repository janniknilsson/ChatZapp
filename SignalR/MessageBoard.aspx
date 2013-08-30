<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="MessageBoard.aspx.cs" Inherits="SignalR.MessageBoard" %>

<%@ Register Src="~/Controls/MessageBoardControl.ascx" TagPrefix="uc2" TagName="MessageBoardControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceholder" runat="server">
  <div class="container">
    <uc2:MessageBoardControl runat="server" id="MessageBoardControl" />
  </div>
</asp:Content>
