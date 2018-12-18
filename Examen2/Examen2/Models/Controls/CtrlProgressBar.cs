using WebApp.Models.Controls;

namespace Examen2.Models.Controls
{
    public class CtrlProgressBar : CtrlBaseModel
    {
        
        public string Color { get; set; }
        public string Progress { get; set; }


        public string ProgressBar
        {
            get
            {
                var htmlOptions = "";
                
                htmlOptions += $"<div class=\"progress-bar progress-bar-striped active\" role=\"progressbar\" style=\"width: {Progress}; background-color: {Color};\" aria-valuenow=\"25\" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>";
                    

                return htmlOptions;
            }
        }
    }
}