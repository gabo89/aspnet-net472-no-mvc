using Microsoft.Extensions.Logging;
using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;


namespace WebApplication1
{
    public class Global : HttpApplication
    {
        private static ILoggerFactory _loggerFactory;
        void Application_Start(object sender, EventArgs e)
        {
            ConfigureLogging();
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        private void ConfigureLogging()
        {
            _loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole(); // Example: Adding console logger
                // Add more logging providers as needed (e.g., Debug, File, etc.)
            });
        }

        public static ILogger<T> CreateLogger<T>() => _loggerFactory.CreateLogger<T>();

    }
}