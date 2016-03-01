using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Pages.Admin.Evaluation.UserInCourseHelpers;
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

namespace StageTelerikAcademy.Test.Admin.Evaluation
{
    [TestClass]
    public class UserInCourseHelpers : BaseTest
    {
        private User adminUser;
        public LoginPage LoginPage { get; set; }
        public UserInCourseHelpersPage UserInCourseHelpersPage { get; set; }
        public readonly string CourseName = "UserInCourseHelpers";

        public override void TestInit()
        {
            adminUser = new User()
            {
                Username = "TeamArcher",
                Password = "teamarcher"
            };

            this.LoginPage = new LoginPage();
            this.UserInCourseHelpersPage = new UserInCourseHelpersPage();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
        [TestCaseId(101)]
        public void DownloadUserInCourseHelpersExcelFileSuccessfuly()
        {
            this.LoginPage.LoginUser(adminUser);
            this.UserInCourseHelpersPage.ExportUserInCourseHelpersResults(CourseName);
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.Low)]
        [TestCaseId(180)]
        public void ValidateAdminNavigationPage()
        {
            this.LoginPage.LoginUser(adminUser);
            this.UserInCourseHelpersPage.ValidateAdminNavigation();
        } 
    }
}
