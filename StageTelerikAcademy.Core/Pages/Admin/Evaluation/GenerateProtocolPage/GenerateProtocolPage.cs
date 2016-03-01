using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Win32.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.EvaluationGenerateProtocolPage
{
    public class GenerateProtocolPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Administration_Courses/Evaluation";
        public readonly string FilePath = Directory.GetCurrentDirectory() + @"\protocol.xls";
        public DownloadDialogsHandler dialog;

        public GenerateProtocolPageMap Map
        {
            get
            {
                return new GenerateProtocolPageMap();
            }
        }

        public GenerateProtocolPageAsserter Asserter
        {
            get
            {
                return new GenerateProtocolPageAsserter();
            }
        }


        public void GenarateProtocolResultWithCorrectData()
        {

            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.ScrollBy(0, 1000);

            this.Map.CourseInstance.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();
            Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("data-offset-index=0"), 2500, false);

            this.Map.FirstSelection.Click();

            this.Map.ForumCategory.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();
            Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("textContent=Зайци"), 2500, false);

            this.Map.SecondSelection.Click();
            Manager.Current.ActiveBrowser.WaitUntilReady();

            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
            DownloadDialogsHandler dialog = new DownloadDialogsHandler(Manager.Current.ActiveBrowser, DialogButton.SAVE, FilePath, Manager.Current.Desktop);
            Manager.Current.DialogMonitor.Start();
            this.Map.SubmitButton.Click();
            dialog.WaitUntilHandled(30000);
            this.Asserter.IsFileIsDownloaded(FilePath);

        }
        public void GenarateProtocolResultWithNoSelection()
        {

            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.ScrollBy(0, 1000);

            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
            dialog = new DownloadDialogsHandler(Manager.Current.ActiveBrowser, DialogButton.CANCEL, FilePath, Manager.Current.Desktop);
            Manager.Current.DialogMonitor.Start();
            this.Map.SubmitButton.Click();
            dialog.WaitUntilHandled(30000);
            this.Asserter.IsFileNotDownloaded(dialog);

        }
        public void GenarateProtocolResultWithOneSelection()
        {

            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.ScrollBy(0, 1000);

            this.Map.ForumCategory.Click();

            Manager.Current.ActiveBrowser.RefreshDomTree();
            Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("textContent=Зайци"), 2500, false);

            this.Map.SecondSelection.Click();
            Manager.Current.ActiveBrowser.WaitUntilReady();

            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
            DownloadDialogsHandler dialog = new DownloadDialogsHandler(Manager.Current.ActiveBrowser, DialogButton.CANCEL, FilePath, Manager.Current.Desktop);
            Manager.Current.DialogMonitor.Start();
            this.Map.SubmitButton.Click();
            dialog.WaitUntilHandled(30000);
            this.Asserter.IsFileNotDownloaded(dialog);
        }

        public void ValidateLink()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            this.Asserter.CorrectPage();


        }

    }
}
