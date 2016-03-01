using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StageTelerikAcademy.Core.Pages.AddBonusPage
{
    public class AddBonusPageAsserter
    {
        public AddBonusPageMap Map
        {
            get
            {
                return new AddBonusPageMap();
            }
        }

        public void IsFileIsDownloaded(string filePath)
        {
            Assert.IsTrue(File.Exists(filePath));
        }

        //public void IsFileNotDownloaded(DownloadDialogsHandler dialog)
        //{
        //    Assert.IsNull(dialog);
        //}

        public void CorrectPage()
        {
            Assert.AreEqual("Бонус точки - Телерик Академия - Студентска система", Map.CurentPageTitle);
            Assert.AreEqual("http://stage.telerikacademy.com/Administration_Courses/UsersInCoursesBonuses", Map.CurentUrl);
        }
    }
}
