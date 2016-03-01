using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Frontend.HomeworkEvaluationsPage
{
    public class HomeworkEvaluationsPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Courses/HomeworkEvaluations/Evaluate/";

        public const int LECTURE_1_SIMPLE_GRADEING_ID = 51;
        public const int LECTURE_2_COMPLETE_CORRECT_QUALITY_GRADING_ID = 52;
        public const int LECTURE_3_YES_NO_EXCELET_GRADEING_ID = 53;
        public const int LECTURE_4_COMPLETE_CORRECT_GRADEING_ID = 54;

        public HomeworkEvaluationsPageMap Map 
        {
            get
            {
                return new HomeworkEvaluationsPageMap();
            }            
        }

        public HomeworkEvaluationsPageAsserter Asserter
        {
            get
            {
                return new HomeworkEvaluationsPageAsserter();
            }
        }

        public void Navigate(int homeworkId)
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url+homeworkId.ToString());
        }

        public void SendScore()
        {
            this.Map.SendScoreButton.Click();
        }

        public void EnterGrade(int score)
        {
            this.Map.ScoreOneToTenField.Value = score.ToString();
        }

        public void EnterNANGrade(string score)
        {
            this.Map.ScoreOneToTenField.Value = score;
        }

        public void EnterDescription(string description)
        {
            this.Map.DescriptionField.Text = description;
        }

        public void SelectCompletnessOption()
        {
            this.Map.CompletnessOption0.Click();
        }

        public void SelectCorectnessOption()
        {
            this.Map.CorrectnessOption0.Click();
        }

        public void SelectQualityOption()
        {
            this.Map.QualityOption0.Click();
        }
    }
}
