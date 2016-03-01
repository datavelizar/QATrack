using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFramework.Utilities.Atributes;
using TestingFramework.Core.Constants;
using TestingFramework.Core;
using TestingFramework.Core.Data;
using StageTelerikAcademy.Core.Pages.LoginPage;
using StageTelerikAcademy.Core.Pages.EvaluationExportPage;
using StageTelerikAcademy.Core.Facades;
using System.IO;

namespace StageTelerikAcademy.Test.Admin.Evaluation
{
    [TestClass]
    public class ExportResults : BaseTest
    {
        private ExportResultsFacade ExportResultsFacade;

        public override void TestInit()
        {
            this.ExportResultsFacade = new ExportResultsFacade();
            ExportResultsFacade.currentUser = new User()
            {
                Username = "TeamArcher",
                Password = "teamarcher"
            };
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.High)]
		[TestCaseId(157)]
        public void DownloadExportedFileSuccesfuly()
        {
            string filePath = Directory.GetCurrentDirectory() + @"\export.xls";

            this.ExportResultsFacade.DownloadFile(filePath);
        }
    }
}
