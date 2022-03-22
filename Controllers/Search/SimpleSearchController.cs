using System.Linq;
using System.Web.Mvc;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using LearnSc93Proj.Models.Search;

namespace LearnSc93Proj.Controllers
{
    public class SimpleSearchController : Controller
    {
        // GET: SimpleSearch
        public ActionResult Index()
        {
            var searchList = new SimpleSearch();

            var Index = ContentSearchManager.GetIndex("sitecore_master_index");

            using (var context = Index.CreateSearchContext())
            {
                var searchResults = context.GetQueryable<SearchResultItem>()
                    .Where(s => s.Content.Contains("Articles"))
                    .Select(item => item.GetItem()).ToList();

                searchList.ListOfItems = searchResults;
            }
            return View(searchList);
        }
    }
}