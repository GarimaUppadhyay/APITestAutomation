using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestSuite.AcceptanceCriteria
{
    /// <summary>
    /// Class for maintaining the different acceptance criteria/expected results for 
    /// different elements of Category Details API call
    /// </summary>
    public static class CategoryDetailsAcceptance
    {
        public static string CATEGORY_APINAME = "Categories/6327/Details.json?catalogue=false";
        public static string CATEGORY_NAME = "Carbon credits";
        public static string CATEGORY_CANRELIST = "true";
        public static string CATEGORY_PROMOTIONS_NAME = "Gallery";
        public static string CATEGORY_PROMOTIONS_PARTIALDESC = "2x larger image";
    }

    /// <summary>
    /// Class containing the JSON paths for various element in the API response
    /// </summary>
    public static class CategoryDetailsLocators
    {
        public static string CATEGORY_NAME = "$.Name";
        public static string CATEGOTY_CANRELIST = "$.CanRelist";
        public static string CATEGORY_PROMOTIONS_PARTIALDESC = "$.Promotions[?(@.Name=='" + 
            CategoryDetailsAcceptance.CATEGORY_PROMOTIONS_NAME +"')].Description";
    }
}
