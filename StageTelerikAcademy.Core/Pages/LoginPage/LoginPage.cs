using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core.Data;

namespace StageTelerikAcademy.Core.Pages.LoginPage
{
    public class LoginPage
    {
        public readonly string Url = @"http://stage.telerikacademy.com/Users/Auth/Login";

        public LoginPageMap Map 
        {
            get
            {
                return new LoginPageMap();
            }            
        }

        public LoginPageAsserter Asserter
        {
            get
            {
                return new LoginPageAsserter();
            }
        }

        //Logika za vhoda
        public void LoginUser(User user)
        {
            Manager.Current.ActiveBrowser.NavigateTo(this.Url);
            this.Map.Username.Text = user.Username;
            this.Map.Password.Text = user.Password;
            this.Map.Submit.Click();
            Manager.Current.ActiveBrowser.WaitForElement(30000, "id=ExitMI");
        }
    
    }
}
