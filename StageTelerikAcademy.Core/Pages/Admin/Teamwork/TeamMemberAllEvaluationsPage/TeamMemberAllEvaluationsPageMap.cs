using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.Admin.Teamwork.TeamMemberAllEvaluationsPage
{
    public class TeamMemberAllEvaluationsPageMap : BaseElementMap
    {
        public HtmlButton ExportExcelFile
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitUntilReady();
                return this.Find.ByExpression<HtmlButton>("class=k-button k-button-icontext k-grid-excel");
            }
        }

        public HtmlButton ExportPdfFile
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitUntilReady();
                return this.Find.ByExpression<HtmlButton>("class=k-button k-button-icontext k-grid-pdf");
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

        public HtmlAnchor UpdateButtonInGridRow
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitUntilReady();
                return this.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-edit");
            }
        }

        public HtmlAnchor DeleteButtonInGridRow
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitUntilReady();
                return this.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-delete");
            }
        }

        public HtmlAnchor UpdateButtonOnPopUp
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("class=k-button k-button-icontext k-primary k-grid-update"), 3000, false);
                return this.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-primary k-grid-update");
            }
        }

        public HtmlAnchor CancleButtonOnPopUp
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("class=k-button k-button-icontext k-grid-cancel"), 3000, false);
                return this.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-cancel");
            }
        }

        public HtmlSpan CountOfRowsInGridLabelBeforeDeleting
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("class=k-pager-info k-label"), 3000, false);
                return this.Find.ByExpression<HtmlSpan>("class=k-pager-info k-label");
            }
        }

        public HtmlSpan CountOfRowsInGridLabelAfterDeleting
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("class=k-pager-info k-label"), 3000, false);
                return this.Find.ByExpression<HtmlSpan>("class=k-pager-info k-label");
            }
        }

        public HtmlSpan RefreshButton
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("class=k-icon k-i-refresh"), 3000, false);
                return this.Find.ByExpression<HtmlSpan>("class=k-icon k-i-refresh");
            }
        }

        public HtmlAnchor AddFileButton
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("class=k-button k-button-icontext k-grid-add"), 3000, false);
                return this.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-add");
            }
        }

        public HtmlInputText ChoseTeamwork
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("class=k-input", "placeholder=Изберете отборна работа"), 3000, false);
                return this.Find.ByExpression<HtmlInputText>("class=k-input", "placeholder=Изберете отборна работа");
            }
        }

        public HtmlInputText ChoseTeam
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("class=k-input", "placeholder=Изберете отбор"), 3000, false);
                return this.Find.ByExpression<HtmlInputText>("class=k-input", "placeholder=Изберете отбор");
            }
        }

        public HtmlInputText ChoseUser
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("aria-owns=UserId_listbox", "placeholder=~Изберете участник"), 3000, false);
                return this.Find.ByExpression<HtmlInputText>("aria-owns=UserId_listbox", "placeholder=~Изберете участник");
            }
        }

        public HtmlInputText EvaluatedByUser
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=EvaluatedByUsername"), 3000, false);
                return this.Find.ById<HtmlInputText>("EvaluatedByUsername");
            }
        }

        public HtmlInputText Valuation
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=Valuation"), 3000, false);
                return this.Find.ById<HtmlInputText>("Valuation");
            }
        }
    }
}
