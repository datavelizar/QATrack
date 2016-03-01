using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Pages.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Utilities.Atributes;
using TestingFramework.Core.Constants;
using TestingFramework.Core;
using TestingFramework.Core.Data;
using StageTelerikAcademy.Core.Pages.Frontend.TeamworkListPage;

namespace StageTelerikAcademy.Test.Frontend
{
    [TestClass]
    public class TeammatesEvaluation : BaseTest
    {
        private User currentUser;
        public LoginPage LoginPage { get; set; }

        public TeamworkListPage TeamworkListPage {get; set;}
        
        public override void TestInit()
        {
            currentUser = new User()
            {
                Username = "TeamArcher",
                Password = "teamarcher"
            };
            this.LoginPage = new LoginPage();
            this.TeamworkListPage = new TeamworkListPage();
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.VeryHigh)]
        public void TestMethod1()
        {
            this.LoginPage.LoginUser(currentUser);
            this.TeamworkListPage.GradeTeammate();
        }
    }
}
