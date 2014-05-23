using Microsoft.Owin;
using Owin;
using log4net;


[assembly: OwinStartup(typeof(WebPuls.Startup))]
namespace WebPuls
{
  public class Startup
  {
    static ILog Logger = LogManager.GetLogger(typeof(Startup));

    public void Configuration(IAppBuilder app)
    {
      Logger.Debug("*** Starting WebPuls");
      app.MapSignalR();
    }
  }
}
