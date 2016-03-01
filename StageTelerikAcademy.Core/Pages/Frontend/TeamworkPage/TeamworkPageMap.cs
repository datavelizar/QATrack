using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;

namespace StageTelerikAcademy.Core.Pages.Frontend.TeamworkPage
{
    public class TeamworkPageMap : BaseElementMap
    {
        public HtmlAnchor TeamworkName
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("textContent=ДСА2016 - Create teamwork", "href=/Courses/Courses/Details/246");
            }
        }

        public HtmlControl TeamMatesNamePanel
        {
            get
            {
                return this.Find.ByXPath<HtmlControl>("//*[@id='MainContent']/div/div[1]");
            }
        }

        public HtmlDiv TeamMateName
        {
            get
            {
                return this.Find.ByXPath<HtmlDiv>(".//*[@id='MainContent']/div/div[1]/div[2]/div[3]/div[2]/form/div[1]/div[1]/a/div[2]");
            }
        }

    }
}
