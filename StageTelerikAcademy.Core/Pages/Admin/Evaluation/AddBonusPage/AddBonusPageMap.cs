using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.AddBonusPage
{
    public class AddBonusPageMap : BaseElementMap
    {
        public HtmlAnchor ExportToExcelLink
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("export");
            }
        }

        public HtmlAnchor BonusAddButton
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("href=/Administration_Courses/UsersInCoursesBonuses/UsersInCoursesBonusesRead?DataGrid-mode=insert");
            }
        }

        public HtmlControl BackToAdministrationButton
        {
            get
            {
                return this.Find.ByContent<HtmlControl>("Обратно към администрацията");
                //return this.Find.ByContent<HtmlControl>("href=/Administration/Navigation");  
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
