using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenScraperLib
{
    public class ClassScrapeAllaBolag : CompanyScraper
    {
        public override string GetUrl
        {
            get { return "http://www.allabolag.se/{0}"; }
        }

        public override string GetXpath
        {
            get { return "//*[@id='printTitle']"; }
        }
        public override string GetName
        {
            get { return "Allabolag.se"; }
        }
    }
}
