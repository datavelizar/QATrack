using StageTelerikAcademy.Core.Pages.LoginPage;
using StageTelerikAcademy.Core.Pages.StudentsRecordsPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core.Data;

namespace StageTelerikAcademy.Core.Facades
{
    public class StudentsRecordsFacade
    {
        public User AdminUser { get; set; }
        public LoginPage LoginPage { get; set; }
        public StudentsRecordsPage StudentsRecordsPage { get; set; }

        public readonly string CourseName = "StudentsRecords";

        public StudentsRecordsFacade()
        {
            this.LoginPage = new LoginPage();
            this.StudentsRecordsPage = new StudentsRecordsPage();
        }

        public void DownloadFile()
        {
            this.LoginPage.LoginUser(AdminUser);
            this.StudentsRecordsPage.ExportCourseResults(CourseName);
        }

        public void ValidateAdminPage()
        {
            this.LoginPage.LoginUser(AdminUser);
            this.StudentsRecordsPage.ValidateAdminNavigation();
        }
    }
}
