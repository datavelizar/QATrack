using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Admin.MainAdminPage
{
    public class AdminNavigationPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Administration/Navigation";

        public AdminNavigationPageMap Map
        {
            get
            {
                return new AdminNavigationPageMap();
            }
        }

        public AdminNavigationPageAsserter Asserter
        {
            get
            {
                return new AdminNavigationPageAsserter();
            }
        }

        public void ValidateGeneralProtocolLink()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.GenerateProtocolLink.ScrollToVisible();
            this.Map.GenerateProtocolLink.Click();
            this.Asserter.VerifyGenerateProtocolLink();
        }

        public void ValidateProtocolsWithFinalResults()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.GenerateProtocolLink.ScrollToVisible();
            this.Asserter.VerifyProtocolsWithFinalResults();
        }

        public void ValidateEvaluationExportResults()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.GenerateProtocolLink.ScrollToVisible();
            this.Asserter.VerifyEvaluationExportResults();
        }

        public void ValidateUsersInCoursesBonuses()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.GenerateProtocolLink.ScrollToVisible();
            this.Asserter.VerifyUsersInCoursesBonuses();
        }

        public void ValidateHomeworkEvaluation()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.GenerateProtocolLink.ScrollToVisible();
            this.Asserter.VerifyHomeworkEvaluation();
        }

        public void ValidateUserInCourseHelpers()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.GenerateProtocolLink.ScrollToVisible();
            this.Asserter.VerifyUserInCourseHelpers();
        }

        public void ValidateHomeworkStatistics()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.GenerateProtocolLink.ScrollToVisible();
            this.Asserter.VerifyHomeworkStatistics();
        }

        public void ValidateHomeworkEvaluationReactions()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.GenerateProtocolLink.ScrollToVisible();
            this.Asserter.VerifyHomeworkEvaluationReactions();
        }

        public void ValidateAddStudents()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.GenerateProtocolLink.ScrollToVisible();
            this.Asserter.VerifyAddStudents();
        }

        //Teamwork
        public void ValidateStudentsInTeams()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.StudentsInTeams.ScrollToVisible();
            this.Asserter.VerifyStudentsInTeams();
        }

        public void ValidateParticipatingInTeamwork()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.ParticipatingInTeamwork.ScrollToVisible();
            this.Map.ParticipatingInTeamwork.Click();
            this.Asserter.VerifyParticipatingInTeamwork();
        }

        public void ValidateImportTeams()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.ImportTeams.ScrollToVisible();
            this.Asserter.VerifyImportTeams();
        }

        public void ValidateTeamNameSuggestions()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.TeamNameSuggestions.ScrollToVisible();
            this.Asserter.VerifyTeamNameSuggestions();
        }

        public void ValidateImportTeamNames()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.ImportTeamNames.ScrollToVisible();
            this.Asserter.VerifyImportTeamNames();
        }

        public void ValidateTeamMemberEvaluations()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.TeamMemberEvaluations.ScrollToVisible();
            this.Asserter.VerifyTeamMemberEvaluations();
        }

        public void ValidateTeamMemberAllEvaluations()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.TeamMemberAllEvaluations.ScrollToVisible();
            this.Asserter.VerifyTeamMemberAllEvaluations();
        }

    }
}
