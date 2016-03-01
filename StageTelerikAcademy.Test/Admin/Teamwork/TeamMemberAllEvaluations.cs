using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Pages.Admin.Teamwork.TeamMemberAllEvaluationsPage;
using StageTelerikAcademy.Core.Pages.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;
using TestingFramework.Core.Data;
using TestingFramework.Utilities.Atributes;
using TestingFramework.Core.Constants;

namespace StageTelerikAcademy.Test.Admin.Teamwork
{
    [TestClass]
    public class TeamMemberAllEvaluations : BaseTest
    {
        private User adminUser;
        public LoginPage LoginPage { get; set; }
        public TeamMemberAllEvaluationsPage TeamMemberAllEvaluationsPage { get; set; }
        public readonly string CourseName = "StudentsRecords";

        public override void TestInit()
        {
            adminUser = new User()
            {
                Username = "TeamArcher",
                Password = "teamarcher"
            };

            this.LoginPage = new LoginPage();
            this.TeamMemberAllEvaluationsPage = new TeamMemberAllEvaluationsPage();
        }


        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
        [TestCaseId(114)]
        public void DownloadTeamMemberAllEvaluationsExcelFileSuccessfully()
        {
            this.LoginPage.LoginUser(adminUser);
            this.TeamMemberAllEvaluationsPage.ExportTeamMemberAllEvaluationsExcelResults(CourseName);
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
		[TestCaseId(113)]
        public void DownloadTeamMemberAllEvaluationsFilePdfSuccessfully()
        {
            this.LoginPage.LoginUser(adminUser);
            this.TeamMemberAllEvaluationsPage.ExportTeamMemberAllEvaluationsPdfResults(CourseName);
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.Medium)]
        [TestCaseId(178)]
        public void ValidateAdminNavigationPage()
        {
            this.LoginPage.LoginUser(adminUser);
            this.TeamMemberAllEvaluationsPage.ValidateAdminNavigation();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.Medium)]
        [TestCaseId(177)]
        public void ValidatePopUpWindow()
        {
            this.LoginPage.LoginUser(adminUser);
            this.TeamMemberAllEvaluationsPage.UpdateRowInGrid();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
        [TestCaseId(176)]
        public void VerifyDeletingRowInGrid()
        {
            this.LoginPage.LoginUser(adminUser);
            this.TeamMemberAllEvaluationsPage.DeleteRowInGrid();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
        [TestCaseId(116)]
        public void VerifyAddingFileInGrid()
        {
            this.LoginPage.LoginUser(adminUser);
            this.TeamMemberAllEvaluationsPage.EnterDataTeamMemberAllEvaluations();
        }
    }
}
