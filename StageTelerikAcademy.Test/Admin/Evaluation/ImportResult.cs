using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Pages.ImportResultsPage;
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
    public class ImportResult : BaseTest
    {
        private ImportResultFacade service; 

        public override void TestInit()
        {
            this.service = new ImportResultFacade();
            service.CurrentUser= new User()
            {
                Username = "TeamArcher",
                Password = "teamarcher"
            };
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
        [TestCaseId(106)]
        public void ImportResultFileSuccesfuly()
        {
            this.service.ImportResult();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
        [TestCaseId(110)]
        public void UnsuccesfulImportResult()
        {
            this.service.UnsuccesfulImport();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
        [TestCaseId(172)]
        public void RequiredDataEntry()
        {
            this.service.RequiredData();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
        [TestCaseId(173)]
        public void WithoutSelectingFile()
        {
            this.service.WithoutFile();
        }
    }
}
