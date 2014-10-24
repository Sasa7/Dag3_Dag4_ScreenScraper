using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenScraper
{
    public class ScreenScraperCreator: IScreenScraperCreator
    {
        public IScreenScraperService FactoryMethodCreateService(string type)
        {
            IScreenScraperService service = null;
            switch(type)
            {
                case "allabolag": service = new AllaBolagScreenScraperService();
                    break;
                case "eniro": service = new EniroScreenScraperService();
                    break;
                case "hittase": service = new HittaSeScreenScraperService();
                    break;
                case "upplysning": service = new UpplysningScreenScraperService();
                    break;
                default:
                    break;
            }
            return service;
        }
    }
}
