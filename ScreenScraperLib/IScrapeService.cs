using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ScreenScraperLib
{
    public interface IScrapeService
    {
        string findNameByOrgID(string OrgID);
        Task<string> findNameByOrgIDAsync(string OrgID);
    }
}
