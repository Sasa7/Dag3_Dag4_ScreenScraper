using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenScraper
{
    public class HittaSeScreenScraperService: CompanyBase
    {
        public override string Url
        {
            get { return "http://www.hitta.se/sök?vad={0}"; }
        }

        public override string Xpath
        {
            get { return @"id('company-financials')/h2"; }
        }
    }
}
