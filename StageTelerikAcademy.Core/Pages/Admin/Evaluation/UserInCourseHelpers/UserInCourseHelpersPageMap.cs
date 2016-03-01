using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.Admin.Evaluation.UserInCourseHelpers
{
    public class UserInCourseHelpersPageMap : BaseElementMap
    {
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

        //public HtmlAnchor AdminMenuInAdminNavPage
        //{
        //    get
        //    {
        //        Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("textContent=~Админ"), 2500, false);
        //        return this.Find.ByExpression<HtmlAnchor>("href=/Administration/Navigation", "textContent=~Админ");
        //    }
        //}
    }
}
