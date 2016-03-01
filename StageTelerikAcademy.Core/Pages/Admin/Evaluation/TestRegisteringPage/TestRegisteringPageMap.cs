using ArtOfTest.WebAii.Controls.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.TestRegisteringPage
{
    public class TestRegisteringPageMap : BaseElementMap
    {
        
        public HtmlControl ChooseTest
        {
            get
            {
                return this.Find.ByContent<HtmlControl>("Изберете тестови изпит");
            }
        }

        public HtmlControl TestExam
        {
            get
            {
                return this.Find.ByContent<HtmlControl>("Тестови курс 2 (18/2/2016 16:38)");
            }
        }

        public HtmlControl RegisteringCriteria
        {
            get
            {
                return this.Find.ByContent<HtmlControl>("Изберете критерий за записване");

            }
        }

        public HtmlControl IdAsCriteria
        {
            get
            {
                return this.Find.ByContent<HtmlControl>("Потребителско ID");
            }
        }

        public HtmlControl ColumnToChoose
        {
            get
            {
                return this.Find.ByContent<HtmlControl>("Изберете колона със стойности");
            }
        }

        public HtmlControl ColumnA
        {
            get
            {
                return this.Find.ByContent<HtmlControl>("A");
            }
        }

        //public HtmlControl ColumnA
        //{
        //    get
        //    {
        //        return this.Find.AllByExpression("class=~k-item").FirstOrDefault().As<HtmlControl>();
        //    }
        //}

        public HtmlControl SelectFileButton
        {
            get
            {
                return this.Find.ById<HtmlControl>("ExamStudentsFile");
            }
        }

        public HtmlControl RegisterStudentsButton
        {
            get
            {
                return this.Find.ByExpression<HtmlControl>("value=Запиши студентите");
            }
       }
    }
}
