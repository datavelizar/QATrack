using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Pages.LoginPage;
using TestingFramework.Core;
using TestingFramework.Core.Data;
using TestingFramework.Utilities.Atributes;
using TestingFramework.Core.Constants;
using StageTelerikAcademy.Core.Pages.Teamwork.ImportOfTeamNamesPage;

namespace StageTelerikAcademy.Test.Admin.Teamwork
{
    [TestClass]
    public class ImportOfTeamsNames : BaseTest
    {
        private User currentUser;
        public LoginPage LoginPage { get; set; }
        public ImportOfTeamNamesPage ImportOfTeamNamesPage { get; set; }

        public override void TestInit()
        {
            currentUser = new User()
            {
                Username = "myadmin2",
                Password = "mypassword2"
            };
            this.LoginPage = new LoginPage();
            this.ImportOfTeamNamesPage = new ImportOfTeamNamesPage();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.High)]
        [TestCaseId("55")]
        public void ImportTeamNamesSuccess()
        {
            this.LoginPage.LoginUser(currentUser);
            this.ImportOfTeamNamesPage.ImportTeamNames();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Medium)]
        [TestCaseId("128")]
        public void CannotImportWithoutType()
        {
            this.LoginPage.LoginUser(currentUser);
            this.ImportOfTeamNamesPage.EmptyTeamNamesFieldCheck();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Medium)]
        [TestCaseId("129")]
        public void CannotImportWithoutFile()
        {
            this.LoginPage.LoginUser(currentUser);
            this.ImportOfTeamNamesPage.NotSelectedFile();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Medium)]
        [TestCaseId("188")]
        public void CannotImportWithoutColumn()
        {
            this.LoginPage.LoginUser(currentUser);
            this.ImportOfTeamNamesPage.EmptyTypeColumn();
        }
        
        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Medium)]
        [TestCaseId("189")]
        public void DisplaySelectedFileTitle()
        {
            this.LoginPage.LoginUser(currentUser);
            this.ImportOfTeamNamesPage.SelectFile();
        }
    }
}
