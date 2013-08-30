using System;
using MongoDB.Driver;

namespace SignalR.Infrastructure
{
  public class MongoDataProvider
  {
    public static MongoDatabase Get()
    {
      const string connectionString = "mongodb://localhost";
      MongoClient client = new MongoClient(connectionString);
      var server = client.GetServer();
      if (server == null)
      {
        throw new NullReferenceException("Mongo server could not be found");
      }
      return server.GetDatabase("SignalR");
    }
  }
}