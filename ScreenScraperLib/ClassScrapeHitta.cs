using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenScraperLib
{
    public class ClassScrapeHitta : CompanyScraper
    {
        public override string GetUrl
        {
            get { return "http://www.hitta.se/sök?vad={0}"; }
        }

        public override string GetXpath
        {
            get { return "//*[@id='item-details']/html[1]/body[1]/div[2]/div[1]/section[1]"; }
        }
        public override string GetName
        {
            get { return "Hitta.se"; }
        }
    }
}
