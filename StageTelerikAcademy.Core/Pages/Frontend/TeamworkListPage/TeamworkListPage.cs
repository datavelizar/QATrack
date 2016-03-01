using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Frontend.TeamworkListPage
{
    public class TeamworkListPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Courses/Teamwork/List";
        
        public TeamworkListPageMap Map 
        {
            get
            {
                return new TeamworkListPageMap();
            }            
        }

        public void GradeTeammate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            
        }
    }
}
