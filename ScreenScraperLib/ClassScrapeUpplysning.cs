using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenScraperLib
{
    public class ClassScrapeUpplysning : CompanyScraper
    {
        public override string GetUrl
        {
            get { return "http://www.upplysning.se/foretag/?x=395&what={0}"; }
        }
        public override string GetXpath
        {
            get { return "//*[@id='dataheader']/b"; }
        }
        public override string GetName
        {
            get { return "Upplysning.se"; }
        }
    }
}
