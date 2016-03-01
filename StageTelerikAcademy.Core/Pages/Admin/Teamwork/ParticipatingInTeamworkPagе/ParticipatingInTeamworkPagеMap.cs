using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.Admin.Evaluation.ParticipatingInTeamworkPagе
{
    public class ParticipatingInTeamworkPagеMap:BaseElementMap
    {

       

        public HtmlAnchor ExportButton
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=export"),5000,false);
                return this.Find.ById<HtmlAnchor>("export");
            }
        }

        public HtmlAnchor BackToAdminButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("href=/Administration/Navigation", "class=k-button k-button-icontext k-grid-custom-toolbar-button");
            }
        }

        public HtmlAnchor AddStudentProposalButton
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("class=k-button k-button-icontext k-grid-add", "href =/Administration_Teamwork/TeamMemberSuggestions/TeamMemberSuggestions_Read?DataGrid-mode=insert"), 10000, false);
                return this.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-add", "href =/Administration_Teamwork/TeamMemberSuggestions/TeamMemberSuggestions_Read?DataGrid-mode=insert");
            }
        }

        public HtmlControl ValidationMessageTeamworkField
        {
            get
            {
                return this.Find.ById<HtmlControl>("TeamworkId_validationMessage"); //Изберете отборна работа
            }
        }

        public HtmlControl ValidationMessageUsernameField
        {
            get
            {
                return this.Find.ById<HtmlControl>("Username_validationMessage"); //Въведете валидно потребителско име!
                //Въведете потребителско име
            }
        }

            public HtmlSpan TeamworkDropdown
            {
                get
                {
                    Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("id=DataGrid"), 5000, false);
                    return this.Find.ByExpression<HtmlSpan>("calss=k-input","textContent=Изберете отборна работа");
                }
            }

       public HtmlListItem SelectTeamworkItem
       {
           get
           {
               Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("class=k-item k-state-selected k-state-focused k-state-hover", "textContent=Бази данни - Team ArcherTeamwork"),3000,false);
               return this.Find.ByExpression<HtmlListItem>("class=k-item k-state-selected k-state-focused k-state-hover","textContent=Бази данни - Team ArcherTeamwork");
           }
       }

        public HtmlInputText UserNameField
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Username");
            }
        }

        public HtmlInputButton UpdateButton
        {
            get
            {
                return this.Find.ByExpression<HtmlInputButton>("class=k-button k-button-icontext k-primary k-grid-update", "textContent=Update");
            }
        }
    }
}
