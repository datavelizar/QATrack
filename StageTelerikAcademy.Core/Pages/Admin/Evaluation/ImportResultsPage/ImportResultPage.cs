using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Win32.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.ImportResultsPage
{
    public class ImportResultPage : BaseElementMap
    {
        public readonly string FilePath = Directory.GetCurrentDirectory() + @"\GridExcelExport_259.xls";

        public ImportResultPageMap Map
        {
            get
            {
                return new ImportResultPageMap();
            }
        }

        public ImportResultPageAsserter Asserter
        {
            get
            {
                return new ImportResultPageAsserter();
            }
        }

        public void CorrectData(string courseName)
        {
            Manager.Current.ActiveBrowser.Window.Maximize();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            Manager.Current.ActiveBrowser.ScrollBy(0, 500);

            this.Map.SelectFilsUpload.Upload(FilePath, 30000);
                        
            this.Map.SpanUlUserInCourseId.Click();
            this.Map.LiUserInCourseId("B").Click();                        

            this.Map.PassedCheckbox.Click();
            this.Map.SpanUlPassedColumn.Click();
            this.Map.LiPassedColumn("G").Click();
            
            this.Map.ExellentResultCheckbox.Click();
            this.Map.SpanUlExellentResultColumn.Click();
            this.Map.LiExellentResultColumn("H").Click();
            
            this.Map.PointsCheckbox.Click();
            this.Map.SpanUlPointsColumn.Click();
            this.Map.LiPointsColumn("F").Click();
                        
            this.Map.ImportButton.Click();

            this.Asserter.SuccessMessagePresent();

        }

        public void IncorectData(string courseName)
        {
            Manager.Current.ActiveBrowser.Window.Maximize();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            Manager.Current.ActiveBrowser.ScrollBy(0, 500);

            this.Map.SelectFilsUpload.Upload(FilePath, 30000);

            this.Map.SpanUlUserInCourseId.Click();
            this.Map.LiUserInCourseId("A").Click();

            this.Map.PassedCheckbox.Click();
            this.Map.SpanUlPassedColumn.Click();
            this.Map.LiPassedColumn("B").Click();

            this.Map.ExellentResultCheckbox.Click();
            this.Map.SpanUlExellentResultColumn.Click();
            this.Map.LiExellentResultColumn("C").Click();

            this.Map.PointsCheckbox.Click();
            this.Map.SpanUlPointsColumn.Click();
            this.Map.LiPointsColumn("D").Click();

            this.Map.CanDoTestExamCheckbox.Click();
            this.Map.SpanUlCanDoTestExamColumn.Click();
            this.Map.LiCanDoTestExamColumn("E").Click();

            this.Map.ImportButton.Click();

            this.Asserter.IncorectMessagePresent();
        }

        public void ObligatoryDataEntry(string courseName)
        {
            Manager.Current.ActiveBrowser.Window.Maximize();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            Manager.Current.ActiveBrowser.ScrollBy(0, 500);

            this.Map.SelectFilsUpload.Upload(FilePath, 30000);

            this.Map.ImportButton.Click();

            this.Asserter.RequiredColumnEntryMessage();
        }

        public void NoFileSelected(string courseName)
        {
            Manager.Current.ActiveBrowser.Window.Maximize();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            Manager.Current.ActiveBrowser.ScrollBy(0, 500);

            this.Map.SpanUlUserInCourseId.Click();
            this.Map.LiUserInCourseId("B").Click();

            this.Map.PassedCheckbox.Click();
            this.Map.SpanUlPassedColumn.Click();
            this.Map.LiPassedColumn("G").Click();

            this.Map.ExellentResultCheckbox.Click();
            this.Map.SpanUlExellentResultColumn.Click();
            this.Map.LiExellentResultColumn("H").Click();

            this.Map.PointsCheckbox.Click();
            this.Map.SpanUlPointsColumn.Click();
            this.Map.LiPointsColumn("F").Click();

            this.Map.ImportButton.Click();

            this.Asserter.NoFileSelectedMessage();
        }
    }
}
