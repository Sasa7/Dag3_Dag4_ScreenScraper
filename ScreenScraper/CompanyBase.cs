using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ScreenScraper
{
    public abstract class CompanyBase: IScreenScraperService
    {
        public string GetCompanyNameByOrgNumber(long orgNumber)
        {
            HtmlWeb html = new HtmlWeb();
            string url = string.Format(this.Url, orgNumber);
            HtmlDocument doc = html.Load(url);

            HtmlNode companyName = doc.DocumentNode.SelectSingleNode(this.Xpath);

            return companyName.InnerHtml;
        }

        public abstract string Xpath { get; }

        public abstract string Url { get; }

    }
}
