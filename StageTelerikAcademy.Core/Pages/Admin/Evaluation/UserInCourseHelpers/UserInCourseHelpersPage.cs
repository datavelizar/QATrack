using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Win32.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Admin.Evaluation.UserInCourseHelpers
{
    public class UserInCourseHelpersPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Administration_Courses/UserInCourseHelpers";

        public readonly string FilePath = Directory.GetCurrentDirectory() + @"\UserInCourseHelpersExcelExport.xls";

        public UserInCourseHelpersPageMap Map
        {
            get
            {
                return new UserInCourseHelpersPageMap();
            }
        }

        public UserInCourseHelpersPageAsserter Asserter
        {
            get
            {
                return new UserInCourseHelpersPageAsserter();
            }
        }

        public void ExportUserInCourseHelpersResults(string courseName)
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();

            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }

            DownloadDialogsHandler dialog = new DownloadDialogsHandler(Manager.Current.ActiveBrowser, DialogButton.SAVE, FilePath, Manager.Current.Desktop);
            Manager.Current.DialogMonitor.Start();
            this.Map.ExportExcelFile.Click();
            dialog.WaitUntilHandled(30000);

            this.Asserter.IsFileIsDownloaded(FilePath);
        }

        public void ValidateAdminNavigation()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            this.Map.AdminNavigation.Click();
            this.Asserter.VerifyAdminNavigation();
        }
    }
}
