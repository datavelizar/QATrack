using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Pages.LoginPage;
using TestingFramework.Utilities.Atributes;
using TestingFramework.Core.Constants;
using TestingFramework.Core;
using TestingFramework.Core.Data;
using StageTelerikAcademy.Core.Pages.Frontend.UploadReuploadHomeworkPage;

namespace StageTelerikAcademy.Test.Frontend
{
    [TestClass]
    public class UploadReuploadHomework : BaseTest
    {
        private User userSignedForCourse;
        private User notSignedForCourse;
        public LoginPage LoginPage { get; set; }
        public UploadReuploadHomeworkPage UploadReuploadHomeworkPage { get; set; }

        public override void TestInit()
        {
            userSignedForCourse = new User()
            {
                Username = "myusername2",
                Password = "mypassword2"

            };

            notSignedForCourse = new User()
            {
                Username = "myusername5",
                Password = "mypassword5"

            };
            
            this.LoginPage = new LoginPage();
            this.UploadReuploadHomeworkPage = new UploadReuploadHomeworkPage();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.High)]
        [TestCaseId("16")]
        public void UploadHomeworkLinkAvailable()
        {
            this.LoginPage.LoginUser(userSignedForCourse);
            this.UploadReuploadHomeworkPage.Navigate();
            this.UploadReuploadHomeworkPage.Asserter.UploadHomeworkLinkExists();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.High)]
        [TestCaseId("21")]
        public void ReUploadHomeworkLinkAvailable()
        {
            this.LoginPage.LoginUser(userSignedForCourse);
            this.UploadReuploadHomeworkPage.Navigate();
            this.UploadReuploadHomeworkPage.Asserter.ReUploadHomeworkLinkExists();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.High)]
        [TestCaseId("13")]
        public void UploadHomeworkFormSuccessfullLoad()
        {
            this.LoginPage.LoginUser(userSignedForCourse);
            this.UploadReuploadHomeworkPage.Navigate();
            this.UploadReuploadHomeworkPage.Asserter.UploadHomeworkFormSuccessfullLoad();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Low)]
        [TestCaseId("17")]
        public void NoHomeworkLinkForNotSigned()
        {
            this.LoginPage.LoginUser(notSignedForCourse);
            this.UploadReuploadHomeworkPage.Navigate();
            this.UploadReuploadHomeworkPage.Asserter.NoUploadHomeworkLink();
        }
    }
}
