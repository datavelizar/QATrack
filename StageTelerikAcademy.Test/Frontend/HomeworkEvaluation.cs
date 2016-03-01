using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFramework.Utilities.Atributes;
using TestingFramework.Core.Constants;
using TestingFramework.Core.Data;
using StageTelerikAcademy.Core.Pages.LoginPage;
using StageTelerikAcademy.Core.Pages.Frontend.HomeworkEvaluationsPage;
using TestingFramework.Core;
using StageTelerikAcademy.Core.Facades;

namespace StageTelerikAcademy.Test.Frontend
{
    [TestClass]
    public class HomeworkEvaluation : BaseTest
    {
        public HomeworkEvaluationFacade service { get; set; }

        public override void TestInit()
        {
            var currentUser = new User()
            {
                Username = "TeamArcher",
                Password = "teamarcher"
            };
            this.service = new HomeworkEvaluationFacade(currentUser);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.Medium)]
        [TestCaseId(191)]
        public void TestOneToTenGradeWithAllEmptyFields()
        {
            this.service.AllEmptyFields(HomeworkEvaluationTemplate.Simple1To10);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.Medium)]
        [TestCaseId(192)]
        public void TestOneToTenGradeWithEmptyGradeField()
        {
            this.service.EmptyGradeField(HomeworkEvaluationTemplate.Simple1To10);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.Medium)]
        [TestCaseId(193)]
        public void TestOneToTenGradeWithEmptyDescriptionField()
        {
            this.service.EmptyDescriptionField(HomeworkEvaluationTemplate.Simple1To10);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.Medium)]
        [TestCaseId(194)]
        public void TestOneToTenGradeWithCommentDescription20Symbols()
        {
            this.service.DescriptionBelowMinimumSymbols(HomeworkEvaluationTemplate.Simple1To10);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.Medium)]
        [TestCaseId(195)]
        public void TestOneToTenGradeWithGradeBelowZero()
        {
            this.service.GradeBelowMinimum(HomeworkEvaluationTemplate.Simple1To10);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.Medium)]
        [TestCaseId(196)]
        public void TestOneToTenGradeWithGradeAboveTen()
        {
            this.service.GradeAboveMaximum(HomeworkEvaluationTemplate.Simple1To10);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.Medium)]
        [TestCaseId(197)]
        public void TestOneToTenGradeWithGradeNotANumber()
        {
            this.service.GradeNotANumber(HomeworkEvaluationTemplate.Simple1To10);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.High)]
        [TestCaseId(198)]
        public void TestCompleteCorrectQualityGradeWithAllEmptyFields()
        {
            this.service.AllEmptyFields(HomeworkEvaluationTemplate.CompleteCorrectQuality);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.High)]
        [TestCaseId(199)]
        public void TestCompleteCorrectQualityGradeWithDescriptionEmpty()
        {
            this.service.EmptyDescriptionField(HomeworkEvaluationTemplate.CompleteCorrectQuality);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.High)]
        [TestCaseId(200)]
        public void TestCompleteCorrectQualityGradeWithDescriptionBelowMinimum()
        {
            this.service.DescriptionBelowMinimumSymbols(HomeworkEvaluationTemplate.CompleteCorrectQuality);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.High)]
        [TestCaseId(201)]
        public void TestCompleteCorrectQualityGradeWithCompleteEmpty()
        {
            this.service.EmptyCompleateField(HomeworkEvaluationTemplate.CompleteCorrectQuality);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.High)]
        [TestCaseId(202)]
        public void TestCompleteCorrectQualityGradeWithCorrectEmpty()
        {
            this.service.EmptyCorrectField(HomeworkEvaluationTemplate.CompleteCorrectQuality);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.High)]
        [TestCaseId(203)]
        public void TestCompleteCorrectQualityGradeWithQualityEmpty()
        {
            this.service.EmptyQualityField(HomeworkEvaluationTemplate.CompleteCorrectQuality);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.Medium)]
        [TestCaseId(204)]
        public void TestYesNoExcelentGradeWithAllEmptyFields()
        {
            this.service.AllEmptyFields(HomeworkEvaluationTemplate.YesNoExcelent);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.Medium)]
        [TestCaseId(205)]
        public void TestYesNoGradeWithEmptyGrade()
        {
            this.service.EmptyGradeField(HomeworkEvaluationTemplate.YesNoExcelent);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.Medium)]
        [TestCaseId(207)]
        public void TestCompleteCorrectGradeWithAllEmptyFields()
        {
            this.service.AllEmptyFields(HomeworkEvaluationTemplate.CompleteCorrect);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.Medium)]
        [TestCaseId(208)]
        public void TestCompleteCorrectGradeWithDescriptionEmpty()
        {
            this.service.EmptyDescriptionField(HomeworkEvaluationTemplate.CompleteCorrect);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.Medium)]
        [TestCaseId(209)]
        public void TestCompleteCorrectGradeWithDescriptionBelowMinimum()
        {
            this.service.DescriptionBelowMinimumSymbols(HomeworkEvaluationTemplate.CompleteCorrect);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.Medium)]
        [TestCaseId(210)]
        public void TestCompleteCorrectGradeWithCompleteEmpty()
        {
            this.service.EmptyCompleateField(HomeworkEvaluationTemplate.CompleteCorrect);
        }

        [TestMethod]
        [Owner(Author.Ivan)]
        [Priority(Priority.Medium)]
        [TestCaseId(211)]
        public void TestCompleteCorrectGradeWithCorrectEmpty()
        {
            this.service.EmptyCorrectField(HomeworkEvaluationTemplate.CompleteCorrect);
        }
    }
}
