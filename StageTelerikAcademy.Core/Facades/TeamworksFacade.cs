using StageTelerikAcademy.Core.Pages.Admin.Teamwork.TeamworksPage;
using StageTelerikAcademy.Core.Pages.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core.Data;

namespace StageTelerikAcademy.Core.Facades
{
    public class TeamworksFacade
    {
        public User user;

        private LoginPage loginPage;
        private TeamworksPage teamworksPage;

        public LoginPage LoginPage
        {
            get
            {
                if (loginPage == null)
                {
                    loginPage = new LoginPage();
                }
                return new LoginPage();
            }
        }

        public TeamworksPage TeamworksPage
        {
            get
            {
                if (teamworksPage == null)
                {
                    teamworksPage = new TeamworksPage();
                }
                return new TeamworksPage();
            }
        }

        public void BackToAdminButton()
        {
            this.LoginPage.LoginUser(user);
            this.TeamworksPage.ValidateAdminNavigation();
            this.TeamworksPage.Asserter.VerifyAdminNavigation();
        }

        public void PopUpWindowForUpdateSettingsIsShown()
        {
            this.LoginPage.LoginUser(user);
            this.TeamworksPage.UpdateRowInGrid();
            this.TeamworksPage.Asserter.VerifyUpdatePopUp();
        }

        public void DeletingRowInGrid()
        {
            this.LoginPage.LoginUser(user);
            this.TeamworksPage.DeleteRowInGrid();
        }

        public void AddingFileInGrid()
        {
            this.LoginPage.LoginUser(user);
            this.TeamworksPage.EnterDataTeamMemberAllEvaluations();
        }
    }
}
