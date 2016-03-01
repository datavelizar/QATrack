using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFramework.Core;
using TestingFramework.Core.Data;
using StageTelerikAcademy.Core.Pages.LoginPage;
using StageTelerikAcademy.Core.Pages.AddBonusPage;
using TestingFramework.Utilities.Atributes;
using TestingFramework.Core.Constants;
using System.IO;

namespace StageTelerikAcademy.Test.Admin.Evaluation.Bonus
{
    [TestClass]
    public class BonusResults : BaseTest
    {
        private User currentUser;
        public LoginPage LoginPage { get; set; }
            
        public AddBonusPage AddBonusPage { get; set; }
        public readonly string FilePath = Directory.GetCurrentDirectory() + @"\export.xls";
        public override void TestInit()
        {
            currentUser = new User()
            {
                Username = "myadmin2",
                Password = "mypassword2"
            };
            this.LoginPage = new LoginPage();
            this.AddBonusPage = new AddBonusPage();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.High)]
        [TestCaseId("118")]
        public void AddingBonusPointsSuccessfully()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AddBonusPage.AddBonusPoints();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Medium)]
        [TestCaseId("117")]
        public void DownloadFileWithBonusesSuccessfully()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AddBonusPage.AddBonusResults();
            Assert.IsTrue(File.Exists(FilePath));
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Low)]
        [TestCaseId("119")]
        public void NavigateBackToAdministrationSuccessfully()
        {
            this.LoginPage.LoginUser(currentUser);
            this.AddBonusPage.BackToAdministration();
        }
    }
}

