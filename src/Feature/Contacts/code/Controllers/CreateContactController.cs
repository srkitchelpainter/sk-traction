using System.Web.Mvc;
using LearnSc93Proj.Pipelines.logWriter;
using Sitecore.Pipelines;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Feature.Contacts.Models;
using Sitecore.SecurityModel;
//using Sitecore.Feature.Contacts.Tests;
using Sitecore.Data;

namespace Sitecore.Feature.Contacts.Controllers
{
    public class CreateContactController : Controller
    {
        public void Contact(CreateContactModel model)
        {
            try
            {
                using (new SecurityDisabler())
                {
                    Data.Database master = Configuration.Factory.GetDatabase("master");
                    //Bucket item
                    Item parent = master.Items["/sitecore/content/Contacts/ContactsIndex/Contacts Bucket/2020/06/24/17/21"];
                    //Template - bucketable item
                    TemplateItem contact = master.GetTemplate(new Data.ID("{DE54B9DE-CFE6-4A51-8C7B-4F7F49DE8760}"));
                    Item item = parent.Add("Item", contact);

                    item.Editing.BeginEdit();
                    item.Name = model.FirstName + model.LastName;
                    item["FirstName"] = model.FirstName;
                    item["LastName"] = model.LastName;
                    item.Editing.EndEdit();
                }
                logContact();
            }
            catch
            {
                var msg = "Contact item was not created.";
                Log.Error(msg, this);
            }
        }

        private void logContact()
        {
            var pipelineargs = new LogWriterPipelineArgs();
            pipelineargs.LogMessage = "Contact created.";
            CorePipeline.Run("logWriter", pipelineargs);
        }

        //To-Do: Implement custom route configuration for dependency injection 
        //private IBasicContentExtractor _contentExtractor;

        //public CreateContactController(IBasicContentExtractor contentExtractor)
        //{
        //    _contentExtractor = contentExtractor;
        //}

        // GET: CreateContact
        public ActionResult CreateContact()
        {
            Database master = Configuration.Factory.GetDatabase("master");
            var index = master.GetItem("{16A9619B-2D48-4906-A40E-04D2B8D89A62}");

            var intro = index["Intro"];

            if (string.IsNullOrEmpty(intro))
            {
                intro = "The Intro field is empty.";
            }

            var model = new CreateContactModel
            {
                Intro = intro
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult CreateContact(CreateContactModel model)
        {
            Contact(model);

            if (ModelState.IsValid)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                sb.Append("Great job! Contact created.");
                return Content(sb.ToString());
            }
            else
            {
                return View(model);
            }
        }
    }
}
