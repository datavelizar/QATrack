using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Win32.Dialogs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Admin.Teamwork.TeamMemberAllEvaluationsPage
{
    public class TeamMemberAllEvaluationsPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Administration_Teamwork/TeamMemberAllEvaluations";

        public readonly string ExcelFilePath = Directory.GetCurrentDirectory() + @"\TeamMemberAllEvaluationsExcelExport.xls";

        public readonly string PdfFilePath = Directory.GetCurrentDirectory() + @"\TeamMemberAllEvaluationsPdfExport.pdf";

        public TeamMemberAllEvaluationsPageMap Map
        {
            get
            {
                return new TeamMemberAllEvaluationsPageMap();
            }
        }

        public TeamMemberAllEvaluationsPageAsserter Asserter
        {
            get
            {
                return new TeamMemberAllEvaluationsPageAsserter();
            }
        }

        public void ExportTeamMemberAllEvaluationsExcelResults(string courseName)
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();

            if (File.Exists(ExcelFilePath))
            {
                File.Delete(ExcelFilePath);
            }

            DownloadDialogsHandler dialog = new DownloadDialogsHandler(Manager.Current.ActiveBrowser, DialogButton.SAVE, ExcelFilePath, Manager.Current.Desktop);
            Manager.Current.DialogMonitor.Start();
            this.Map.ExportExcelFile.Click();
            dialog.WaitUntilHandled(30000);

            this.Asserter.IsFileIsDownloaded(ExcelFilePath);
        }

        public void ExportTeamMemberAllEvaluationsPdfResults(string courseName)
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();

            if (File.Exists(PdfFilePath))
            {
                File.Delete(PdfFilePath);
            }

            DownloadDialogsHandler dialog = new DownloadDialogsHandler(Manager.Current.ActiveBrowser, DialogButton.SAVE, PdfFilePath, Manager.Current.Desktop);
            Manager.Current.DialogMonitor.Start();
            this.Map.ExportPdfFile.Click();
            dialog.WaitUntilHandled(30000);

            this.Asserter.IsFileIsDownloaded(ExcelFilePath);
        }


        public void ValidateAdminNavigation()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            this.Map.AdminNavigation.Click();
            this.Asserter.VerifyAdminNavigation();
        }

        public void UpdateRowInGrid()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            this.Map.UpdateButtonInGridRow.Click();
            this.Asserter.VerifyUpdatePopUp();
        }

        public void DeleteRowInGrid()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            var one = this.Map.CountOfRowsInGridLabelBeforeDeleting;
            this.Map.DeleteButtonInGridRow.Click();
            AlertDialog altDlg = new AlertDialog(Manager.Current.ActiveBrowser, DialogButton.OK);
            Manager.Current.DialogMonitor.AddDialog(altDlg);
            Manager.Current.DialogMonitor.Start();
            this.Map.RefreshButton.Click();
            var two = this.Map.CountOfRowsInGridLabelAfterDeleting;
            Assert.AreNotEqual(one, two); 
        }

        public void EnterDataTeamMemberAllEvaluations()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            var one = this.Map.CountOfRowsInGridLabelBeforeDeleting;
            this.Map.AddFileButton.Click();
            this.Map.ChoseTeamwork.Text = "Бази Данни Teamwork";
            this.Map.ChoseTeam.Text = "Квадрат";
            this.Map.ChoseUser.Text = "myusername1";
            this.Map.EvaluatedByUser.Text = "myusername3";
            this.Map.Valuation.Text = "5";
            this.Map.UpdateButtonOnPopUp.Click();
            this.Map.RefreshButton.Click();
            var two = this.Map.CountOfRowsInGridLabelAfterDeleting;
            Assert.AreNotEqual(one, two);
        }
    }
}
