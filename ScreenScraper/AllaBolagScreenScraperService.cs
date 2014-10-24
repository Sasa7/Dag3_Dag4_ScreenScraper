using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenScraper
{
    public class AllaBolagScreenScraperService: CompanyBase
    {

        public override string Xpath
        {
            get { return "//*[@id='printTitle']"; }
        }

        public override string Url
        {
            get { return "http://www.allabolag.se/{0}"; }
        }
    }
}
