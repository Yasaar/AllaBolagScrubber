using System;
using ScreenScraperLib;

namespace AllaBolagScrubber
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            IScrapeService o = ScrapeServiceFactory.CreateScrapeService(DropDownList1.SelectedValue);
           mindiv.InnerHtml = o.findNameByOrgID(Text1.Value);

        }
    }

}