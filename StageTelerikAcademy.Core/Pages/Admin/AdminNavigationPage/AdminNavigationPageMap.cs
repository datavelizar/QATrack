using ArtOfTest.WebAii.Controls.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;
using ArtOfTest.WebAii.Core;

namespace StageTelerikAcademy.Core.Pages.Admin.MainAdminPage
{
    public class AdminNavigationPageMap : BaseElementMap
    {
        //Admin Evaluation navigation section

        public HtmlAnchor GenerateProtocolLink
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Courses/Evaluation");
            }
        }

        public HtmlAnchor ProtocolsWithFinalResults
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Courses/StudentsRecords");
            }
        }

        public HtmlAnchor EvaluationExportResults
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Courses/ExportResults");
            }
        }

        public HtmlAnchor UsersInCoursesBonuses
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Courses/UsersInCoursesBonuses");
            }
        }

        public HtmlAnchor HomeworkEvaluation
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Courses/HomeworkEvaluation");
            }
        }

        public HtmlAnchor UserInCourseHelpers
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Courses/UserInCourseHelpers");
            }
        }

        public HtmlAnchor HomeworkStatistics
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Courses/HomeworkStatistics");
            }
        }

        public HtmlAnchor HomeworkEvaluationReactions
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Courses/HomeworkEvaluationReactions");
            }
        }

        public HtmlAnchor AddStudents
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Courses/CourseTestExams/AddStudents");
            }
        }

        //Admin Teamwork navigation section

        public HtmlAnchor StudentsInTeams
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Teamwork/Teamworks");
            }
        }

        public HtmlAnchor ParticipatingInTeamwork
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Teamwork/TeamMemberSuggestions");
            }
        }

        public HtmlAnchor ImportTeams
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Teamwork/ImportTeams");
            }
        }

        public HtmlAnchor TeamNameSuggestions
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Teamwork/TeamNameSuggestions");
            }
        }

        public HtmlAnchor ImportTeamNames
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Teamwork/TeamNameSuggestions/ImportTeamNameSuggestions");
            }
        }

        public HtmlAnchor TeamMemberEvaluations
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Teamwork/TeamMemberEvaluations");
            }
        }

        public HtmlAnchor TeamMemberAllEvaluations
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Teamwork/TeamMemberAllEvaluations");
            }
        }

        public HtmlAnchor AdminMenuInAdminNavPage
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("textContent=~Админ"), 2500, false);
                return this.Find.ByExpression<HtmlAnchor>("href=/Administration/Navigation", "textContent=~Админ");
            }
        }
    }
}
