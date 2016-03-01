using ArtOfTest.Common.UnitTesting;
using StageTelerikAcademy.Core.Pages.Admin.MainAdminPage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Admin.Evaluation.ParticipatingInTeamworkPagе
{
    public class ParticipatingInTeamworkPageAsserter
    {
        public ParticipatingInTeamworkPagеMap Map
        {
            get
            {
                return new ParticipatingInTeamworkPagеMap();
            }
        }

        public AdminNavigationPageMap NavMap
        {
            get
            {
                return new AdminNavigationPageMap();
            }
        }

        public void IsFileIsDownloaded(string filePath)
        {
            Assert.IsTrue(File.Exists(filePath));
        }

        public void IsGoingBackToAdministration()
        {
            Assert.AreEqual(NavMap.AdminMenuInAdminNavPage.HRef, Map.BackToAdminButton.HRef);
        }
    }
}
