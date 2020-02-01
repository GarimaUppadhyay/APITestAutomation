using System;
using APITestSuite.AcceptanceCriteria;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace APITestSuite
{
    [TestClass]
    public class VerifyCategoryDetailsAPI
    {
        APIHelper ApiHelper;
        string Response;

        [TestInitialize]
        public async System.Threading.Tasks.Task SetupAsync()
        {
            ApiHelper = new APIHelper();
            Response = await ApiHelper.ProcessRequestAsync(CategoryDetailsAcceptance.CATEGORY_APINAME);
        }
        [TestMethod]
        [TestCategory("Basic HttpClient Test")]
        public void VerifyCategoryName()
        {
            Assert.IsTrue(APIValidator.VerifyAPIResponse(Response, CategoryDetailsAcceptance.CATEGORY_NAME, CategoryDetailsLocators.CATEGORY_NAME), 
                "Validating categoryName Property having value Carbon credits");
        }
        [TestMethod]
        [TestCategory("Basic HttpClient Test")]
        public void VerifyCategorysCanReListPropertyValue()
        {
            Assert.IsTrue(APIValidator.VerifyAPIResponse(Response, CategoryDetailsAcceptance.CATEGORY_CANRELIST, CategoryDetailsLocators.CATEGOTY_CANRELIST),
                "Validating CanReList Property is true");
        }
        [TestMethod]
        [TestCategory("Basic HttpClient Test")]
        public void VerifyDescriptionForPromotionElementWithNameGallery()
        {
            Assert.IsTrue(APIValidator.VerifyAPIResponse(Response, CategoryDetailsAcceptance.CATEGORY_PROMOTIONS_PARTIALDESC, 
                CategoryDetailsLocators.CATEGORY_PROMOTIONS_PARTIALDESC, ValidationType.CONTAINS),
                "Validating if description associated with Promotion element contains 2x larger image");
        }

        [TestCleanup]
        public void CleanUp()
        {
            //ApiHelper.Dispose();
        }
    }
}
