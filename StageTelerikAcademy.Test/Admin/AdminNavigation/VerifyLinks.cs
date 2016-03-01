using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Pages.Admin.MainAdminPage;
using StageTelerikAcademy.Core.Pages.LoginPage;
using TestingFramework.Utilities.Atributes;
using TestingFramework.Core.Constants;
using TestingFramework.Core;
using TestingFramework.Core.Data;

namespace StageTelerikAcademy.Test.Admin.AdminNavigation
{
    [TestClass]
    public class VerifyLinks : BaseTest
    {
        private User currentUser;
        public LoginPage LoginPage { get; set; }

        public AdminNavigationPage AdminNavigationPage { get; set; }
        public AdminNavigationPageAsserter AdminNavigationPageAsserter { get; set; }

        public override void TestInit()
        {
            currentUser = new User()
            {
                Username = "TeamArcher",
                Password = "teamarcher"
            };
            this.LoginPage = new LoginPage();
            this.AdminNavigationPage = new AdminNavigationPage();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
        public void VerifyGenerateProtocolLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateGeneralProtocolLink();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
        public void VerifyProtocolsWithFinalResultsLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateProtocolsWithFinalResults();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
        public void VerifyEvaluationExportResultsLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateEvaluationExportResults();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
        public void VerifyUsersInCoursesBonusesLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateUsersInCoursesBonuses();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [Priority(Priority.High)]
        public void VerifyHomeworkEvaluationLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateHomeworkEvaluation();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [Priority(Priority.High)]
        public void VerifyUserInCourseHelpersLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateUserInCourseHelpers();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [Priority(Priority.High)]
        public void VerifyHomeworkStatisticsLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateHomeworkStatistics();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [Priority(Priority.High)]
        public void VerifyHomeworkEvaluationReactionsLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateHomeworkEvaluationReactions();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [Priority(Priority.High)]
        public void VerifyAddStudentsLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateAddStudents();
        }

        //Teamwork

        [TestMethod]
        [Owner(Author.Ilia)]
        [Priority(Priority.High)]
        public void VerifyStudentsInTeamsLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateStudentsInTeams();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [Priority(Priority.High)]
        public void VerifyParticipatingInTeamworkLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateParticipatingInTeamwork();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [Priority(Priority.High)]
        public void VerifyImportTeamsLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateImportTeams();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [Priority(Priority.High)]
        public void VerifyTeamNameSuggestionsLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateTeamNameSuggestions();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [Priority(Priority.High)]
        public void VerifyImportTeamNamesLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateImportTeamNames();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [Priority(Priority.High)]
        public void VerifyTeamMemberEvaluationsLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateTeamMemberEvaluations();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [Priority(Priority.High)]
        public void VerifyTeamMemberAllEvaluations()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AdminNavigationPage.ValidateTeamMemberAllEvaluations();
        }
    }
}
