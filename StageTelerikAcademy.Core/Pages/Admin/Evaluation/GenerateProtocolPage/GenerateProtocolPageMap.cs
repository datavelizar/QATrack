using ArtOfTest.WebAii.Controls;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.EvaluationGenerateProtocolPage
{
    public class GenerateProtocolPageMap:BaseElementMap
    {

        public HtmlControl CourseInstance
        {
            get
            {
                return this.Find.ByExpression<HtmlControl>("aria-controls=CourseInstanceId_listbox");
            } 
        }

        public HtmlControl ForumCategory
        {
            get
            {
                return this.Find.ByExpression<HtmlControl>("aria-controls=ForumCategoryId_listbox");
            } 
        }

         public HtmlInputSubmit SubmitButton
        {
            get
            {
                return this.Find.ByXPath<HtmlInputSubmit>("//*[@id='MainContent']/div/form/input");
            } 
        }


         public HtmlControl CourseInstanceLabel
         {
             get
             {
                 return this.Find.ByXPath<HtmlControl>("//*[@id='MainContent']/div/form/div[1]/strong");
             }
         }

         public HtmlControl ForumCategoryLabel
         {
             get
             {
                 return this.Find.ByXPath<HtmlControl>("//*[@id='MainContent']/div/form/div[2]/strong");
             }
         }

         public HtmlControl FirstSelection
         {
             get
             {
                 return this.Find.ByExpression<HtmlControl>("data-offset-index=0");

             }
         }

         public HtmlControl SecondSelection
         {
             get
             {
                 return this.Find.ByExpression<HtmlControl>("data-offset-index=6", "textContent=Зайци");

             }
         }
         public HtmlAnchor GenerateProtocolLink
         {
             get
             {
                 return this.Find.ByExpression<HtmlAnchor>("class=admin-navigation-link", "href=/Administration_Courses/Evaluation");
             }
         }

         public HtmlControl GenerateProtocolPageLabel
         {
             get
             {
                 return this.Find.ByXPath<HtmlControl>(".//*[@id='MainContent']/div/h1");
             }
         }
         public string CurentUrl
         {
             get
             {
                 return Manager.Current.ActiveBrowser.Url;
             }
         }

         public string CurentPageTitle
         {
             get
             {
                 return Manager.Current.ActiveBrowser.PageTitle;
             }
         }
    }
}
