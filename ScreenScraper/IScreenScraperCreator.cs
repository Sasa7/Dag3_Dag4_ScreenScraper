using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenScraper
{
    public interface IScreenScraperCreator
    {
        IScreenScraperService FactoryMethodCreateService(string type);
    }
}
