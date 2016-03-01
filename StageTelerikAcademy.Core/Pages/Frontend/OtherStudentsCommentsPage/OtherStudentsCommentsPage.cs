using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Frontend.OtherStudentsCommentsPage
{
    public class OtherStudentsCommentsPage
    {
        public readonly string CourseUrl = @"http://stage.telerikacademy.com/Courses/Courses/Details/265";
        public readonly string CommentsUrl = @"http://stage.telerikacademy.com/Courses/HomeworkEvaluations/ViewMyEvaluations/55";
        
        public OtherStudentsCommentsPageMap Map 
        {
            get
            {
                return new OtherStudentsCommentsPageMap();
            }            
        }

        public OtherStudentsCommentsPageAsserter Asserter
        {
            get
            {
                return new OtherStudentsCommentsPageAsserter();
            }
        }

        public void NavigateToCourse()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.CourseUrl);
        }

        public void NavigateToComments()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.CommentsUrl);
        }
    }
}
