using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageTelerikAcademy.Core.Pages.Frontend.TeamworkPage
{
    public class TeamworkPageAsserter
    {
        public TeamworkPageMap TeamworkPageMap 
        {
            get
            {
                return new TeamworkPageMap();
            }
        }

        public void ValidatePage(string pageTitle, string url)
        {
            Assert.AreEqual(pageTitle, Manager.Current.ActiveBrowser.PageTitle);
            Assert.AreEqual(url, Manager.Current.ActiveBrowser.Url);
        }

        public void TeamMateValidate(string name)
        {
            Assert.AreEqual(name, TeamworkPageMap.TeamMateName.InnerText);
        }
    }
}
