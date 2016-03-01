using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Admin.Teamwork.TeamMemberEvaluationsPage
{
    public class TeamMemberEvaluationsPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Administration_Teamwork/TeamMemberEvaluations";

        public TeamMemberEvaluationsPageMap Map
        {
            get
            {
                return new TeamMemberEvaluationsPageMap();
            }
        }

        public TeamMemberEvaluationsPageAsserter Asserter
        {
            get
            {
                return new TeamMemberEvaluationsPageAsserter();
            }
        }

        public void UploadFileLinkIsValid()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            this.Map.UploadButton.ScrollToVisible();

            this.Asserter.IsLinkIsValid();

        }
        public void BackToAdmin()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            this.Map.BackToAdminButton.ScrollToVisible();
            this.Asserter.IsGoingBackToAdministration();

        }
    }
}
