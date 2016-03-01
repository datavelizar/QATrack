using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Win32.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtOfTest.WebAii.Controls.HtmlControls;
using System.Threading;

namespace StageTelerikAcademy.Core.Pages.AddBonusPage
{
    public class AddBonusPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Administration_Courses/UsersInCoursesBonuses";
        public readonly string FilePath = Directory.GetCurrentDirectory() + @"\export.xls";

        public AddBonusPageMap Map
        {
            get
            {
                return new AddBonusPageMap();
            }
        }

        public AddBonusPageAsserter Asserter
        {
            get
            {
                return new AddBonusPageAsserter();
            }
        }

        
        public void AddBonusResults()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
            DownloadDialogsHandler dialog = new DownloadDialogsHandler(Manager.Current.ActiveBrowser, DialogButton.SAVE, FilePath, Manager.Current.Desktop);
            Manager.Current.DialogMonitor.Start();
            this.Map.ExportToExcelLink.Click();
            dialog.WaitUntilHandled(30000);

        }

        public void BackToAdministration()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.BackToAdministrationButton.MouseClick();
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            string pageTitle = Manager.Current.ActiveBrowser.PageTitle;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(
                "Администрация - Телерик Академия - Студентска система", pageTitle, "Actual page title = \"{0}\"", pageTitle);
        }

        public void AddBonusPoints()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();

            this.Map.BonusAddButton.Click();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            Manager.Current.ActiveBrowser.WaitForElement(3000, "name=Username", "class=~k-input");
            Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputText>("name=Username", "class=~k-input").MouseClick();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            Manager.Current.Desktop.KeyBoard.TypeText("myusername4");
            Manager.Current.ActiveBrowser.WaitUntilReady();
            Manager.Current.ActiveBrowser.Find.ByContent<HtmlAnchor>("Update").MouseClick();
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Manager.Current.ActiveBrowser.WaitUntilReady();

            Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("BonusPoints").MouseClick();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            Manager.Current.Desktop.KeyBoard.TypeText("6.3");

            var parentUsernameSpan = Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("class=~k-select");
            parentUsernameSpan.MouseClick();
            Manager.Current.ActiveBrowser.WaitUntilReady();

            var thirdLi = Manager.Current.ActiveBrowser.Find.AllByAttributes<HtmlControl>("data-offset-index=2");
            thirdLi[1].Click();

            Manager.Current.ActiveBrowser.Find.ById<HtmlTextArea>("Reason").MouseClick();
            Manager.Current.Desktop.KeyBoard.TypeText("Excellent presentation!");//works
            Manager.Current.ActiveBrowser.WaitUntilReady();
            Manager.Current.ActiveBrowser.Find.ByContent<HtmlAnchor>("Update").MouseClick();

            Manager.Current.ActiveBrowser.NavigateTo(@"http://stage.telerikacademy.com/Administration_Courses/UsersInCoursesBonuses");
            Manager.Current.ActiveBrowser.WaitForElement(3000, "tagname=tbody", "role=rowgroup");
            var tableBody = Manager.Current.ActiveBrowser.Find.ByExpression<HtmlControl>("tagname=tbody", "role=rowgroup");

            var tableRow1 = tableBody.ChildNodes[0];
            int count = 0;
            List<string> contentsList = new List<string>();

            foreach (var td in tableRow1.ChildNodes)
            {
                contentsList.Add(td.InnerText);//just for debugging

                if (td.InnerText == "Тестови курс 1 Декември 2015" ||
                    td.InnerText == "myusername4" ||
                    td.InnerText == "myadmin2" ||
                    td.InnerText == "Excellent presentation!" ||
                    td.InnerText == "6.3"
                    )
                {
                    count++;
                }
            }

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(5, count);
        }
    }
}
