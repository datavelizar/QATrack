using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFramework.Core;
using StageTelerikAcademy.Core.Pages.LoginPage;
using TestingFramework.Core.Data;
using TestingFramework.Utilities.Atributes;
using TestingFramework.Core.Constants;
using StageTelerikAcademy.Core.Pages.Admin.Evaluation.ParticipatingInTeamworkPagе;

namespace StageTelerikAcademy.Test.Admin.Teamwork
{
    [TestClass]
    public class ParticipatingInTeamworkPagеResult : BaseTest
    {
        private User currentUser;
        public LoginPage LoginPage { get; set; }

        public ParticipatingInTeamworkPagе ParticipatingInTeamworkPagе { get; set; }

        public override void TestInit()
        {
            currentUser = new User()
            {
                Username = "ilia.82",
                Password = "826682"
            };
            this.LoginPage = new LoginPage();
            this.ParticipatingInTeamworkPagе = new ParticipatingInTeamworkPagе();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [TestCaseId(183)]
        [Priority(Priority.High)]
        public void ParticipatingInTeamworkPagеResultFileSuccesfulyDownload()
        {
            this.LoginPage.LoginUser(currentUser);
            this.ParticipatingInTeamworkPagе.ExportParticipatingInTeamworkResult();
        }

        [TestMethod]
        [Owner(Author.Ilia)]
        [TestCaseId(184)]
        [Priority(Priority.Low)]
        public void ParticipatingInTeamworkPagеBackToAdminPage()
        {
            this.LoginPage.LoginUser(currentUser);
            this.ParticipatingInTeamworkPagе.BackToAdmin();
        }

        //Needs investigation
        [TestMethod]
        [Owner(Author.Ilia)]
        [TestCaseId(107)]
        [Priority(Priority.High)]
        public void AddStudentProposalWithValidData()
        {
            this.LoginPage.LoginUser(currentUser);
            //this.ParticipatingInTeamworkPagе.AddStudentProposal();

        }

        
       // Not implemented
        [TestMethod]
        [Owner(Author.Ilia)]
        //[TestCaseId()]
        [Priority(Priority.High)]
        public void AddStudentProposalWithNoSelection()
        {
            this.LoginPage.LoginUser(currentUser);

        }

        // Not implemented
        [TestMethod]
        [Owner(Author.Ilia)]
        //[TestCaseId()]
        [Priority(Priority.High)]
        public void AddStudentProposalWithInvalidUser()
        {
            this.LoginPage.LoginUser(currentUser);

        }

        // Not implemented
        [TestMethod]
        [Owner(Author.Ilia)]
        //[TestCaseId()]
        [Priority(Priority.High)]
        public void AddStudentProposalWithoutUser()
        {
            this.LoginPage.LoginUser(currentUser);

        }

        // Not implemented
        [TestMethod]
        [Owner(Author.Ilia)]
        //[TestCaseId()]
        [Priority(Priority.High)]
        public void AddStudentProposalWithAlreadyAddedUser()
        {
            this.LoginPage.LoginUser(currentUser);

        }
    }
}
