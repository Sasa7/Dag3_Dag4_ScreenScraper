using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScreenScraper;

namespace ScreenScraperTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Find_Company_AllaBolag_ByOrgNumber()
        {
            //Arrange
            var orgNumber = 5565995239;
            var expectedCompany = "Mattias Asplund Aktiebolag";

            IScreenScraperService service = new AllaBolagScreenScraperService();

            //Act

            var result = service.GetCompanyNameByOrgNumber(5565995239);
            //Assert
            Assert.AreEqual(expectedCompany, result);
        }

        [TestMethod]
        public void Find_Company_HittaSe_By_OrgNr()
        {
            //ARRANGE
            long orgNr = 5565995239;
            string company = "Mattias Asplund AB";

            IScreenScraperService screenScraperService = new HittaSeScreenScraperService();

            //ACT
            var result = screenScraperService.GetCompanyNameByOrgNumber(orgNr);

            //ASSERT
            Assert.AreEqual(company, result);
        }

        [TestMethod]
        public void Find_Company_Eniro_By_OrgNr()
        {
            //ARRANGE
            //long orgNr = 5565995239;
            //string company = "Mattias Asplund Aktiebolag";

            //IScreenScraperService screenScraperService = new EniroScreenScraperService();

            ////ACT
            //var result = screenScraperService.GetCompanyNameByOrgNumber(orgNr);

            ////ASSERT
            //Assert.AreEqual(company, result);
        }

        [TestMethod]
        public void Find_Company_Upplysning_By_OrgNr()
        {
            //ARRANGE
            long orgNr = 5565995239;
            string company = "Mattias Asplund Aktiebolag";

            IScreenScraperService screenScraperService = new UpplysningScreenScraperService();

            //ACT
            var result = screenScraperService.GetCompanyNameByOrgNumber(orgNr);

            //ASSERT
            Assert.AreEqual(company, result);
        }
    }

     
}
