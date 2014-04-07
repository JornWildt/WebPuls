using Microsoft.Owin;
using Owin;


[assembly: OwinStartup(typeof(WebPuls.Startup))]
namespace WebPuls
{
  public class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      app.MapSignalR();
    }
  }
}
