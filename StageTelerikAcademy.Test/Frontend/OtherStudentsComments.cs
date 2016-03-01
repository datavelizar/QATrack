using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Pages.LoginPage;
using TestingFramework.Utilities.Atributes;
using TestingFramework.Core.Constants;
using TestingFramework.Core;
using TestingFramework.Core.Data;
using StageTelerikAcademy.Core.Pages.Frontend.OtherStudentsCommentsPage;
using ArtOfTest.WebAii.Core;

namespace StageTelerikAcademy.Test.Frontend
{
    [TestClass]
    public class OtherStudentsComments : BaseTest
    {
        private User userWithComments;
        //private User notSignedForCourse;
        public LoginPage LoginPage { get; set; }
        public OtherStudentsCommentsPage OtherStudentsCommentsPage { get; set; }

        public override void TestInit()
        {
            userWithComments = new User()
            {
                Username = "myusername5",
                Password = "mypassword5"

            };

            this.LoginPage = new LoginPage();
            this.OtherStudentsCommentsPage = new OtherStudentsCommentsPage();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.High)]
        [TestCaseId("122")]
        public void OtherStudentsCommentsLinkAvailable()
        {
            this.LoginPage.LoginUser(userWithComments);
            this.OtherStudentsCommentsPage.NavigateToCourse();
            this.OtherStudentsCommentsPage.Asserter.CommentsLinkExists();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.High)]
        [TestCaseId("123")]
        public void OtherStudentsCommentsLinkLeadsToCommentsPage()
        {
            this.LoginPage.LoginUser(userWithComments);
            this.OtherStudentsCommentsPage.NavigateToCourse();
            this.OtherStudentsCommentsPage.Asserter.GoToCommentsPage();
        }

        //Comments page link back to the course page
        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Low)]
        [TestCaseId("124")]
        public void OtherStudentsCommentsLinkBackToCoursePage()
        {
            this.LoginPage.LoginUser(userWithComments);
            this.OtherStudentsCommentsPage.NavigateToComments();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.OtherStudentsCommentsPage.Asserter.BackToCoursePage();
        }
    }
}
