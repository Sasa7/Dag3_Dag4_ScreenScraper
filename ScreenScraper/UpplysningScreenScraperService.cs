using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenScraper
{
    public class UpplysningScreenScraperService: CompanyBase
    {
        public override string Url
        {
            get { return "http://www.upplysning.se/{0}"; }
        }

        public override string Xpath
        {
            get { return @"/html/head/title"; }
        }
    }
}
