using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.StudentsRecordsPage
{
    public class StudentsRecordsPageMap : BaseElementMap
    {
        public HtmlAnchor AddFile
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitUntilReady();
                return this.Find.ByXPath<HtmlAnchor>(".//*[@id='DataGrid']/div[1]/a[2]");
            }
        }

        public HtmlAnchor ExportExcelFile
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitUntilReady();
                return this.Find.ById<HtmlAnchor>("export");
            }
        }

        public HtmlAnchor AdminNavigation
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitUntilReady();
                return this.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button", "href=/Administration/Navigation");
            }
        }

        public string CurentUrl
        {
            get
            {
                return Manager.Current.ActiveBrowser.Url;
            }
        }

        public string CurentPageTitle
        {
            get
            {
                return Manager.Current.ActiveBrowser.PageTitle;
            }
        }
    }
}
