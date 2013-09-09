<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MessageBoardControl.ascx.cs" Inherits="SignalR.Controls.MessageBoardControl" %>
<%@ Import Namespace="SignalR.Model" %>
<div class="viewport">
  <asp:Repeater runat="server" ID="Discussions" DataSource="<%#GetMessageBoardDiscussions() %>">
    <HeaderTemplate>
      <ul class="conversations">
    </HeaderTemplate>
    <ItemTemplate>
      <li class="<%#(((Message)Container.DataItem).GroupId) %>">
        <asp:LinkButton runat="server" OnClick="ShowDiscussion" CommandArgument="<%#(((Message)Container.DataItem).GroupId) %>">
          <div class="text">
            <p>
              <strong><%#((Message)Container.DataItem).Author %> :</strong>
              <%#((Message)Container.DataItem).Text %>
            </p>
            <p>
              <em>oprettet:
              </em>
              <%#((Message)Container.DataItem).SendTime.ToString("dd-MM-yyyy  HH:mm") %>
            </p>
            <p>
              <span>
                <%#((Message)Container.DataItem).Latitude %> || <%#((Message)Container.DataItem).Longitude %>
              </span>
            </p>
          </div>
          <div class="info">
            <%# GetMessagesInDiscussion(((Message)Container.DataItem).GroupId) %>
          </div>
        </asp:LinkButton>
      </li>
    </ItemTemplate>
    <FooterTemplate>
      </ul>
    </FooterTemplate>
  </asp:Repeater>
</div>