using Microsoft.Extensions.Logging;
using System;
using System.Configuration;
using System.Web.UI;

namespace WebApplication1
{
    public partial class Contact : Page
    {
        private readonly ILogger<Contact> _logger;

        public Contact(ILogger<Contact> logger)
        {
            _logger = logger;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            _logger.LogInformation("Page loaded"); // Log information about the page load
            string demotext = ConfigurationManager.AppSettings["demokeyvalue"];
            contactmessage.Text = demotext;
        }
    }
}