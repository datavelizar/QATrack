using ArtOfTest.WebAii.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Pages.Admin.MainAdminPage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.StudentsRecordsPage
{
    public class StudentsRecordsPageAsserter
    {
        //private readonly string AdministrationHmoePageUrlRelative = "/Administration/Navigation";

        public StudentsRecordsPageMap Map
        {
            get
            {
                return new StudentsRecordsPageMap();
            }
        }

        //public AdminNavigationPageMap Mapper
        //{
        //    get
        //    {
        //        return new AdminNavigationPageMap();
        //    }
        //}
        public void IsFileIsDownloaded(string filePath)
        {
            Assert.IsTrue(File.Exists(filePath));
        }

        public void VerifyAdminNavigation()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            //string adminHrf = "/Administration/Navigation";
            //Assert.IsTrue(this.Map.AdminNavigation.IsVisible(), "Not visble");
            //Assert.AreEqual(this.Map.AdminNavigation.HRef, this.AdministrationHmoePageUrlRelative);
            Assert.AreEqual("Index - Телерик Академия - Студентска система", Map.CurentPageTitle);
            Assert.AreEqual("http://stage.telerikacademy.com/Administration_Courses/Evaluation", Map.CurentUrl);
        }
    }
}
