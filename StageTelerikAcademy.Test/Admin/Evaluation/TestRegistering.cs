using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Pages.LoginPage;
using StageTelerikAcademy.Core.Pages.TestRegisteringPage;
using TestingFramework.Utilities.Atributes;
using TestingFramework.Core.Constants;
using TestingFramework.Core;
using TestingFramework.Core.Data;

namespace StageTelerikAcademy.Test.Admin.Evaluation
{
    [TestClass]
    public class TestRegistering : BaseTest
    {
        private User currentUser;
        public LoginPage LoginPage { get; set; }
        public TestRegisteringPage TestRegisteringPage { get; set; }

        public override void TestInit()
        {
            currentUser = new User()
            {
                Username = "myadmin2",
                Password = "mypassword2"
            };
            this.LoginPage = new LoginPage();
            this.TestRegisteringPage = new TestRegisteringPage();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.High)]
        [TestCaseId("40")]
        public void RegisteringSuccess()
        {
            this.LoginPage.LoginUser(currentUser);
            this.TestRegisteringPage.AddFile();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Medium)]
        [TestCaseId("120")]
        public void CannotRegisterWithoutTest()
        {
            this.LoginPage.LoginUser(currentUser);
            this.TestRegisteringPage.AddingEmptyTestExamField();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Medium)]
        [TestCaseId("121")]
        public void CannotRegisterWithoutFile()
        {
            this.LoginPage.LoginUser(currentUser);
            this.TestRegisteringPage.AddingNotSelectedFile();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Medium)]
        [TestCaseId("186")]
        public void CannotRegisterWithoutCriteria()
        {
            this.LoginPage.LoginUser(currentUser);
            this.TestRegisteringPage.AddingEmptyCriteria();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Medium)]
        [TestCaseId("187")]
        public void CannotRegisterWithoutColumn()
        {
            this.LoginPage.LoginUser(currentUser);
            this.TestRegisteringPage.AddingEmptyTypeColumn();
        }
    }
}


//[TestMethod]
//[Owner(Author.Velizar)]
//[Priority(Priority.Medium)]
//public void EmptyRegisteringCriteria()
//{
//    this.LoginPage.LoginUser(currentUser);
//    this.TestRegisteringPage.AddingEmptyTypeColumn();
//}

