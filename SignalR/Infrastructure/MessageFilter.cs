using System.Collections.Generic;
using SignalR.Model;

namespace SignalR.Infrastructure
{
  public class MessageFilter
  {
    public static IEnumerable<Message> GetFilteredMessages(IEnumerable<Message> originalList, double latitude, double longitude, int radius)
    {
      foreach (Message message in originalList)
      {
        if (GeoDistanceCalculator.DistanceBetweenPlaces(latitude, longitude, message.Longitude, message.Latitude) < radius)
          yield return message;
      }
    }
  }
}