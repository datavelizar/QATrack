using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Frontend.TeamworkPage
{
    public class TeamworkPage
    {
        public readonly string url = "http://stage.telerikacademy.com/Courses/Teamwork/List";

        public TeamworkPageMap Map
        {
            get
            {
                return new TeamworkPageMap();
            }

        }

        public void ClickTeamworkNameLink()
        {
            Manager.Current.ActiveBrowser.NavigateTo(url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.TeamworkName.Click();
        }

        public void TeamMemberCheck()
        {
            Manager.Current.ActiveBrowser.NavigateTo(url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.TeamMatesNamePanel.ScrollToVisible();
        }
    }
}
