using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.Admin.Teamwork.ImportTeamsPage
{
    public class ImportTeamsPageMap : BaseElementMap
    {
        public HtmlSpan TeamworkListSpan
        {
            get
            {
                //Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression(".//*[@id='MainContent']/div/form/table[1]/tbody/tr[1]/td[1]/span/span/span[1]"), 5000, false);
                return this.Find.ByXPath<HtmlSpan>(".//*[@id='MainContent']/div/form/table[1]/tbody/tr[1]/td[1]/span/span/span[1]");
            }
        }

        public HtmlDiv DivTeamworkList
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=TeamworkId-list"), 5000, false);
                return this.Find.ById<HtmlDiv>("TeamworkId-list");
            }
        }

        public HtmlUnorderedList UlTeamworkList
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=TeamworkId_listbox"), 5000, false);
                return this.DivTeamworkList.Find.ById<HtmlUnorderedList>("TeamworkId_listbox");
            }
        }

        public HtmlListItem TeamworkList
        {
            get
            {
                return this.UlTeamworkList.Find.ByExpression<HtmlListItem>("innerText=Бази данни - Team ArcherTeamwork");
            }
        }

        public HtmlSpan SetNumberOfUsersInTeams
        {
            get
            {
                return this.Find.ByExpression<HtmlSpan>("class=k-icon k-i-arrow-n");
            }
        }
    }
}
