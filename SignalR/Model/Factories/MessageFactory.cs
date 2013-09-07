using System;
using MongoDB.Bson;

namespace SignalR.Model.Factories
{
  public class MessageFactory
  {
    public static Message Create(string author, string groupId, string text, DateTime sendTime, Double latitude, Double longitude, string browser)
    {
      return new Message
      {
        Id = ObjectId.GenerateNewId(),
        GroupId = groupId,
        Author = author,
        SendTime = sendTime,
        Text = text,
        Longitude = longitude,
        Latitude = latitude,
        Browser = browser
      };
    }
  }
}