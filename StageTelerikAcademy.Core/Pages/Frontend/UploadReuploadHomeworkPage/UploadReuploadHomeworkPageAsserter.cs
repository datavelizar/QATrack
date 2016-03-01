using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using System.Linq;
using ArtOfTest.WebAii.Controls.HtmlControls;

namespace StageTelerikAcademy.Core.Pages.Frontend.UploadReuploadHomeworkPage
{
    public class UploadReuploadHomeworkPageAsserter
    {
        public UploadReuploadHomeworkPageMap Map
        {
            get
            {
                return new UploadReuploadHomeworkPageMap();
            }
        }

        public void UploadHomeworkLinkExists()
        {
            var registeringLink = this.Map.Find.ByAttributes<HtmlAnchor>("href=/Courses/Homework/Submit/24");
            Assert.AreEqual("Изпратете домашно", registeringLink.InnerText);
        }

        public void ReUploadHomeworkLinkExists()
        {
            var registeringLink = this.Map.Find.ByAttributes<HtmlAnchor>("href=/Courses/Homework/Download/36");
            Assert.AreEqual("Свалете последното изпратено домашно", registeringLink.InnerText);
        }

        public void UploadHomeworkFormSuccessfullLoad()
        {
            var registeringLink = this.Map.Find.ByAttributes<HtmlAnchor>("href=/Courses/Homework/Submit/24");
            registeringLink.Click();

            Manager.Current.ActiveBrowser.WaitUntilReady();

            var divContainer = this.Map.Find.AllByTagName("h1")
                   .Where(
                   p => p.InnerText ==
                       "Изпращане на домашно към лекцията \"Алгоритми за сортиране и търсене\"")
                       .FirstOrDefault();

            Assert.IsNotNull(divContainer);
        }

        public void NoUploadHomeworkLink()
        {
            var firstTableRow = this.Map.Find.ByAttributes<HtmlControl>("style=~background-color");
            var collectionTh = firstTableRow.Find.AllByTagName("th");
            Assert.AreEqual(2, collectionTh.Count);
        }

    }
}
