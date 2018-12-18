using System.Web;
using System.Web.Mvc;
using Examen2.Models.Controls;

namespace Examen2.Models.Helpers
{
    public static class ControlExtensions
    {
        public static HtmlString CtrlProgressBar(this HtmlHelper html, string color, string progress)
        {
            var ctrl = new CtrlProgressBar
            {
                
                Color = color,
                Progress = progress,
            };

            return new HtmlString(ctrl.GetHtml());
        }
    }
}