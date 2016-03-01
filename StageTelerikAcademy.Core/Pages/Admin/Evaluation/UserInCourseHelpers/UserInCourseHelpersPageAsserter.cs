using ArtOfTest.WebAii.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Pages.Admin.MainAdminPage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Admin.Evaluation.UserInCourseHelpers
{
    public class UserInCourseHelpersPageAsserter
    {
        public UserInCourseHelpersPageMap Map
        {
            get
            {
                return new UserInCourseHelpersPageMap();
            }
        }

        public AdminNavigationPageMap Mapper
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

        public void VerifyAdminNavigation()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            string adminHrf = "/Administration/Navigation";
            Assert.AreEqual(adminHrf, this.Mapper.AdminMenuInAdminNavPage.HRef);

        }
    }
}
