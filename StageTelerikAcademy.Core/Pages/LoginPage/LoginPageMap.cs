using ArtOfTest.WebAii.Controls.HtmlControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.LoginPage
{
    public class LoginPageMap : BaseElementMap
    {
        public HtmlInputText Username
        {
            get
            {
                return this.Find.ById<HtmlInputText>("UsernameOrEmail");
            }
        }

        public HtmlInputPassword Password
        {
            get
            {
                return this.Find.ById<HtmlInputPassword>("Password");
            }
        }

        public HtmlInputSubmit Submit
        {
            get
            {
                return this.Find.ByXPath<HtmlInputSubmit>("//*[@id='MainContent']/div/div[2]/form/fieldset/div[3]/input");
            }
        }

        public HtmlAnchor ExitLink
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("ExitMI");
            }
        }
    }
}
