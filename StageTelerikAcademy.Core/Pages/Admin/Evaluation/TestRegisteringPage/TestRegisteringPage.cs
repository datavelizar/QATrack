using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Win32.Dialogs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StageTelerikAcademy.Core.Pages.TestRegisteringPage
{
    public class TestRegisteringPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Administration_Courses/CourseTestExams/AddStudents";
        public readonly string FilePath = Directory.GetCurrentDirectory() + @"\StudentsForTestSubscription.xls";
     
        public TestRegisteringPageMap Map
        {
            get
            {
                return new TestRegisteringPageMap();
            }
        }

        public TestRegisteringPageAsserter Asserter
        {
            get
            {
                return new TestRegisteringPageAsserter();
            }
        }

        public void AddFile()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();

            this.Map.ChooseTest.MouseClick();
            Manager.Current.ActiveBrowser.WaitUntilReady();

            this.Map.TestExam.Click();

            this.Map.RegisteringCriteria.Click();

            this.Map.IdAsCriteria.Click();

            this.Map.ColumnToChoose.Click();
            Manager.Current.ActiveBrowser.RefreshDomTree();
            Manager.Current.ActiveBrowser.WaitUntilReady();

            this.Map.ColumnA.Click();

            var x = new FileUploadDialog(
                Manager.Current.ActiveBrowser, FilePath, DialogButton.OPEN);
                 
            Manager.Current.DialogMonitor.Start();
            Manager.Current.DialogMonitor.AddDialog(x);

            this.Map.SelectFileButton.Click();
            
            x.WaitUntilHandled(10000);

            this.Map.RegisterStudentsButton.Click();
            Thread.Sleep(3000);
           
                var successTitle = Manager.Current.ActiveBrowser.Find.AllByTagName("h2");
            foreach (var item in successTitle)
            {
                if (item.InnerText == "Успешно добавяне на студенти в изпит")
                {
                    Assert.AreEqual("Успешно добавяне на студенти в изпит", item.InnerText);
                }
            }
        }
        
        //AddingEmptyTestExamField
        public void AddingEmptyTestExamField()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.RegisterStudentsButton.Click();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            var typeColumnErrorMessage = this.Map.Find.ByContent<HtmlControl>("Моля, изберете тестови изпит.");
            Assert.IsNotNull(typeColumnErrorMessage);
        }
        
        //AddingEmptyTypeColumn
        public void AddingEmptyTypeColumn()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.RegisterStudentsButton.Click();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            var typeColumnErrorMessage = this.Map.Find.ByContent<HtmlControl>("Моля, изберете файл със студенти.");
            Assert.IsNotNull(typeColumnErrorMessage);
        }

        //Моля, изберете критерий за записване на студентите.
        public void AddingEmptyCriteria()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.RegisterStudentsButton.Click();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            var typeColumnErrorMessage = this.Map.Find.ByContent<HtmlControl>("Моля, изберете критерий за записване на студентите.");
            Assert.IsNotNull(typeColumnErrorMessage);
        }

        //Моля, изберете колона със стойности за студентите.
        public void AddingEmptyStudentsColumn()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.RegisterStudentsButton.Click();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            var typeColumnErrorMessage = this.Map.Find.ByContent<HtmlControl>("Моля, изберете колона със стойности за студентите.");
            Assert.IsNotNull(typeColumnErrorMessage);
        }
        
        //    AddingNotSelectedFile()
        public void AddingNotSelectedFile()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.RegisterStudentsButton.Click();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            var typeColumnErrorMessage = this.Map.Find.ByContent<HtmlControl>("Моля, изберете файл със студенти.");
            Assert.IsNotNull(typeColumnErrorMessage);
        }
        
    }
}
