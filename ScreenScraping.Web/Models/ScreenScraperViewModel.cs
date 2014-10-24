using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScreenScraping.Web.Models
{
    public class ScreenScraperViewModel
    {
        public ScreenScraperViewModel()
        {
            DropDownItems = new List<SelectListItem>
            {
                new SelectListItem {Text = "Alla Bolag", Value = "allabolag"},
                new SelectListItem {Text = "Eniro", Value = "eniro"},
                new SelectListItem {Text = "Hitta.se", Value = "hittase"},
                new SelectListItem {Text = "Upplysning.se", Value = "upplysning"}
            };
        }

        [Required(ErrorMessage = "Enter correct value")]

        public long ORGNumber{ get; set; }

        public string CompanyName { get; set; }

        public string SelectedListItem { get; set; }

        public List<SelectListItem> DropDownItems { get; set; }
    }
}