using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Admin.Teamwork.ImportTeamsPage
{
    public class ImportTeamsPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Administration_Teamwork/ImportTeams";

        public ImportTeamsPageMap Map { get { return new ImportTeamsPageMap(); } }

        public ImportTeamsPageAsserter Asserter { get { return new ImportTeamsPageAsserter(); } }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
        }

        public void SetCorrectDataForImportingTeams()
        {
            this.Navigate();
            Manager.Current.ActiveBrowser.ScrollBy(0, 500);
            this.Map.TeamworkListSpan.Click();
            this.Map.TeamworkList.Click();
            this.Map.SetNumberOfUsersInTeams.Click();
            this.Map.SetNumberOfUsersInTeams.Click();
        }
    }
}
