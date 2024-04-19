using Microsoft.Extensions.Logging;
using System;
using System.Configuration;
using System.Web.UI;
using System.Diagnostics;

namespace WebApplication1
{
    public partial class Contact : Page
    {
        private readonly ILogger<Contact> _logger;

        public Contact()
        {
            _logger = Global.CreateLogger<Contact>();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("page loaded");
            _logger.LogInformation("Page loaded"); // Log information about the page load
            string demotext = ConfigurationManager.AppSettings["demokeyvalue"];
            contactmessage.Text = demotext;
        }
    }
}