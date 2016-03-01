using ArtOfTest.WebAii.Core;

namespace StageTelerikAcademy.Core.Pages.Frontend.UploadReuploadHomeworkPage
{
    public class UploadReuploadHomeworkPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Courses/Courses/Details/263";

        public UploadReuploadHomeworkPageMap Map 
        {
            get
            {
                return new UploadReuploadHomeworkPageMap();
            }            
        }

        public UploadReuploadHomeworkPageAsserter Asserter
        {
            get
            {
                return new UploadReuploadHomeworkPageAsserter();
            }
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
        }
    }
}
