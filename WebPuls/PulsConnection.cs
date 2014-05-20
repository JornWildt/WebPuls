using log4net;
using Microsoft.AspNet.SignalR;
using System;
using WebPuls.Hubs;


namespace WebPuls
{
  public static class PulsConnection
  {
    private static ILog Logger = LogManager.GetLogger(typeof(PulsConnection));
    private static Random Randomizer = new Random();


    /// <summary>
    /// Add blinking circle to output.
    /// </summary>
    /// <param name="color">Hex color code for CSS.</param>
    /// <param name="size">Circle diameter in pixels.</param>
    /// <param name="lifetime">Lifetime of circle in mili seconds.</param>
    public static void AddBlimp(string color, int size, int lifetime)
    {
      int x = Randomizer.Next(100);
      int y = Randomizer.Next(100);
      Logger.DebugFormat("AddBlimp({0},{1},{2},{3},{4})", x, y, color, size, lifetime);
      GlobalHost.ConnectionManager.GetHubContext<PulsHub>().Clients.All.AddBlimp(x, y, color, size, lifetime);
    }
  }
}
