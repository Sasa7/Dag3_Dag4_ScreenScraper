using ScreenScraper;
using ScreenScraping.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScreenScraping.Web.Controllers
{
    public class HomeController : Controller
    {
        private IScreenScraperCreator creatorService;
        public HomeController(IScreenScraperCreator creatorService)
        {
            this.creatorService = creatorService;
        }

        public ActionResult Index(string message)
        {
            var viewModel = new ScreenScraperViewModel();
            viewModel.ORGNumber = 5565995239;
            if (!string.IsNullOrEmpty(message))
                viewModel.CompanyName = message;

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(ScreenScraperViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            IScreenScraperService service = creatorService.FactoryMethodCreateService(model.SelectedListItem);

            var name = service.GetCompanyNameByOrgNumber(model.ORGNumber);

            var company = model.DropDownItems.FirstOrDefault(c => c.Value == model.SelectedListItem);
            var companyName = string.Empty;
            if (company != null)
            {
                companyName = company.Text + ": ";
            }

            return RedirectToAction("Index", "Home", new { message = companyName + name });
        }

    }
}
