using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.Frontend.TeamworkListPage
{
    public class TeamworkListPageMap : BaseElementMap
    {
        public HtmlDiv ShowScore
        {
            get
            {
                return this.Find.ByAttributes<HtmlDiv>("data-userid=5","class=ratePartner");
            }
        }

       
    }
}
