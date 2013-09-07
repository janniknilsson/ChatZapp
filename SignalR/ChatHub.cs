using System;
using Microsoft.AspNet.SignalR;
using SignalR.Infrastructure;
using SignalR.Model.Factories;
using SignalR.Model.Repositories;

namespace SignalR
{
  public class ChatHub : Hub
  {
    public void Send(string name, string message, string groupId, string latitude, string longitude, string browser)
    {
      //Double formattedLatitude = FormatCoordinateService.Format(latitude);
      //Double formattedLongitude = FormatCoordinateService.Format(longitude);
      var newLat = latitude.Replace('.', ',');
      var newLong = longitude.Replace('.', ',');
      if (string.IsNullOrEmpty(groupId))
      {
        var newGroupId = Guid.NewGuid().ToString().Replace("-", "");
        try
        {
          MessageRepository.Insert(MessageFactory.Create(name, newGroupId, message, DateTime.Now, Convert.ToDouble(newLat), Convert.ToDouble(newLong), browser));
        }
        catch (Exception)
        {

          throw new Exception(string.Concat(name + " " + message + " " + groupId + " " + latitude + " " + longitude + " " + browser));
        }
      }
      else
      {
        MessageRepository.Insert(MessageFactory.Create(name, groupId, message, DateTime.Now, Convert.ToDouble(latitude), Convert.ToDouble(longitude), browser));
      }
      Clients.All.broadcastMessage(name, message, groupId);
    }
  }
}