using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SignalR.Model
{
  public class Message
  {
    [BsonId]
    public ObjectId Id { get; set; }
    public string GroupId { get; set; }

    public string Author { get; set; }
    public string Text { get; set; }
    public DateTime SendTime { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
  }
}