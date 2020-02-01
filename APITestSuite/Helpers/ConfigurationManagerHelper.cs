using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestSuite.Helpers
{
    /// <summary>
    /// Class for reading App.Config file and providing corresponding 
    /// values to requesting classes/methods
    /// </summary>
    public static class ConfigurationManagerHelper
    {
        /// <summary>
        /// Property for providing API URL to tests
        /// </summary>
        public static string ApiURL
        {
            get
            {
                return ConfigurationManager.AppSettings["apiurl"];
            }
        }
    }
}
