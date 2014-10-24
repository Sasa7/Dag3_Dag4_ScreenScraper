using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScreenScraper;
using System.Diagnostics;
using System.Threading.Tasks;

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

            var result = service.GetCompanyNameByOrgNumber(orgNumber);
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

        [TestMethod]
        public void TestAllCompanies()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            Find_Company_AllaBolag_ByOrgNumber();
            Find_Company_HittaSe_By_OrgNr();
            Find_Company_Upplysning_By_OrgNr();

            stopWatch.Stop();
            Trace.WriteLine("Alla anrop sekventiellt: " + stopWatch.Elapsed);

            stopWatch.Reset();

            stopWatch.Start();

            var tasks = new[]
            {
                Task.Factory.StartNew(Find_Company_AllaBolag_ByOrgNumber),
                Task.Factory.StartNew(Find_Company_HittaSe_By_OrgNr),
                Task.Factory.StartNew(Find_Company_Upplysning_By_OrgNr)
            };

            Task.WaitAll(tasks);
            stopWatch.Stop();

            Trace.WriteLine("Alla anrop parallellt: " + stopWatch.Elapsed);
        }
    }

     
}
