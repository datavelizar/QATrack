using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.Teamwork.ImportOfTeamNamesPage
{
    public class ImportOfTeamNamesPageMap : BaseElementMap
    {
        public HtmlControl ChooseNameTypes
        {
            get
            {
                return this.Find.ByContent<HtmlControl>("Изберете тип на имената на отборите");
            }
        }

        public HtmlControl TypeOne
        {
            get
            {
                return this.Find.ByContent<HtmlControl>("Тип 1");
            }
        }

        public HtmlControl ColumnToChooseNamesFrom
        {
            get
            {
                return this.Find.ByContent<HtmlControl>("Изберете колона с имената на отборите");
            }
        }

        public HtmlControl ColumnA
        {
            get
            {
                return this.Find.ByContent<HtmlControl>("A");
            }
        }

        public HtmlInputControl FileUploadLink
        {
            get
            {
                return this.Find.ById<HtmlInputControl>("TeamNameSuggestionsFile");
            }
        }
        
        public HtmlInputControl RegisterStudentsButton
        {
            get
            {
                return this.Find.ById<HtmlInputControl>("submit-team-names-import");
            }
        }
    }
}
