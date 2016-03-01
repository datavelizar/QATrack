using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtOfTest.WebAii.Controls.HtmlControls;

namespace StageTelerikAcademy.Core.Pages.Frontend.ExamRegisteringPage
{
    public class ExamRegisteringPageAsserter
    {
        public ExamRegisteringPageMap Map
        {
            get
            {
                return new ExamRegisteringPageMap();
            }
        }

        public void ExamRegisteringLinkExistsAfterLogin()
        {
            var registeringLink = this.Map.Find.ByAttributes<HtmlAnchor>("href=/Courses/PracticalExams/Select/265");
            Assert.AreEqual("тук", registeringLink.InnerText);

            var registeringLinkParent = registeringLink.Parent<HtmlDiv>();
            Assert.AreEqual("Моля изберете дата за практически изпит за курса \"Тестови курс 2\" оттук.", registeringLinkParent.InnerText);
        }

        public void ExamRegisteringLinkLoadsExamRegisteringForm()
        {
            var registeringLink = this.Map.Find.ByAttributes<HtmlAnchor>("href=/Courses/PracticalExams/Select/265");
            registeringLink.Click();

            Manager.Current.ActiveBrowser.WaitUntilReady();

            var divContainer = this.Map.Find.AllByTagName("h1")
                   .Where(
                   p => p.InnerText ==
                       "Избор на дата и час за практически изпит в курса \"Тестови курс 2 \"")
                       .FirstOrDefault();

            Assert.IsNotNull(divContainer);
        }

        public void ContainsDateAndTimeOfTheExam()
        {
            var registeringLink = this.Map.Find.ByAttributes<HtmlAnchor>("href=/Courses/PracticalExams/Select/265");
            registeringLink.Click();

            Manager.Current.ActiveBrowser.WaitUntilReady();

            var divContainer = this.Map.Find.AllByTagName("b")
                   .Where(
                   p => p.InnerText ==
                       "18/02/2016 от 09:00 до 21:00 часа")
                       .FirstOrDefault();

            Assert.IsNotNull(divContainer);
        }

        public void HallNamePresent()
        {
            var registeringLink = this.Map.Find.ByAttributes<HtmlAnchor>("href=/Courses/PracticalExams/Select/265");
            registeringLink.Click();

            Manager.Current.ActiveBrowser.WaitUntilReady();

            var divContainer = this.Map.Find.AllByTagName("b")
                   .Where(
                   p => p.InnerText ==
                       "Ultimate")
                       .FirstOrDefault();

            Assert.IsNotNull(divContainer);
        }

        public void ExamApplyButtonAvailable()
        {
            var registeringLink = this.Map.Find.ByAttributes<HtmlAnchor>("href=/Courses/PracticalExams/Select/265");
            registeringLink.Click();

            Manager.Current.ActiveBrowser.WaitUntilReady();

            var applyButton = this.Map.Find.ByAttributes("value=Запиши се за изпит");

            Assert.IsNotNull(applyButton);
        }

        public void CounterForRemainingSeats()
        {
            var registeringLink = this.Map.Find.ByAttributes<HtmlAnchor>("href=/Courses/PracticalExams/Select/265");
            registeringLink.Click();

            Manager.Current.ActiveBrowser.WaitUntilReady();

            var freeSeatsCounter = this.Map.Find.AllByTagName("label")
                   .Where(p => p.InnerText.Contains("Свободни места:"));

            Assert.IsNotNull(freeSeatsCounter);
        }



        public void ExamRegisteringLinkNotAvalable()
        {
            Assert.IsNull(this.Map.Find.ByAttributes<HtmlAnchor>("href=/Courses/PracticalExams/Select/265"));
        }
    }
}
