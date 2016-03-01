using ArtOfTest.WebAii.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Pages.Admin.MainAdminPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Admin.Teamwork.TeamworksPage
{
    public class TeamworksPageAsserter
    {
        public TeamworksPageMap Map
        {
            get
            {
                return new TeamworksPageMap();
            }
        }

        public AdminNavigationPageMap Mapper
        {
            get
            {
                return new AdminNavigationPageMap();
            }
        }

        public void VerifyAdminNavigation()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            string adminHrf = "/Administration/Navigation";
            Assert.AreEqual(adminHrf, this.Mapper.AdminMenuInAdminNavPage.HRef);

        }

        public void VerifyUpdatePopUp()
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            Assert.AreEqual("Update", this.Map.UpdateButtonOnPopUp.InnerText);
            Assert.AreEqual("Cancel", this.Map.CancleButtonOnPopUp.InnerText);
        }

        public void VerifyBeforeDeleteing()
        {
            var one = this.Map.CountOfRowsInGridLabelBeforeDeleting;
            this.Map.RefreshButton.Click();
            var two = this.Map.CountOfRowsInGridLabelAfterDeleting;
            Assert.AreNotEqual(one, two);
        }

    }
}
