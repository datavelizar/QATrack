using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFramework.Core;

namespace StageTelerikAcademy.Core.Pages.EvaluationExportPage
{
    public class EvaluationExportPageMap : BaseElementMap
    {
        public HtmlInputSubmit Submit
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Генерирай excel файл");
            }
        }

        public HtmlControl CourseCheckbox(string courseName)
        {
            var studentsCheckbox = this.Find.AllByExpression<HtmlControl>("name=students_264").First();
            return studentsCheckbox;
        }
    }
}
