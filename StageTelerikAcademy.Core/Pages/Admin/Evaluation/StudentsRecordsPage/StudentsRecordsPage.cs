using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Win32.Dialogs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.StudentsRecordsPage
{
    public class StudentsRecordsPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Administration_Courses/StudentsRecords";
        public readonly string FilePath = Directory.GetCurrentDirectory() + @"\GridExport.xls";

        public StudentsRecordsPageMap Map
        {
            get
            {
                return new StudentsRecordsPageMap();
            }
        }

        public StudentsRecordsPageAsserter Asserter
        {
            get
            {
                return new StudentsRecordsPageAsserter();
            }
        }

        public void AddFile()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.Window.Maximize();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            Manager.Current.ActiveBrowser.ScrollBy(0, 500);

            this.Map.AddFile.Click();
        }

        public void ExportCourseResults(string courseName)
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
            //this.Map.AdminNavigation.Click();
            this.Asserter.VerifyAdminNavigation();
        }
    }
}
