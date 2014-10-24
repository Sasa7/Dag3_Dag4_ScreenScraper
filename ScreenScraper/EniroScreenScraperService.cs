using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenScraper
{
    public class EniroScreenScraperService: CompanyBase
    {


        public override string Url
        {
            get { return "http://gulasidorna.eniro.se/hitta:{0}"; }
        }

        public override string Xpath
        {
            get { return "//*[@id='hit-list']/li/article/header/div[2]/h2/span/a"; }

        }
    }
}
