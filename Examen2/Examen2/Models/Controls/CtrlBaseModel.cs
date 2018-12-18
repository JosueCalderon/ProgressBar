using System.IO;
using System.Web;

namespace WebApp.Models.Controls
{
    public class CtrlBaseModel
    {
        public string Id { get; set; }

        private string ReadFileText()
        {
            var path = HttpContext.Current.Server.MapPath("/Models/Controls/");
            var fileName = GetType().Name + ".html";
            path = path + fileName;

            var text = File.ReadAllText(path);

            return text;
        }

        public string GetHtml()
        {
            var html = ReadFileText();

            foreach (var prop in GetType().GetProperties())
                if (prop != null)
                {
                    var value = prop.GetValue(this, null)?.ToString();

                    var tag = string.Format("-#{0}-", prop.Name);
                    html = html.Replace(tag, value);
                }

            return html;
        }
    }
}