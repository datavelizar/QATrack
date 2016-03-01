using StageTelerikAcademy.Core.Pages.ImportResultsPage;
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
    public class ImportResultFacade
    {
        public User CurrentUser { get; set; }
        public LoginPage LoginPage { get; set; }
        public StudentsRecordsPage StudentsRecordsPage { get; set; }
        public ImportResultPage ImportResultPage { get; set; }
        public readonly string CourseName = "ImportTestProtocol";

        public ImportResultFacade()
        {
            this.LoginPage = new LoginPage();
            this.StudentsRecordsPage = new StudentsRecordsPage();
            this.ImportResultPage = new ImportResultPage();
        }

        public void ImportResult()
        {
            this.LoginPage.LoginUser(CurrentUser);
            this.StudentsRecordsPage.AddFile();
            this.ImportResultPage.CorrectData(CourseName);
        }

        public void UnsuccesfulImport()
        {
            this.LoginPage.LoginUser(CurrentUser);
            this.StudentsRecordsPage.AddFile();
            this.ImportResultPage.IncorectData(CourseName);
        }

        public void RequiredData()
        {
            this.LoginPage.LoginUser(CurrentUser);
            this.StudentsRecordsPage.AddFile();
            this.ImportResultPage.ObligatoryDataEntry(CourseName);
        }

        public void WithoutFile()
        {
            this.LoginPage.LoginUser(CurrentUser);
            this.StudentsRecordsPage.AddFile();
            this.ImportResultPage.NoFileSelected(CourseName);
        }
    }
}
