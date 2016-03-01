using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.Admin.Teamwork.TeamMemberEvaluationsPage
{
    public class TeamMemberEvaluationsPageMap:BaseElementMap
    {

        public HtmlAnchor UploadButton
        {
            get
            {
                Manager.Current.ActiveBrowser.WaitForElement(new HtmlFindExpression("class=k-button k-button-icontext k-grid-custom-toolbar-button", "textContent=Добавяне на оценки от Excel"), 5000, false);
                return this.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button", "textContent=Добавяне на оценки от Excel");
            }
        }

        public HtmlAnchor BackToAdminButton
        {
            get
            {
                return this.Find.ByExpression<HtmlAnchor>("href=/Administration/Navigation", "class=k-button k-button-icontext k-grid-custom-toolbar-button");
            }
        }
    }
}
