using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestSuite
{
    /// <summary>
    /// Static class for providing various methods for response data validation
    /// </summary>
    public static class APIValidator
    {
        /// <summary>
        /// Method for validation JSON response based on given Expected Data and JSON path
        /// </summary>
        /// <param name="Response">JSON Response</param>
        /// <param name="ExpectedResult">Expected Data</param>
        /// <param name="JsonPath">JPATH for element</param>
        /// <param name="type">Validation type exact or contains</param>
        /// <returns></returns>
        public static bool VerifyAPIResponse(string Response, string ExpectedResult, string JsonPath, 
            ValidationType type = ValidationType.EQUALS)
        {
            bool result = true;
            try
            {
                #region converting all strings to lowercase for comparision and forming jsin object 
                ExpectedResult = ExpectedResult.ToLower();
                JObject json = JObject.Parse(Response);
                #endregion
                #region Querying the Jobject using Json Path to extarct the actual value
                string ActualResult = json.SelectToken(JsonPath).ToString().ToLower();
                string testResult = "Passed!!!";
                #endregion
                #region Validation as per validation type i.e. EQUALS or Contains
                switch(type)
                {
                    case ValidationType.EQUALS:
                        result = ExpectedResult.Equals(ActualResult);
                        break;

                    case ValidationType.CONTAINS:
                        result = ActualResult.Contains(ExpectedResult);
                        break;

                    case ValidationType.NOTEQUALS:
                        result = !(ExpectedResult.Equals(ActualResult));
                        break;

                    case ValidationType.DOESNOTCONTAINS:
                        result = !(ActualResult.Contains(ExpectedResult));
                        break;

                    default:
                        result = ExpectedResult.Equals(ActualResult);
                        break;
                }
                #endregion
                #region Computing and logging correct results in console
                if (!result)
                {
                    testResult = "Failed!!!";
                }
                Console.WriteLine("Test {2} Actual Value is: {1} AND Expected Value was: {0} \n Validation was: {3}", 
                    ExpectedResult, ActualResult, testResult, type);
                #endregion
            }
            catch (Exception e)
            {
                result = false;
                Console.WriteLine("Failed to find matching element with Json path {0} and corresponding code error is: {1}", JsonPath, e.Message);
            }
            return result;
        }
    }

    /// <summary>
    /// Various Validation Types
    /// </summary>
    public enum ValidationType
    {
        EQUALS,
        CONTAINS,
        NOTEQUALS,
        DOESNOTCONTAINS
    }
}
