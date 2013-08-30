using System;
using MongoDB.Bson;
using SignalR.Infrastructure;

namespace SignalR.Model.Factories
{
  public class MessageFactory
  {
    public static Message Create(string author, string groupId, string text, DateTime sendTime, double longitude, double latitude)
    {
      return new Message
      {
        Id = ObjectId.GenerateNewId(),
        GroupId = groupId,
        Author = author,
        SendTime = sendTime,
        Text = text,
        Longitude = longitude,
        Latitude = latitude
      };
    }
  }
}