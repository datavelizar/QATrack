using ArtOfTest.WebAii.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.ImportResultsPage
{
    public class ImportResultPageAsserter
    {
        public ImportResultPageMap Map
        {
            get
            {
                return new ImportResultPageMap();
            }
        }

        public void SuccessMessagePresent()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            System.Threading.Thread.Sleep(1000);
            string actual = this.Map.SuccessMessage.InnerText;
            Assert.AreEqual("Резултатите бяха импортнати успешно", actual);
        }

        public void IncorectMessagePresent()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            System.Threading.Thread.Sleep(1000);
            string actual = this.Map.IncorectMessage.InnerText;
            Assert.AreEqual("Възникна грешка по време на импорта: Input string was not in a correct format.", actual);
        }

        public void RequiredColumnEntryMessage()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            System.Threading.Thread.Sleep(1000);
            string actual = this.Map.RequireColumnMessage.InnerText;
            Assert.AreEqual("Възникна грешка по време на импорта: Column UserInCourseId is mandatory", actual);
        }

        public void NoFileSelectedMessage()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            System.Threading.Thread.Sleep(1000);
            string actual = this.Map.NotSelectedFile.InnerText;
            Assert.AreEqual("Моля прикачете файл", actual);
        }
    }
}
