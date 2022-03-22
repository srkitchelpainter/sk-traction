using System.Web.Mvc;
using Sitecore.Feature.Articles.Models;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;

namespace Sitecore.Feature.Articles.Controllers
{
    public class ArticleFeedController : Controller
    {
        ArticleExample model = new ArticleExample();
        // GET: Home/ArticleFeed/Articles child items
        public ActionResult ArticleFeed()
        {
            //API Competency: Retrieve a item's child items and TO-DO: apply custom sorting
            var mvcContext = new MvcContext();
            ISitecoreService service = new SitecoreService(mvcContext.SitecoreService.Database);
            ArticleExample.ArticleItem articleItem = service.GetItem<ArticleExample.ArticleItem>("/sitecore/content/Home/ArticleFeed/Articles");
            model.ArticleList = articleItem.Children;
            return View(model);
        }
    }
}