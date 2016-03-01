using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArtOfTest.WebAii.Core;

namespace TestingFramework.Core
{
    [TestClass]
    public class BaseTest
    {
        [TestInitialize]
        public void CoreTestInit()
        {
            this.InitializeBrowser();
            this.TestInit();
        }

        [TestCleanup]
        public void CoreTestCleanup()
        {
            this.DisposeBrowser();
            this.TestCleanUp();
        }

        private void InitializeBrowser()
        {

            Settings mySettings = new Settings();
            mySettings.Web.DefaultBrowser = BrowserType.InternetExplorer;
            //mySettings.Web.DefaultBrowser = BrowserType.FireFox;
            //mySettings.Web.DefaultBrowser = BrowserType.Chrome;
            mySettings.AnnotateExecution = true;
            mySettings.ExecutionDelay = 200;
            if (mySettings.Web.DefaultBrowser == BrowserType.InternetExplorer)
            {
                mySettings.UnexpectedDialogAction = UnexpectedDialogAction.DoNotHandle;// needed for IE file download (Velizar), FF migth work
            }
            else
            {
                mySettings.UnexpectedDialogAction = UnexpectedDialogAction.HandleAndContinue; //FF works, IE doesn't
            }
            var manager = new Manager(mySettings);
            manager.Start();
            Manager.Current.LaunchNewBrowser();
            Manager.Current.ActiveBrowser.ClearCache(BrowserCacheType.Cookies);
            Manager.Current.ActiveBrowser.ClearCache(BrowserCacheType.History);
            Manager.Current.ActiveBrowser.ClearCache(BrowserCacheType.TempFilesCache);
        }

        private void DisposeBrowser()
        {
            //If we have more than one open browser
            foreach (var browser in Manager.Current.Browsers)
            {
                browser.Close();
            }

            Manager.Current.Dispose();
        }

        //Will help us in sibling class to set it
        public virtual void TestInit()
        {
        }

        public virtual void TestCleanUp()
        {
        }
    }
}
