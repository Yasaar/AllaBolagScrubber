using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ScreenScraperLib;

namespace AllaBolagScrubber
{
    public static class ScrapeServiceFactory
    {

        public static IScrapeService CreateScrapeService(string type)
        {
            IScrapeService service = null;
            switch (type)
            {
                case "Hitta.se":
                    service = new ClassScrapeHitta();
                    break;
                case "Allabolag.se":
                    service = new ClassScrapeAllaBolag();
                    break;
                case "Eniro.se":
                    service = new ClassScrapeEniro();
                    break;
                case "Upplysning.se":
                    service = new ClassScrapeUpplysning();
                    break;

            }

            return service;
        }
    }
}