using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.TestTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingFramework.Core
{
    public class BaseElementMap : HtmlElementContainer
    {
        public BaseElementMap()
            : base(Manager.Current.ActiveBrowser.Find)
        {
            //Vsichki klasove koito nasledqvat BaseElementMap shte imat FindExpression koito e na tekushtiqt browser
        }
    }
}
