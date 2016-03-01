using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.TestStudio.Translators.KendoUI;

namespace StageTelerikAcademy.Core.Pages.ImportResultsPage
{
    public class ImportResultPageMap : BaseElementMap
    {
        public HtmlInputFile SelectFilsUpload
        {
            get
            {
                return this.Find.ById<HtmlInputFile>("files");
            }
        }

        public HtmlSpan SpanUlUserInCourseId
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>(".//*[@id='MainContent']/div/form/div/div[2]/span[2]/span/span[1]");
            }
        }

        public HtmlDiv UserInCourseId
        {
            get 
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=userInCourseIdColumn-list"), 3000, false);
                return Find.ById<HtmlDiv>("userInCourseIdColumn-list");
            }
        }

        public HtmlUnorderedList UlUserInCourseId
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=userInCourseIdColumn_listbox"), 30000, false);
                return this.UserInCourseId.Find.ById<HtmlUnorderedList>("userInCourseIdColumn_listbox");
            }
        }

        //public HtmlListItem ListUserInCourseId
        //{
        //    get
        //    {
        //        return this.UlUserInCourseId.Find.ByExpression<HtmlListItem>("data-offset-index=1", "textContent=A");
        //    }
        //}

        public HtmlControl PassedCheckbox
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("for=passedCheckbox"), 2500, false);
                return this.Find.ByExpression<HtmlControl>("for=passedCheckbox");
            }
        }

        public HtmlSpan SpanUlPassedColumn
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>(".//*[@id='MainContent']/div/form/div/div[3]/span[2]/span/span[1]");
            }
        }

        public HtmlDiv PassedColumn
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=passedColumn-list"), 5000, false);
                return Find.ById<HtmlDiv>("passedColumn-list");
            }
        }

        public HtmlUnorderedList UlPassedColumn
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=passedColumn_listbox"), 30000, false);
                return this.PassedColumn.Find.ById<HtmlUnorderedList>("passedColumn_listbox");
            }
        }

        //public HtmlListItem ListPassedColumn
        //{
        //    get
        //    {
        //        return this.UlPassedColumn.Find.ByExpression<HtmlListItem>("data-offset-index=2", "textContent=B");
        //    }
        //}

        public HtmlControl ExellentResultCheckbox
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("for=excellentCheckbox"), 2500, false);
                return this.Find.ByExpression<HtmlControl>("for=excellentCheckbox");
            }
        }

        public HtmlSpan SpanUlExellentResultColumn
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>(".//*[@id='MainContent']/div/form/div/div[4]/span[2]/span/span[1]");
            }
        }

        public HtmlDiv ExellentResultColumn
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=excellentColumn-list"), 3000, false);
                return Find.ById<HtmlDiv>("excellentColumn-list");
            }
        }

        public HtmlUnorderedList UlExellentResultColumn
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=excellentColumn_listbox"), 30000, false);
                return this.ExellentResultColumn.Find.ById<HtmlUnorderedList>("excellentColumn_listbox");
            }
        }

        //public HtmlListItem ListExellentResultColumn
        //{
        //    get
        //    {
        //        return this.UlExellentResultColumn.Find.ByExpression<HtmlListItem>("data-offset-/index=3", /"textContent=C");
        //    }
        //}

        public HtmlControl PointsCheckbox
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("for=pointsCheckbox"), 2500, false);
                return this.Find.ByExpression<HtmlControl>("for=pointsCheckbox");
            }
        }

        public HtmlSpan SpanUlPointsColumn
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>(".//*[@id='MainContent']/div/form/div/div[5]/span[2]/span/span[1]");
            }
        }

        public HtmlDiv PointsColumn
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=pointsColumn-list"), 3000, false);
                return Find.ById<HtmlDiv>("pointsColumn-list");
            }
        }

        public HtmlUnorderedList UlPointsColumn
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=pointsColumn_listbox"), 30000, false);
                return this.PointsColumn.Find.ById<HtmlUnorderedList>("pointsColumn_listbox");
            }
        }

        //public HtmlListItem ListPointsColumn

        public HtmlControl CanDoTestExamCheckbox
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("for=canDoTestExamCheckbox"), 2500, false);
                return this.Find.ByExpression<HtmlControl>("for=canDoTestExamCheckbox");
            }
        }

        public HtmlSpan SpanUlCanDoTestExamColumn
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>(".//*[@id='MainContent']/div/form/div/div[6]/span[2]/span/span[1]");
            }
        }

        public HtmlDiv CanDoTestExamColumn
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=canDoTestExamColumn-list"), 3000, false);
                return Find.ById<HtmlDiv>("canDoTestExamColumn-list");
            }
        }

        public HtmlUnorderedList UlCanDoTestExamColumn
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=canDoTestExamColumn_listbox"), 30000, false);
                return this.CanDoTestExamColumn.Find.ById<HtmlUnorderedList>("canDoTestExamColumn_listbox");
            }
        }

        public HtmlControl CanDoPracticalExamCheckbox
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("for=canDoPracticalExamCheckbox"), 2500, false);
                return this.Find.ByExpression<HtmlControl>("for=canDoPracticalExamCheckbox");
            }
        }

        public HtmlSpan SpanUlCanDoPracticalExamColumn
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>(".//*[@id='MainContent']/div/form/div/div[7]/span[2]/span/span[1]");
            }
        }

        public HtmlDiv CanDoPracticalExamColumn
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=canDoPracticalExamColumn-list"), 3000, false);
                return Find.ById<HtmlDiv>("canDoPracticalExamColumn-list");
            }
        }

        public HtmlUnorderedList UlCanDoPracticalExamColumn
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=canDoPracticalExamColumn_listbox"), 30000, false);
                return this.CanDoPracticalExamColumn.Find.ById<HtmlUnorderedList>("canDoPracticalExamColumn_listbox");
            }
        }

        public HtmlControl PracticalExamCheckbox
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("for=practicalExamCheckbox"), 2500, false);
                return this.Find.ByExpression<HtmlControl>("for=practicalExamCheckbox");
            }
        }

        public HtmlSpan SpanUlPracticalExamColumn
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>(".//*[@id='MainContent']/div/form/div/div[8]/span[2]/span/span[1]");
            }
        }

        public HtmlDiv PracticalExamColumn
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=practicalExamColumn-list"), 3000, false);
                return Find.ById<HtmlDiv>("practicalExamColumn-list");
            }
        }

        public HtmlUnorderedList UlPracticalExamColumn
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=practicalExamColumn_listbox"), 30000, false);
                return this.PracticalExamColumn.Find.ById<HtmlUnorderedList>("practicalExamColumn_listbox");
            }
        }

        public HtmlControl IsLiveParticipantCheckbox
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("for=isLiveParticipantCheckbox"), 2500, false);
                return this.Find.ByExpression<HtmlControl>("for=isLiveParticipantCheckbox");
            }
        }

        public HtmlSpan SpanUlIsLiveParticipantColumn
        {
            get
            {
                return this.Find.ByXPath<HtmlSpan>(".//*[@id='MainContent']/div/form/div/div[8]/span[2]/span/span[1]");
            }
        }

        public HtmlDiv IsLiveParticipantColumn
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=isLiveParticipantColumn-list"), 3000, false);
                return Find.ById<HtmlDiv>("isLiveParticipantColumn-list");
            }
        }

        public HtmlUnorderedList UlIsLiveParticipantColumn
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=isLiveParticipantColumn_listbox"), 30000, false);
                return this.IsLiveParticipantColumn.Find.ById<HtmlUnorderedList>("isLiveParticipantColumn_listbox");
            }
        }

        public HtmlInputSubmit ImportButton
        {
            get
            {
                return this.Find.ByExpression<HtmlInputSubmit>("class=k-button", "value=Import");
            }
        }

        public HtmlDiv SuccessMessage
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("textContent=~Резултатите бяха импортнати успешно"), 3000, false);
                return this.Find.ByExpression<HtmlDiv>("textContent=~Резултатите бяха импортнати успешно");
            }
        }

        public HtmlDiv IncorectMessage
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("textContent=~Възникна грешка по време на импорта: Input string was not in a correct format."), 3000, false);
                return this.Find.ByExpression<HtmlDiv>("textContent=~Възникна грешка по време на импорта: Input string was not in a correct format.");
            }
        }

        public HtmlDiv RequireColumnMessage
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("textContent=~Възникна грешка по време на импорта: Column UserInCourseId is mandatory"), 3000, false);
                return this.Find.ByExpression<HtmlDiv>("textContent=~Възникна грешка по време на импорта: Column UserInCourseId is mandatory");
            }
        }

        public HtmlDiv NotSelectedFile
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("textContent=~Моля прикачете файл"), 3000, false);
                return this.Find.ByExpression<HtmlDiv>("textContent=~Моля прикачете файл");
            }
        }

        public HtmlDiv DivElement
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("class=k-list-container k-popup k-group k-reset"), 3000, false);
                return Find.ByExpression<HtmlDiv>("class=k-list-container k-popup k-group k-reset");
            }
        }

        public HtmlUnorderedList UlElement
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("class=k-list k-reset"), 30000, false);
                return this.DivElement.Find.ByExpression<HtmlUnorderedList>("class=k-list k-reset");
            }
        }

        public HtmlListItem LiElement(string name)
        {
            return this.UlElement.Find.ByExpression<HtmlListItem>("innerText=" + name);
        }

        public HtmlListItem LiUserInCourseId(string name)
        {
            return this.UlUserInCourseId.Find.ByExpression<HtmlListItem>("innerText=" + name);
        }

        public HtmlListItem LiPassedColumn(string name)
        {
            return this.UlPassedColumn.Find.ByExpression<HtmlListItem>("innerText=" + name);
        }

        public HtmlListItem LiExellentResultColumn(string name)
        {
            return this.UlExellentResultColumn.Find.ByExpression<HtmlListItem>("innerText=" + name);
        }

        public HtmlListItem LiPointsColumn(string name)
        {
            return this.UlPointsColumn.Find.ByExpression<HtmlListItem>("innerText=" + name);
        }

        public HtmlListItem LiCanDoTestExamColumn(string name)
        {
            return this.UlCanDoTestExamColumn.Find.ByExpression<HtmlListItem>("innerText=" + name);
        }

        public HtmlListItem LiPracticalExamColumn(string name)
        {
            return this.UlPracticalExamColumn.Find.ByExpression<HtmlListItem>("innerText=" + name);
        }

        public HtmlListItem LiIsLiveParticipantColumn(string name)
        {
            return this.UlIsLiveParticipantColumn.Find.ByExpression<HtmlListItem>("innerText=" + name);
        }


    }
}
