using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFramework.Core;
using StageTelerikAcademy.Core.Pages.LoginPage;
using TestingFramework.Utilities.Atributes;
using TestingFramework.Core.Constants;
using TestingFramework.Core.Data;
using StageTelerikAcademy.Core.Pages.Admin.Teamwork.TeamMemberEvaluationsPage;

namespace StageTelerikAcademy.Test.Admin.Teamwork
{
    [TestClass]
    public class TeamMemberEvaluations : BaseTest
    {
        private User currentUser;
        public LoginPage LoginPage { get; set; }

        public TeamMemberEvaluationsPage TeamMemberEvaluationsPage { get; set; }

        public override void TestInit()
        {
            currentUser = new User()
            {
                Username = "ilia.82",
                Password = "826682"
            };
            this.LoginPage = new LoginPage();
            this.TeamMemberEvaluationsPage = new TeamMemberEvaluationsPage();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [Priority(Priority.VeryHigh)]
        public void TeamMemberEvaluationsResultFileUploadLinkIsValid()
        {
            this.LoginPage.LoginUser(currentUser);
            this.TeamMemberEvaluationsPage.UploadFileLinkIsValid();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [TestCaseId(185)]
        [Priority(Priority.Low)]
        public void TeamMemberEvaluationsPagеBackToAdminPage()
        {
            this.LoginPage.LoginUser(currentUser);
            this.TeamMemberEvaluationsPage.BackToAdmin();
        }
    }
}
