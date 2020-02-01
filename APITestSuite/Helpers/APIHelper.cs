using APITestSuite.Helpers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APITestSuite
{
    /// <summary>
    /// Class for constructing a API call
    /// </summary>
    class APIHelper
    {
        #region private member
        private HttpClient httpClient;
        #endregion
        #region COnstructor(s)
        /// <summary>
        /// COnstructor of the API Helper cLass
        /// </summary>
        /// <param name="Url">API URL by default reads from app.config</param>
        public APIHelper(string Url="")
        {
            if (String.IsNullOrWhiteSpace(Url))
                Url = ConfigurationManagerHelper.ApiURL;

            httpClient = new HttpClient
            {
                BaseAddress = new Uri(Url)
            };

            httpClient.DefaultRequestHeaders.Accept.
                Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        #endregion
        #region public properties of class
        public HttpClient APIClient
        {
            set
            {
                httpClient = value;
            }
            get
            {
                return httpClient;
            }
        }
        #endregion
        #region public methods
        /// <summary>
        /// Method for processing get request based on given API name
        /// </summary>
        /// <param name="ApiName"></param>
        /// <returns></returns>
        public async Task<string> ProcessRequestAsync(string ApiName)
        {
            string response = await httpClient.GetStringAsync(ApiName);
            return response;
        }
        #endregion
    }
}
