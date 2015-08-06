using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenScraperLib
{
    public class ClassScrapeEniro : CompanyScraper
    {
        public override string GetUrl
        {
            get { return "http://gulasidorna.eniro.se/hitta:{0}"; }
        }
        public override string GetXpath
        {
            get { return "//*[@id='hit-list']/li/article/header/div[2]/h2/span/a"; }
        }
        public override string GetName
        {
            get { return "Eniro.se"; }
        }
    }
}
