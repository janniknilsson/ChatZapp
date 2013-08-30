using System;
using Microsoft.AspNet.SignalR;
using SignalR.Model.Factories;
using SignalR.Model.Repositories;

namespace SignalR
{
  public class ChatHub : Hub
  {
    public void Send(string name, string message, string groupId, string latitude, string longitude)
    {
      if (string.IsNullOrEmpty(groupId))
      {
        var newGroupId = Guid.NewGuid().ToString().Replace("-","");
        MessageRepository.Insert(MessageFactory.Create(name, newGroupId, message, DateTime.Now, Convert.ToDouble(latitude), Convert.ToDouble(longitude)));
      }
      else
      {
        MessageRepository.Insert(MessageFactory.Create(name, groupId, message, DateTime.Now, Convert.ToDouble(latitude), Convert.ToDouble(longitude)));
      }
      Clients.All.broadcastMessage(name, message, groupId);
    }
  }
}