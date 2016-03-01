using ArtOfTest.WebAii.Controls.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.Frontend.HomeworkEvaluationsPage
{
    public class HomeworkEvaluationsPageMap: BaseElementMap
    {
        public HtmlInputSubmit SendScoreButton
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Изпратете оценката");
            }
        }
       
        public HtmlInputText ScoreOneToTenField
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Valuation");
            }
        }

        public HtmlTextArea DescriptionField
        {
            get
            {
                return this.Find.ById<HtmlTextArea>("Description");
            }
        }

        public HtmlSpan ValidationError
        {
            get
            {
                return this.Find.ById<HtmlSpan>("Valuation-error");
            }
        }

        public HtmlSpan DescriptionError
        {
            get
            {
                return this.Find.ById<HtmlSpan>("Description-error");
            }
        }

        public HtmlSpan DescriptionLimitError
        {
            get
            {
                return this.Find.ByAttributes<HtmlSpan>("data-valmsg-for=Description");
            }
        }

        public HtmlDiv SummaryError
        { 
            get
            {
                return this.Find.ByAttributes<HtmlDiv>("class=validation-summary-errors");
            }
        }

        public HtmlListItem SummaryErrorDescriptionIsMandatory
        { 
            get
            {
                return this.SummaryError.Find.ByContent<HtmlListItem>("Коментарът по оценката е задължителен!");
            }
        }

        public HtmlListItem SummaryErrorDescriptionIsLessThanMinimum
        { 
            get
            {
                return this.SummaryError.Find.ByContent<HtmlListItem>("Коментарът трябва да бъде поне 200 символа.");
            }
        }

        public HtmlListItem SummaryErrorCompleteGrade
        { 
            get
            {
                return this.SummaryError.Find.ByContent<HtmlListItem>("Оценката за пълнота на домашното е задължителна!");
            }
        }

        public HtmlListItem SummaryErrorCorrectGrade
        { 
            get
            {
                return this.SummaryError.Find.ByContent<HtmlListItem>("Оценката за коректност на домашното е задължителна!");
            }
        }

        public HtmlListItem SummaryErrorQualityGrade
        {
            get
            {
                return this.SummaryError.Find.ByContent<HtmlListItem>("Оценката за качество на домашното е задължителна!");
            }
        }

        public HtmlInputRadioButton CompletnessOption0
        {
            get
            {
                return this.Find.ById<HtmlInputRadioButton>("Completeness0");
            }
        }

        public HtmlInputRadioButton CorrectnessOption0
        {
            get
            {
                return this.Find.ById<HtmlInputRadioButton>("Correctness0");
            }
        }

        public HtmlInputRadioButton QualityOption0
        {
            get
            {
                return this.Find.ById<HtmlInputRadioButton>("Quality0");
            }
        }

        public HtmlListItem SummaryValidationError
        {
            get
            {
                return this.SummaryError.Find.ByContent<HtmlListItem>("Оценката е задължителна!");
            }
        }
    }
}
