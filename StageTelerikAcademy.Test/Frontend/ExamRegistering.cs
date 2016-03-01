using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Pages.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;
using TestingFramework.Core.Data;
using TestingFramework.Core.Constants;
using TestingFramework.Utilities.Atributes;
using StageTelerikAcademy.Core.Pages.Frontend.ExamRegisteringPage;

namespace StageTelerikAcademy.Test.Frontend
{
    [TestClass]
    public class ExamRegistering : BaseTest
    {
        private User registeredForExamUser;
        private User notRegisteredForExamUser;
        public LoginPage LoginPage { get; set; }

        public ExamRegisteringPage ExamRegisteringPage { get; set; }

        public override void TestInit()
        {
            registeredForExamUser = new User()
            {
                Username = "myusername2",
                Password = "mypassword2"
            };

            notRegisteredForExamUser = new User()
            {
                Username = "myadmin2",
                Password = "mypassword2"
            };

            this.LoginPage = new LoginPage();
            this.ExamRegisteringPage = new ExamRegisteringPage();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.High)]
        [TestCaseId("140")]
        public void ExamRegisteringLinkAvailable()
        {
            this.LoginPage.LoginUser(registeredForExamUser);
            this.ExamRegisteringPage.Asserter.ExamRegisteringLinkExistsAfterLogin();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.High)]
        [TestCaseId("137")]
        public void ExamRegisteringFormSuccessfullLoad()
        {
            this.LoginPage.LoginUser(registeredForExamUser);
            this.ExamRegisteringPage.Navigate();
            this.ExamRegisteringPage.Asserter.ExamRegisteringLinkLoadsExamRegisteringForm();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Medium)]
        [TestCaseId("136")]
        public void FormContainsTheNameOfTheExam()
        {
            this.LoginPage.LoginUser(registeredForExamUser);
            this.ExamRegisteringPage.Navigate();
            this.ExamRegisteringPage.Asserter.ExamRegisteringLinkLoadsExamRegisteringForm();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Medium)]
        [TestCaseId("138")]
        public void FormContainsDateAndTimeOfTheExam()
        {
            this.LoginPage.LoginUser(registeredForExamUser);
            this.ExamRegisteringPage.Navigate();
            this.ExamRegisteringPage.Asserter.ContainsDateAndTimeOfTheExam();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Medium)]
        [TestCaseId("141")]
        public void HallNamePresentInTheSelectExamPage()
        {
            this.LoginPage.LoginUser(registeredForExamUser);
            this.ExamRegisteringPage.Navigate();
            this.ExamRegisteringPage.Asserter.HallNamePresent();
        }

        //Exam Apply Button Available In The Form
        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.High)]
        [TestCaseId("142")]
        public void ExamApplyButtonAvailableInTheForm()
        {
            this.LoginPage.LoginUser(registeredForExamUser);
            this.ExamRegisteringPage.Navigate();
            this.ExamRegisteringPage.Asserter.ExamApplyButtonAvailable();
        }

        //Counter For Remaining Seats Is Present
        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Low)]
        [TestCaseId("143")]
        public void CounterForRemainingSeatsIsPresent()
        {
            this.LoginPage.LoginUser(registeredForExamUser);
            this.ExamRegisteringPage.Navigate();
            this.ExamRegisteringPage.Asserter.CounterForRemainingSeats();
        }

        [TestMethod]
        [Owner(Author.Velizar)]
        [Priority(Priority.Low)]
        [TestCaseId("131")]
        public void ExamRegisteringLinkNotAvailable()
        {
            this.LoginPage.LoginUser(notRegisteredForExamUser);
            this.ExamRegisteringPage.Asserter.ExamRegisteringLinkNotAvalable();
        }
    }
}



//http://stage.telerikacademy.com/Courses/PracticalExams/Selected/265
//Дата и час за практически изпит в курса "Тестови курс 2 "
//Вашият практически изпит ще се проведе на 18/02/2016 от 09:00 до 21:00 часа в зала Ultimate (адрес: )
