using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Frontend.ExamRegisteringPage
{
    public class ExamRegisteringPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Courses/PracticalExams/Select/265";

        public ExamRegisteringPageMap Map 
        {
            get
            {
                return new ExamRegisteringPageMap();
            }            
        }

        public ExamRegisteringPageAsserter Asserter
        {
            get
            {
                return new ExamRegisteringPageAsserter();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }
    }
}
