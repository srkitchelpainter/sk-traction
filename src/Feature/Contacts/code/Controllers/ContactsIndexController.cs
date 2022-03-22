using Sitecore.Feature.Contacts.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;
using Glass.Mapper.Sc;

namespace Sitecore.Feature.Contacts.Controllers
{
    public class ContactsIndexController : Controller
    {
        public ActionResult ContactsIndex()
        {
            var context = new MvcContext();
            ISitecoreService service = new SitecoreService(context.SitecoreService.Database);
            ContactsIndex model = service.GetItem<ContactsIndex>("/sitecore/content/Contacts/ContactsIndex");
            return View(model);
        }
    }
}