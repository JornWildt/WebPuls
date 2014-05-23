using log4net;
using log4net.Config;
using System.Timers;
using System.Web.Mvc;
using System.Web.Routing;


namespace WebPuls
{
  public class Global : System.Web.HttpApplication
  {
    private static ILog Logger = LogManager.GetLogger(typeof(Global));


    protected void Application_Start()
    {
      XmlConfigurator.Configure();
      Logger.Debug("************************************************************************");
      Logger.Debug("START Web Puls");
      Logger.Debug("************************************************************************");

      AreaRegistration.RegisterAllAreas();
      RouteConfig.RegisterRoutes(RouteTable.Routes);

      Timer t = new Timer(2000);
      t.AutoReset = true;
      t.Elapsed += t_Elapsed;
      t.Start();
    }


    void t_Elapsed(object sender, ElapsedEventArgs e)
    {
      PulsConnection.AddBlimp("#400000", 10, 3000);
    }
  }
}
