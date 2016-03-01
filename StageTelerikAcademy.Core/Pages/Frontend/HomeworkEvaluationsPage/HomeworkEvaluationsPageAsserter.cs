using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Frontend.HomeworkEvaluationsPage
{
    public class HomeworkEvaluationsPageAsserter
    {
        public HomeworkEvaluationsPageMap Map
        {
            get
            {
                return new HomeworkEvaluationsPageMap();
            }
        }


        public void GradeIsMandatory()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.ValidationError.Wait.ForExists();
            Assert.AreEqual(this.Map.ValidationError.InnerText,"Оценката е задължителна!");
            
        }

        public void DescriptionIsMandatory()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.DescriptionError.Wait.ForExists();
            Assert.AreEqual(this.Map.DescriptionError.InnerText,"Коментарът по оценката е задължителен!");
        }

        public void DescriptionIsBelowLimit()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.DescriptionLimitError.Wait.ForExists();
            Assert.AreEqual(this.Map.DescriptionLimitError.InnerText,"Коментарът трябва да бъде поне 20 символа.");
        }

        public void GradeNotInRange()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.ValidationError.Wait.ForExists();
            Assert.AreEqual(this.Map.ValidationError.InnerText,"Оценката трябва да е между 0 и 10");
        }

        public void DescriptionIsMandatoryOverall()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.SummaryError.Wait.ForExists();
            Assert.IsNotNull(this.Map.SummaryErrorDescriptionIsMandatory);
        }

        public void DescriptionIsLessThanMinimumOverall()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.SummaryError.Wait.ForExists();
            Assert.IsNotNull(this.Map.SummaryErrorDescriptionIsLessThanMinimum);
        }

        public void GradeCompleateIsMandatory()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.SummaryError.Wait.ForExists();
            Assert.IsNotNull(this.Map.SummaryErrorCompleteGrade);
        }

        public void GradeCorrectIsMandatory()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.SummaryError.Wait.ForExists();
            Assert.IsNotNull(this.Map.SummaryErrorCorrectGrade);
        }

        public void GradeQualityIsMandatory()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.SummaryError.Wait.ForExists();
            Assert.IsNotNull(this.Map.SummaryErrorQualityGrade);
        }

        public void GradeIsMandatorySummary()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.SummaryError.Wait.ForExists();
            Assert.IsNotNull(this.Map.SummaryValidationError);
        }
    }
}
