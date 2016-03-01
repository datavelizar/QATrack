using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtOfTest.WebAii.Controls.HtmlControls;

namespace StageTelerikAcademy.Core.Pages.Frontend.OtherStudentsCommentsPage
{
    public class OtherStudentsCommentsPageAsserter
    {
        public OtherStudentsCommentsPageMap Map
        {
            get
            {
                return new OtherStudentsCommentsPageMap();
            }
        }

        //CommentsLinkExists
        public void CommentsLinkExists()
        {
            var registeringLink = this.Map.Find.ByAttributes<HtmlAnchor>("href=/Courses/HomeworkEvaluations/ViewMyEvaluations/55");
            Assert.AreEqual("Неоценени коментари (1 от 1)", registeringLink.InnerText);
        }

        //GoToCommentsPage
        public void GoToCommentsPage()
        {
            var registeringLink = this.Map.Find.ByAttributes<HtmlAnchor>("href=/Courses/HomeworkEvaluations/ViewMyEvaluations/55");
            registeringLink.Click();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            var pageTitle = Manager.Current.ActiveBrowser.PageTitle;
            var comments = pageTitle.Contains("Коментари към домашните за лекцията");
            Assert.IsTrue(comments);
        }

        //BackToCoursePage()
        public void BackToCoursePage()
        {
            //var registeringLink = this.Map.Find.ByAttributes<HtmlAnchor>("href=/Courses/HomeworkEvaluations/ViewMyEvaluations/55");
            //registeringLink.Click();
            //Manager.Current.ActiveBrowser.WaitUntilReady();
            //var pageTitle = Manager.Current.ActiveBrowser.PageTitle;
            //var comments = pageTitle.Contains("Коментари към домашните за лекцията");
            //Assert.IsTrue(comments);

            var backToCourseCollection = this.Map.Find.AllByAttributes("href=/Courses/Courses/Details/265");

            foreach (var item in backToCourseCollection)
            {
                if (item.InnerText == "Обратно към курса")
                {
                    item.As<HtmlAnchor>().Click();
                }
            }
            Manager.Current.ActiveBrowser.WaitUntilReady();

            var coursePageTitle = Manager.Current.ActiveBrowser.PageTitle;
            var testCourse2 = coursePageTitle.Contains("Тестови курс 2");
            Assert.IsTrue(testCourse2);
        }
    }
}
