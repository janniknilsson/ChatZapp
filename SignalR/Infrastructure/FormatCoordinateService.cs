using System;

namespace SignalR.Infrastructure
{
  public class FormatCoordinateService
  {
    public static Double FormattedCoordonate { get; set; }
    public static double Format(string coordonate)
    {
      if(string.IsNullOrEmpty(coordonate))
        throw new ArgumentNullException("coordonate");
        coordonate = coordonate.Replace(".","");
        coordonate = coordonate.Insert(2, ",");
        double coord;
        double.TryParse(coordonate, out coord);
        FormattedCoordonate = coord;
   
      return FormattedCoordonate;
    }
  }
}