using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Feature.Articles.Models;

namespace Sitecore.Feature.Articles.Controllers
{
    public class ArticleController : Controller
    {
        public ActionResult Article()
        {
            //Fields Competency: Make all fields editable in the Experience Editor.
            //Fields Competency: Retrieve field values from Sitecore and make them editable in the Experience Editor
            //Fields Competency: Use different field types and define which fields can be edited in Experience Editor via Sitecore controls
            //Fields Competency: Use the Field Editor buttons
            var context = new MvcContext();
            ArticlePage model = context.GetRenderingItem<ArticlePage>();
            return View(model);
        }
    }
}