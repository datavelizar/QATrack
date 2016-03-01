using StageTelerikAcademy.Core.Pages.Frontend.HomeworkEvaluationsPage;
using StageTelerikAcademy.Core.Pages.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core.Data;

namespace StageTelerikAcademy.Core.Facades
{
    public enum HomeworkEvaluationTemplate
    {
        Simple1To10,
        CompleteCorrectQuality,
        YesNoExcelent,
        CompleteCorrect
    }

    public class HomeworkEvaluationFacade
    {
        public User CurrentUser { get; set; }
        public LoginPage LoginPage { get; set; }
        public HomeworkEvaluationsPage HomeworkEvaluationsPage { get; set; }

        private const int MEDIUM_GRADE = 5;
        private const int BELOW_MINIMUM_GRADE = -1;
        private const int ABOVE_MAXIMUM_GRADE = 12;
        private const string NOT_A_NUMBER_GRADE = "test";
        private const string BELOW_MINIMUM_DESCRIPTION_SHORT = "description";
        private const string VALID_DESCRIPTION_SHORT = "This description is valid as it is above 20 symbols.";
        private const string BELOW_MINIMUM_DESCRIPTION_LONG = "This is invalid long description as it is below 200 symbols.";
        private const string VALID_DESCRIPTION_LONG = "This is a valid long description with more than 200 symbols. This is a valid long description with more than 200 symbols. This is a valid long description with more than 200 symbols. This is a valid long description with more than 200 symbols. This is a valid long description with more than 200 symbols.";

        public HomeworkEvaluationFacade(User user)
        {
            this.CurrentUser = user;
            this.LoginPage = new LoginPage();
            this.HomeworkEvaluationsPage = new HomeworkEvaluationsPage();
        }

        private void GoToPage(HomeworkEvaluationTemplate templateType)
        {
            this.LoginPage.LoginUser(CurrentUser);
            var templateTypeMap = new Dictionary<HomeworkEvaluationTemplate, int>()
            {
                {HomeworkEvaluationTemplate.Simple1To10, HomeworkEvaluationsPage.LECTURE_1_SIMPLE_GRADEING_ID},
                {HomeworkEvaluationTemplate.CompleteCorrectQuality, HomeworkEvaluationsPage.LECTURE_2_COMPLETE_CORRECT_QUALITY_GRADING_ID},
                {HomeworkEvaluationTemplate.YesNoExcelent, HomeworkEvaluationsPage.LECTURE_3_YES_NO_EXCELET_GRADEING_ID},
                {HomeworkEvaluationTemplate.CompleteCorrect, HomeworkEvaluationsPage.LECTURE_4_COMPLETE_CORRECT_GRADEING_ID},
            };
            this.HomeworkEvaluationsPage.Navigate(templateTypeMap[templateType]);
        }


        public void AllEmptyFields(HomeworkEvaluationTemplate templateType)
        {
            GoToPage(templateType);
            this.HomeworkEvaluationsPage.SendScore();
            if (templateType == HomeworkEvaluationTemplate.Simple1To10)
            {
                this.HomeworkEvaluationsPage.Asserter.GradeIsMandatory();
                this.HomeworkEvaluationsPage.Asserter.DescriptionIsMandatory();
            }
            else if (templateType == HomeworkEvaluationTemplate.CompleteCorrectQuality)
            {
                this.HomeworkEvaluationsPage.Asserter.DescriptionIsMandatoryOverall();
            }
            else if (templateType == HomeworkEvaluationTemplate.YesNoExcelent)
            {
                this.HomeworkEvaluationsPage.Asserter.GradeIsMandatorySummary();
            }
            else if(templateType == HomeworkEvaluationTemplate.CompleteCorrect)
            {
                this.HomeworkEvaluationsPage.Asserter.DescriptionIsMandatoryOverall();
            }
        }

        public void EmptyGradeField(HomeworkEvaluationTemplate templateType)
        {
            GoToPage(templateType);
            this.HomeworkEvaluationsPage.EnterDescription(VALID_DESCRIPTION_SHORT);
            this.HomeworkEvaluationsPage.SendScore();
            if(templateType == HomeworkEvaluationTemplate.YesNoExcelent)
                this.HomeworkEvaluationsPage.Asserter.GradeIsMandatorySummary();
            else
                this.HomeworkEvaluationsPage.Asserter.GradeIsMandatory();
        }

        public void EmptyDescriptionField(HomeworkEvaluationTemplate templateType)
        {
            GoToPage(templateType);
            this.HomeworkEvaluationsPage.EnterGrade(MEDIUM_GRADE);
            this.HomeworkEvaluationsPage.SendScore();
            this.HomeworkEvaluationsPage.Asserter.DescriptionIsMandatory();
        }

