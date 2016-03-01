using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Win32.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.EvaluationExportPage
{
    public class EvaluationExportPage
    {
        public readonly string url = @"http://stage.telerikacademy.com/Administration_Courses/ExportResults";
        
        public EvaluationExportPageMap Map 
        {
            get
            {
                return new EvaluationExportPageMap();
            }            
        }

        public EvaluationExportPageAsserter Asserter
        {
            get
            {
                return new EvaluationExportPageAsserter();
            }
        }

        public void ExportCourseResults(string courseName, string filePath)
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.url);
            this.Map.CourseCheckbox(courseName).Click();
            if(File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            DownloadDialogsHandler dialog = new DownloadDialogsHandler (Manager.Current.ActiveBrowser, DialogButton.SAVE, filePath, Manager.Current.Desktop); 
            Manager.Current.DialogMonitor.Start();
            this.Map.Submit.Click();
            dialog.WaitUntilHandled(30000);
        }
    }
}
