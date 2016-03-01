using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Win32.Dialogs;
using System.IO;
using System.Linq;
using ArtOfTest.WebAii.Controls.HtmlControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StageTelerikAcademy.Core.Pages.Teamwork.ImportOfTeamNamesPage
{
    public class ImportOfTeamNamesPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Administration_Teamwork/TeamNameSuggestions/ImportTeamNameSuggestions";
        public readonly string FilePath = Directory.GetCurrentDirectory() + @"\TeamNamesForImport.xls";

        public ImportOfTeamNamesPageMap Map
        {
            get
            {
                return new ImportOfTeamNamesPageMap();
            }
        }

        public ImportOfTeamNamesPageAsserter Asserter
        {
            get
            {
                return new ImportOfTeamNamesPageAsserter();
            }
        }
        
        public void SelectFile()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Manager.Current.ActiveBrowser.WaitUntilReady();
           
            var x = new FileUploadDialog(Manager.Current.ActiveBrowser, FilePath, DialogButton.OPEN);
            Manager.Current.DialogMonitor.Start();
            Manager.Current.DialogMonitor.AddDialog(x);

            Map.FileUploadLink.Click();

            x.WaitUntilHandled(10000);
            var selectedFileTitle = this.Map.Find.AllByContent("TeamNamesForImport.xls");
            Assert.IsNotNull(selectedFileTitle);
        }

        public void ImportTeamNames()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Map.ChooseNameTypes.MouseClick();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            Map.TypeOne.Click();

            Map.ColumnToChooseNamesFrom.Click();

            Map.ColumnA.Click();

            var x = new ArtOfTest.WebAii.Win32.Dialogs.FileUploadDialog(Manager.Current.ActiveBrowser, FilePath, DialogButton.OPEN);
            Manager.Current.DialogMonitor.Start();
            Manager.Current.DialogMonitor.AddDialog(x);

            Map.FileUploadLink.Click();

            x.WaitUntilHandled(10000);

            Manager.Current.DialogMonitor.AddDialog(new AlertDialog(Manager.Current.ActiveBrowser, DialogButton.OK));
            // Given that there were not dialog attribute set, the manager will not start the monitoring.
            // You need to invoke the monitoring
            Manager.Current.DialogMonitor.Start();

            Map.RegisterStudentsButton.Click();

            Manager.Current.ActiveBrowser.NavigateTo("http://stage.telerikacademy.com/Administration_Teamwork/TeamNameSuggestions");

            Manager.Current.ActiveBrowser.WaitUntilReady();
            Manager.Current.ActiveBrowser.RefreshDomTree();

            var lastTabIndex = Map.Find.AllByAttributes<HtmlAnchor>("tabindex=-1", "class=k-icon k-plus").LastOrDefault();
            lastTabIndex.Click();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            Manager.Current.ActiveBrowser.RefreshDomTree();

            Assert.IsNotNull(Map.Find.ByContent<HtmlTableCell>("Badgers"));
            Assert.IsNotNull(Map.Find.ByContent<HtmlTableCell>("Bandits"));
            Assert.IsNotNull(Map.Find.ByContent<HtmlTableCell>("Barracudas"));
        }

        public void EmptyTeamNamesFieldCheck()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Map.RegisterStudentsButton.Click();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            var teamNamesErrorMessage = this.Map.Find.ByContent<HtmlControl>("Моля, въведете тип на имената на отборите.");
            Assert.IsNotNull(teamNamesErrorMessage);
        }

        public void EmptyTypeColumn()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Map.RegisterStudentsButton.Click();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            var typeColumnErrorMessage = this.Map.Find.ByContent<HtmlControl>("Моля, изберете колона с имената на отборите.");
            Assert.IsNotNull(typeColumnErrorMessage);
        }

        public void NotSelectedFile()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            Map.RegisterStudentsButton.Click();
            Manager.Current.ActiveBrowser.WaitUntilReady();
            var typeColumnErrorMessage = this.Map.Find.ByContent<HtmlControl>("Моля, изберете файл с имената на отборите.");
            Assert.IsNotNull(typeColumnErrorMessage);
        }
    }
}