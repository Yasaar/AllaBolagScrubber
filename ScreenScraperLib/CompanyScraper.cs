using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace ScreenScraperLib
{
    public abstract class CompanyScraper : IScrapeService
    {
        public virtual string GetUrl { get; set; }
        public virtual string GetXpath { get; set; }
        public virtual string GetName { get; set; }

        public string findNameByOrgID(string OrgID)
        {
            var getHtmlWeb = new HtmlWeb();
            string orgName = string.Empty;

            HtmlDocument document = getHtmlWeb.Load(String.Format(GetUrl, OrgID.Replace("-", "")));

            var nodes = document.DocumentNode.SelectNodes(GetXpath);

            

           
            foreach (var name in nodes)
            {
               
                orgName = "Från " + GetName + " " + name.InnerText;
            }

            return orgName;
        }
        public async Task<string> findNameByOrgIDAsync(string OrgID)
        {
            var getHtmlWeb = new HtmlWeb();
            string orgName = string.Empty;

            HtmlDocument document = getHtmlWeb.Load(String.Format(GetUrl, OrgID.Replace("-", "")));

            var nodes = document.DocumentNode.SelectNodes(GetXpath);
            foreach (var name in nodes)
            {
                orgName = "Från " + GetName + " " + name.InnerText;
            }

            return orgName;
        }
    }
}
