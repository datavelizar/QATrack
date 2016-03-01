using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Win32.Dialogs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Admin.Teamwork.TeamworksPage
{
    public class TeamworksPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Administration_Teamwork/Teamworks";

        public TeamworksPageMap Map
        {
            get
            {
                return new TeamworksPageMap();

            }
        }

        public TeamworksPageAsserter Asserter
        {
            get
            {
                return new TeamworksPageAsserter();
            }
        }

        public void CreateTeamwork()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);

            this.Map.CreateTeamworkButton.Click();
            this.Map.TeamworkNameTestBox.Text = "Бази данни - отборна работа";
            this.Map.CourseInstanceIdSpan.Click();
            this.Map.CourseInstanceId.Click();
            this.Map.EvaluationActiveCheckbox.Click();
            this.Map.AcceptSuggestionsActiveCheckbox.Click();
            this.Map.UpdatePopUpWindowButton.Click();
        }

        public void AddingEvaluationFromExcel()
        {
            this.Map.AddEvaluationButton.Click();
        }

        public void ValidateAdminNavigation()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            this.Map.AdminNavigation.Click();
            
        }

        public void UpdateRowInGrid()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            this.Map.UpdateButtonInGridRow.Click();
            
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
