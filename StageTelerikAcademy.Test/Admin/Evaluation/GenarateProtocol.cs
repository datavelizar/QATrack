using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFramework.Utilities.Atributes;
using TestingFramework.Core.Constants;
using TestingFramework.Core;
using TestingFramework.Core.Data;
using StageTelerikAcademy.Core.Pages.LoginPage;
using StageTelerikAcademy.Core.Pages.EvaluationGenerateProtocolPage;

namespace StageTelerikAcademy.Test.Admin.Evaluation
{
    [TestClass]
    public class GenarateProtocol : BaseTest
    {
        private User currentUser;
        public LoginPage LoginPage { get; set; }

        public GenerateProtocolPage GenerateProtocolPage { get; set; }

        public override void TestInit()
        {
            currentUser = new User()
            {
                Username = "ilia.82",
                Password = "826682"
            };
            this.LoginPage = new LoginPage();
            this.GenerateProtocolPage = new GenerateProtocolPage();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [TestCaseId(27)]
        [Priority(Priority.High)]
        public void ValidateLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.GenerateProtocolPage.ValidateLink();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [TestCaseId(64)]
        [Priority(Priority.High)]
        public void DownloadProtocolFileSuccesfuly()
        {
            this.LoginPage.LoginUser(currentUser);
            this.GenerateProtocolPage.GenarateProtocolResultWithCorrectData();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [Priority(Priority.High)]
        [TestCaseId(181)]
        public void DownloadProtocolFileWithOneSelectionNotSuccesfuly()
        {
            this.LoginPage.LoginUser(currentUser);
            this.GenerateProtocolPage.GenarateProtocolResultWithOneSelection();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [TestCaseId(182)]
        [Priority(Priority.Medium)]
        public void DownloadProtocolFileNotSuccesfuly()
        {
            this.LoginPage.LoginUser(currentUser);
            this.GenerateProtocolPage.GenarateProtocolResultWithNoSelection();
        }
    }
}