        public void DescriptionBelowMinimumSymbols(HomeworkEvaluationTemplate templateType)
        {
            GoToPage(templateType);
            if (templateType == HomeworkEvaluationTemplate.Simple1To10)
            {
                this.HomeworkEvaluationsPage.EnterGrade(MEDIUM_GRADE);
                this.HomeworkEvaluationsPage.EnterDescription(BELOW_MINIMUM_DESCRIPTION_SHORT);
                this.HomeworkEvaluationsPage.SendScore();
                this.HomeworkEvaluationsPage.Asserter.DescriptionIsBelowLimit();
            }
            else if (templateType == HomeworkEvaluationTemplate.CompleteCorrectQuality)
            {
                this.HomeworkEvaluationsPage.SelectCompletnessOption();
                this.HomeworkEvaluationsPage.SelectQualityOption();
                this.HomeworkEvaluationsPage.SelectCorectnessOption();
                this.HomeworkEvaluationsPage.EnterDescription(BELOW_MINIMUM_DESCRIPTION_LONG);
                this.HomeworkEvaluationsPage.SendScore();
                this.HomeworkEvaluationsPage.Asserter.DescriptionIsLessThanMinimumOverall();
            }
            else if(templateType == HomeworkEvaluationTemplate.CompleteCorrect)
            {
                this.HomeworkEvaluationsPage.SelectCompletnessOption();
                this.HomeworkEvaluationsPage.SelectCorectnessOption();
                this.HomeworkEvaluationsPage.EnterDescription(BELOW_MINIMUM_DESCRIPTION_LONG);
                this.HomeworkEvaluationsPage.SendScore();
                this.HomeworkEvaluationsPage.Asserter.DescriptionIsLessThanMinimumOverall();
            }
        }

        public void GradeBelowMinimum(HomeworkEvaluationTemplate templateType)
        {
            GoToPage(templateType);
            this.HomeworkEvaluationsPage.EnterGrade(BELOW_MINIMUM_GRADE);
            this.HomeworkEvaluationsPage.SendScore();
            this.HomeworkEvaluationsPage.Asserter.GradeNotInRange();
        }

        public void GradeAboveMaximum(HomeworkEvaluationTemplate templateType)
        {
            GoToPage(templateType);
            this.HomeworkEvaluationsPage.EnterGrade(ABOVE_MAXIMUM_GRADE);
            this.HomeworkEvaluationsPage.SendScore();
            this.HomeworkEvaluationsPage.Asserter.GradeNotInRange();
        }

        
        public void GradeNotANumber(HomeworkEvaluationTemplate templateType)
        {
            GoToPage(templateType);
            this.HomeworkEvaluationsPage.EnterNANGrade(NOT_A_NUMBER_GRADE);
            this.HomeworkEvaluationsPage.SendScore();
            this.HomeworkEvaluationsPage.Asserter.GradeNotInRange();
        }

        public void EmptyCompleateField(HomeworkEvaluationTemplate templateType)
        {
            GoToPage(templateType);
            this.HomeworkEvaluationsPage.EnterDescription(VALID_DESCRIPTION_LONG);
            if (templateType == HomeworkEvaluationTemplate.CompleteCorrectQuality)
            {
                this.HomeworkEvaluationsPage.SelectQualityOption();
            }
            this.HomeworkEvaluationsPage.SelectCorectnessOption();
            this.HomeworkEvaluationsPage.SendScore();
            this.HomeworkEvaluationsPage.Asserter.GradeCompleateIsMandatory();
        }

        public void EmptyCorrectField(HomeworkEvaluationTemplate templateType)
        {
            GoToPage(templateType);
            this.HomeworkEvaluationsPage.EnterDescription(VALID_DESCRIPTION_LONG);
            if (templateType == HomeworkEvaluationTemplate.CompleteCorrectQuality)
            {
                this.HomeworkEvaluationsPage.SelectQualityOption();
            }
            this.HomeworkEvaluationsPage.SelectCompletnessOption();
            this.HomeworkEvaluationsPage.SendScore();
            this.HomeworkEvaluationsPage.Asserter.GradeCorrectIsMandatory();
        }

        public void EmptyQualityField(HomeworkEvaluationTemplate templateType)
        {
            GoToPage(templateType);
            this.HomeworkEvaluationsPage.EnterDescription(VALID_DESCRIPTION_LONG);
            if (templateType == HomeworkEvaluationTemplate.CompleteCorrectQuality)
            {
                this.HomeworkEvaluationsPage.SelectCorectnessOption();
                this.HomeworkEvaluationsPage.SelectCompletnessOption();
            }
            this.HomeworkEvaluationsPage.SendScore();
            this.HomeworkEvaluationsPage.Asserter.GradeQualityIsMandatory();
        }
    }
}
