using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFramework.Core;
using TestingFramework.Core.Data;
using StageTelerikAcademy.Core.Pages.LoginPage;
using TestingFramework.Utilities.Atributes;
using TestingFramework.Core.Constants;

namespace StageTelerikAcademy.Test
{
    [TestClass]
    public class Login : BaseTest
    {
        private User currentUser;
        public LoginPage LoginPage { get; set; }

        public override void TestInit()
        {
            currentUser = new User()
            {
                Username = "TeamArcher",
                Password = "teamarcher"
            };
            this.LoginPage = new LoginPage();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.VeryHigh)]
        public void LoginWithAdminUser()
        {
            this.LoginPage.LoginUser(currentUser); 
        }
    }
}
