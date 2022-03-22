using Sitecore.Feature.Contacts.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Sitecore.Feature.Contacts.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Contact()
        {
            var context = new MvcContext();

            var model = context.GetContextItem<ContactsIndex>();

            return View(model);
        }
    }
}