using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;

namespace StageTelerikAcademy.Core.Pages.Admin.MainAdminPage
{
    public class AdminNavigationPageAsserter
    {
        public AdminNavigationPageMap Map
        {
            get
            {
                return new AdminNavigationPageMap();
            }
        }

        
        public void VerifyGenerateProtocolLink()
        {
            string url = "http://stage.telerikacademy.com/Administration_Courses/Evaluation";
            string pageTitle = "Генериране на протокол - Телерик Академия - Студентска система";
            //TODO Extract as method
            Assert.AreEqual(pageTitle, Manager.Current.ActiveBrowser.PageTitle);
            Assert.AreEqual(url,Manager.Current.ActiveBrowser.Url);
        }

        public void VerifyProtocolsWithFinalResults()
        {
            Assert.AreEqual("Протоколи с крайни резулати", Map.ProtocolsWithFinalResults.InnerText);
            Assert.AreEqual("/Administration_Courses/StudentsRecords", Map.ProtocolsWithFinalResults.HRef);
        }

        public void VerifyEvaluationExportResults()
        {
            Assert.AreEqual("Export на резултати", Map.EvaluationExportResults.InnerText);
            Assert.AreEqual("/Administration_Courses/ExportResults", Map.EvaluationExportResults.HRef);
        }

        public void VerifyUsersInCoursesBonuses()
        {
            Assert.AreEqual("Бонус точки", Map.UsersInCoursesBonuses.InnerText);
            Assert.AreEqual("/Administration_Courses/UsersInCoursesBonuses", Map.UsersInCoursesBonuses.HRef);
        }

        public void VerifyHomeworkEvaluation()
        {
            Assert.AreEqual("Оценяване на домашно", Map.HomeworkEvaluation.InnerText);
            Assert.AreEqual("/Administration_Courses/HomeworkEvaluation", Map.HomeworkEvaluation.HRef);
        }

        public void VerifyUserInCourseHelpers()
        {
            Assert.AreEqual("Кой на кого помага", Map.UserInCourseHelpers.InnerText);
            Assert.AreEqual("/Administration_Courses/UserInCourseHelpers", Map.UserInCourseHelpers.HRef);
        }

        public void VerifyHomeworkStatistics()
        {
            Assert.AreEqual("Статистика за оценките на домашните", Map.HomeworkStatistics.InnerText);
            Assert.AreEqual("/Administration_Courses/HomeworkStatistics", Map.HomeworkStatistics.HRef);
        }

        public void VerifyHomeworkEvaluationReactions()
        {
            Assert.AreEqual("Реакции за оценките на домашните", Map.HomeworkEvaluationReactions.InnerText);
            Assert.AreEqual("/Administration_Courses/HomeworkEvaluationReactions", Map.HomeworkEvaluationReactions.HRef);
        }

        public void VerifyAddStudents()
        {
            Assert.AreEqual("Записване студенти за тестови изпит", Map.AddStudents.InnerText);
            Assert.AreEqual("/Administration_Courses/CourseTestExams/AddStudents", Map.AddStudents.HRef);
        }

        //Teamwork Asserters

        public void VerifyStudentsInTeams()
        {
            Assert.AreEqual("Студенти в отбори", Map.StudentsInTeams.InnerText);
            Assert.AreEqual("/Administration_Teamwork/Teamworks", Map.StudentsInTeams.HRef);
        }

        public void VerifyParticipatingInTeamwork()
        {
            string url = "http://stage.telerikacademy.com/Administration_Teamwork/TeamMemberSuggestions";
            string pageTitle = "Участващи в отборна работа - Телерик Академия - Студентска система";

            Assert.AreEqual(pageTitle, Manager.Current.ActiveBrowser.PageTitle);
            Assert.AreEqual(url, Manager.Current.ActiveBrowser.Url);
        }

        public void VerifyImportTeams()
        {
            Assert.AreEqual("Import на отбори", Map.ImportTeams.InnerText);
            Assert.AreEqual("/Administration_Teamwork/ImportTeams", Map.ImportTeams.HRef);
        }

        public void VerifyTeamNameSuggestions()
        {
            Assert.AreEqual("Имена на отбори", Map.TeamNameSuggestions.InnerText);
            Assert.AreEqual("/Administration_Teamwork/TeamNameSuggestions", Map.TeamNameSuggestions.HRef);
        }

        public void VerifyImportTeamNames()
        {
            Assert.AreEqual("Import на имена на отбори", Map.ImportTeamNames.InnerText);
            Assert.AreEqual("/Administration_Teamwork/TeamNameSuggestions/ImportTeamNameSuggestions", Map.ImportTeamNames.HRef);
        }

        public void VerifyTeamMemberEvaluations()
        {
            Assert.AreEqual("Оценки на студенти в отбори", Map.TeamMemberEvaluations.InnerText);
            Assert.AreEqual("/Administration_Teamwork/TeamMemberEvaluations", Map.TeamMemberEvaluations.HRef);
        }

        public void VerifyTeamMemberAllEvaluations()
        {
            Assert.AreEqual("Списък с оценки", Map.TeamMemberAllEvaluations.InnerText);
            Assert.AreEqual("/Administration_Teamwork/TeamMemberAllEvaluations", Map.TeamMemberAllEvaluations.HRef);
        }
    }
}
