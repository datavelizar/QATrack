using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core.Data;
using StageTelerikAcademy.Core.Pages.LoginPage;
using StageTelerikAcademy.Core.Pages.Frontend.TeamworkPage;

namespace StageTelerikAcademy.Core.Facades
{
    public class TeamworkFacade
    {
        public User currentUser;
        public readonly string pageTitle = "Курс \"ДСА2016\" - Телерик Академия - Студентска система";
        public readonly string pageUrl = "http://stage.telerikacademy.com/Courses/Courses/Details/246";
       
        public LoginPage LoginPage
        {
            get
            {
                return new LoginPage();
            }
        }

        public TeamworkPage TeamworkPage
        {
            get
            {
                return new TeamworkPage();
            }
        }

        public TeamworkPageAsserter TeamworkPageAsserter
        {
            get
            {
                return new TeamworkPageAsserter();
            }
        }

        public void VerifyLink()
        {
            this.LoginPage.LoginUser(currentUser);
            this.TeamworkPage.ClickTeamworkNameLink();
            this.TeamworkPageAsserter.ValidatePage(pageTitle, pageUrl);
        }

        public void VerifyTeammate()
        {
            this.LoginPage.LoginUser(currentUser);
            this.TeamworkPage.TeamMemberCheck();
            this.TeamworkPageAsserter.TeamMateValidate("ivandИван Иван");
        }
    }
}
