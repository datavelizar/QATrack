using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Win32.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.EvaluationGenerateProtocolPage
{
    public class GenerateProtocolPageAsserter
    {
        public GenerateProtocolPageMap Map
        {
            get
            {
                return new GenerateProtocolPageMap();
            }
        }

        public void IsFileIsDownloaded(string filePath)
        {
            Assert.IsTrue(File.Exists(filePath));
        }

        public void IsFileNotDownloaded(DownloadDialogsHandler dialog)
        {
            Assert.IsNull(dialog);
        }

        public void CorrectPage()
        {
            Assert.AreEqual("Evaluation - Телерик Академия - Студентска система", Map.CurentPageTitle);
            Assert.AreEqual("http://stage.telerikacademy.com/Administration_Courses/Evaluation", Map.CurentUrl);
        }
    }
}
