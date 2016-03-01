using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Pages.LoginPage;
using StageTelerikAcademy.Core.Pages.StudentsRecordsPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Utilities.Atributes;
using TestingFramework.Core.Constants;
using TestingFramework.Core;
using TestingFramework.Core.Data;
using StageTelerikAcademy.Core.Facades;

namespace StageTelerikAcademy.Test.Admin.Evaluation
{
    [TestClass]
    public class StudentsRecords : BaseTest
    {
        private StudentsRecordsFacade StudentsRecordsFacade;
        
        public override void TestInit()
        {
            this.StudentsRecordsFacade = new StudentsRecordsFacade();
            StudentsRecordsFacade.AdminUser = new User()
            {
                Username = "TeamArcher",
                Password = "teamarcher"
            };
        }


        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
        [TestCaseId(174)]
        public void DownloadExcelFileSuccessfuly()
        {
            this.StudentsRecordsFacade.DownloadFile();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.Low)]
        [TestCaseId(109)]
        public void ValidateAdminNavigationPage()
        {
            this.StudentsRecordsFacade.ValidateAdminPage();
        }
    }
}
