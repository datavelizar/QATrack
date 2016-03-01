using Microsoft.VisualStudio.TestTools.UnitTesting;
using StageTelerikAcademy.Core.Facades;
using TestingFramework.Core;
using TestingFramework.Core.Constants;
using TestingFramework.Core.Data;
using TestingFramework.Utilities.Atributes;

namespace StageTelerikAcademy.Test.Frontend
{
    [TestClass]
    public class Teamwork:BaseTest
    {
        private TeamworksFacade TeamworksFacade;

        public override void TestInit()
        {
            this.TeamworksFacade = new TeamworksFacade();
            TeamworksFacade.user = new User()
            {
                Username = "TeamArcher",
                Password = "teamarcher"
            };
        }
                
    }
}
