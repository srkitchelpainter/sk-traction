using System.Web.Mvc;
using LearnSc93Proj.Models.Identity;
using Sitecore;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Resources.Media;

//Presentation Competency: + Use presentation details to add components in the Experience Editor
    // sitecore/layout/Renderings/Project/Identity/Logo
    // Controls Home page Logo media item rendering

namespace LearnSc93Proj.Controllers
{
    public class IdentityController : Controller
    {
        Identity model = new Identity();

        public IdentityController()
        {

        }

        //Media Competency: + Describe how media is stored in Sitecore
        public string GetUrl()
        {
            Database master = Sitecore.Configuration.Factory.GetDatabase("master");
            //Created _Identity Template to store global org values (i.e. logo, contact information...) 
            var logo = master.GetItem("{999D340E-AA72-4390-801A-1769D2A52746}");
            var imageUrl = string.Empty;

            //Fields Competency: + Render field values by using the Sitecore API
            Sitecore.Data.Fields.ImageField imageField = logo.Fields["Logo"];
            if (imageField?.MediaItem != null)
            {
                //Use MediaItem and Media Manager to build media item URL
                var image = new MediaItem(imageField.MediaItem);
                imageUrl = StringUtil.EnsurePrefix('/', MediaManager.GetMediaUrl(image));
                //Add values to MVC model
                model.imageUrl = imageUrl;
                model.mediaAlt = image.Alt;
            }
            return imageUrl;
        }

        // GET: Identity
        public ActionResult Logo()
        {
            GetUrl();
            //Pass Identity model values to Logo.cshtml
            return View(model);
        }


    }
}