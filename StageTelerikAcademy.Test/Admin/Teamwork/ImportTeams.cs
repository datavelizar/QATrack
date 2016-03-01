using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Pages.Admin.Teamwork.ImportTeamsPage;
using StageTelerikAcademy.Core.Pages.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;
using TestingFramework.Core.Constants;
using TestingFramework.Core.Data;
using TestingFramework.Utilities.Atributes;

namespace StageTelerikAcademy.Test.Admin.Teamwork
{
    [TestClass]
    public class ImportTeams : BaseTest
    {
        private User currentUser;
        public LoginPage LoginPage { get; set; }

        public ImportTeamsPage ImportTeamsPage { get; set; }

        public override void TestInit()
        {
            currentUser = new User()
            {
                Username = "TeamArcher",
                Password = "teamarcher"
            };
            this.LoginPage = new LoginPage();
            this.ImportTeamsPage = new ImportTeamsPage();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [TestCaseId(183)]
        [Priority(Priority.High)]
        public void SetCorrectDataForImportingTeamsTeamImports()
        {
            this.LoginPage.LoginUser(currentUser);
            this.ImportTeamsPage.SetCorrectDataForImportingTeams();
        }
    }
}
