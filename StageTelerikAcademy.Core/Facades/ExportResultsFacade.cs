using StageTelerikAcademy.Core.Pages.EvaluationExportPage;
using StageTelerikAcademy.Core.Pages.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core.Data;

namespace StageTelerikAcademy.Core.Facades
{
    public class ExportResultsFacade
    {
        public User currentUser;

        private LoginPage loginPage;
        private EvaluationExportPage evaluationExportPage;

        public readonly string CourseName = "ExportTestCourse";
        

        public LoginPage LoginPage 
        {
            get
            {
                if (loginPage == null)
                {
                    loginPage = new LoginPage();
                }
                return loginPage;
            }
        }

        public EvaluationExportPage EvaluationExportPage
        {
            get
            {
                if (evaluationExportPage == null)
                {
                    evaluationExportPage = new EvaluationExportPage();
                }
                return evaluationExportPage;
            }
        }
        
        public void DownloadFile(string filePath)
        {
            this.LoginPage.LoginUser(currentUser);
            this.EvaluationExportPage.ExportCourseResults(CourseName,filePath);
            this.EvaluationExportPage.Asserter.IsFileIsDownloaded(filePath);            
        }
    }
}
