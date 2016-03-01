using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using System.IO;

namespace StageTelerikAcademy.Core.Pages.Admin.Evaluation.ParticipatingInTeamworkPagе
{
    public class ParticipatingInTeamworkPagе
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Administration_Teamwork/TeamMemberSuggestions";
        public readonly string FilePath = Directory.GetCurrentDirectory() + @"\ParticipatingInTeamwork.xls";
       

        public ParticipatingInTeamworkPagеMap Map
        {
            get
            {
                return new ParticipatingInTeamworkPagеMap();
            }
        }

        public ParticipatingInTeamworkPageAsserter Asserter
        {
            get
            {
                return new ParticipatingInTeamworkPageAsserter();
            }
        }

        public void ExportParticipatingInTeamworkResult()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            this.Map.ExportButton.ScrollToVisible();
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
            this.Map.ExportButton.Download(false,DownloadOption.Save,FilePath,30000);
            this.Asserter.IsFileIsDownloaded(FilePath);
                        
        }

        public void BackToAdmin()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            this.Map.BackToAdminButton.ScrollToVisible();
            this.Asserter.IsGoingBackToAdministration();

        }

        public void AddStudentProposal()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            var a = this.Map.AddStudentProposalButton;
            this.Map.AddStudentProposalButton.ScrollToVisible();
            this.Map.AddStudentProposalButton.Click();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.TeamworkDropdown.Click();
            this.Map.SelectTeamworkItem.Click();
            this.Map.UserNameField.Value="ilia.82";
            this.Map.UpdateButton.Click();
        }
    }
}
