using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Facades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;
using TestingFramework.Core.Constants;
using TestingFramework.Core.Data;
using TestingFramework.Utilities.Atributes;

namespace StageTelerikAcademy.Test.Admin.Teamwork
{
    [TestClass]
    public class Teamworks : BaseTest
    {
        private TeamworksFacade TeamworksFacade;

        public override void TestInit()
        {
            this.TeamworksFacade = new TeamworksFacade();
            TeamworksFacade.user = new User()
            {
                Username = "TeamArcher",
                Password = "teamarcher"
            };
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.Medium)]
        [TestCaseId(178)]
        public void ValidateAdminNavigationPage()
        {
            this.TeamworksFacade.BackToAdminButton();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.Medium)]
        [TestCaseId(177)]
        public void ValidatePopUpWindow()
        {
            this.TeamworksFacade.PopUpWindowForUpdateSettingsIsShown();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
        [TestCaseId(176)]
        public void VerifyDeletingRowInGrid()
        {
            this.TeamworksFacade.DeletingRowInGrid();
        }

        [TestMethod]
        [Owner(Author.Pesho)]
        [Priority(Priority.High)]
        [TestCaseId(116)]
        public void VerifyAddingFileInGrid()
        {
            this.TeamworksFacade.AddingFileInGrid();
        }
    }
}
