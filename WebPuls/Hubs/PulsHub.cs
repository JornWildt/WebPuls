using Microsoft.AspNet.SignalR;


namespace WebPuls.Hubs
{
  public class PulsHub : Hub
  {
    public void AddBlimp(int x, int y, string color, int size, int lifetime)
    {
      Clients.All.addBlimp(x, y, color, size, lifetime);
    }
  }
}