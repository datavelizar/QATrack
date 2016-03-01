using ArtOfTest.Common.UnitTesting;
using StageTelerikAcademy.Core.Pages.Admin.Evaluation.ParticipatingInTeamworkPagе;
using StageTelerikAcademy.Core.Pages.Admin.MainAdminPage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Admin.Teamwork.TeamMemberEvaluationsPage
{
    public class TeamMemberEvaluationsPageAsserter
    {
        public TeamMemberEvaluationsPageMap Map
        {
            get
            {
                return new TeamMemberEvaluationsPageMap();
            }
        }

        public AdminNavigationPageMap NavMap
        {
            get
            {
                return new AdminNavigationPageMap();
            }
        }

        public void IsLinkIsValid()
        {
            string expectedButtonHRef = "/Administration_Teamwork/TeamMemberAllEvaluations/ImportTeamworkEvaluations?returnControllerName=TeamMemberEvaluations";
            Assert.AreEqual(expectedButtonHRef,Map.UploadButton.HRef);
        }

        public void IsGoingBackToAdministration()
        {
            Assert.AreEqual(NavMap.AdminMenuInAdminNavPage.HRef, Map.BackToAdminButton.HRef);
        }
    }
}
