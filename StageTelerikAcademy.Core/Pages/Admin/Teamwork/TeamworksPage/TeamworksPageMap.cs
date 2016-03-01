using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.Admin.Teamwork.TeamworksPage
{
    public class TeamworksPageMap : BaseElementMap
    {
        public HtmlAnchor CreateTeamworkButton
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitUntilReady();
                return this.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-add");
            }
        }

        public HtmlInputText TeamworkNameTestBox
        {
            get
            {
                Manager.Current.ActiveBrowser.RefreshDomTree();
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=Name"), 2500, false);
                return this.Find.ById<HtmlInputText>("Name");
            }
        }

        public HtmlSpan CourseInstanceIdSpan
        {
            get
            {
                //Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression(".//*[@id='MainContent']/div/form/table[1]/tbody/tr[1]/td[1]/span/span/span[1]"), 5000, false);
                return this.Find.ByXPath<HtmlSpan>("html/body/div[5]/div[2]/div/div[4]/span[1]/span/input");
            }
        }

        public HtmlDiv DivCourseInstanceId
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=CourseInstanceId-list"), 5000, false);
                return this.Find.ById<HtmlDiv>("CourseInstanceId-list");
            }
        }

        public HtmlUnorderedList UlCourseInstanceId
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=CourseInstanceId_listbox"), 5000, false);
                return this.DivCourseInstanceId.Find.ById<HtmlUnorderedList>("CourseInstanceId_listbox");
            }
        }

        public HtmlListItem CourseInstanceId
        {
            get
            {
                return this.UlCourseInstanceId.Find.ByExpression<HtmlListItem>("innerText=Бази Данни");
            }
        }

        public HtmlInputCheckBox EvaluationActiveCheckbox
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("IsEvaluationActive");
            }
        }

        public HtmlInputCheckBox AcceptSuggestionsActiveCheckbox
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("IsAcceptSuggestionsActive");
            }
        }

        public HtmlAnchor UpdatePopUpWindowButton
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitUntilReady();
                return this.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-primary k-grid-update");
            }
        }

        public HtmlAnchor AddEvaluationButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button");
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

        public HtmlAnchor AdminNavigation
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitUntilReady();
                return this.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button", "href=/Administration/Navigation");
            }
        }
    }
}
