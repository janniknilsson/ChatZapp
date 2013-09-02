<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DiscussionControl.ascx.cs" Inherits="SignalR.Controls.DiscussionControl" %>
<%@ Import Namespace="SignalR.Model" %>

<asp:Repeater runat="server" ID="DiscussionList" DataSource="<%#GetMessages() %>">
  <HeaderTemplate>
    <ul id="message_<%#GroupId %>" class="discussion">
  </HeaderTemplate>
  <ItemTemplate>
    <li>
      <%# ((Message)Container.DataItem).Author %> - 
      <%# ((Message)Container.DataItem).Text %>
    </li>
  </ItemTemplate>
  <FooterTemplate>
    </ul>
  </FooterTemplate>
</asp:Repeater>

<div id="discussion_container">
  <input type="text" id="message" />
  <input type="button" id="sendmessage" value="Send" class="button-send" />
  <input type="hidden" id="displayname" />
  <input type="hidden" id="discussionId" value="<%#GroupId %>" />
  <asp:HiddenField runat="server" ID="UserName" ClientIDMode="Static"/>
</div>
<span id="error"></span>
