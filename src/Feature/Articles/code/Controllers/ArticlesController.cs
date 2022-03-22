using System.Web.Mvc;
using Sitecore.Feature.Articles.Models;
using Newtonsoft.Json;
using System.IO;
using Sitecore.Data.Items;
using System.Linq;
using System;

//imports a file representing content schema
namespace Sitecore.Feature.Articles.Controllers
{
    public class ArticlesController : Controller
    {
        public ArticlesController()
        {
            
        }
        private void CreateTemplates()
        {
            //Read ContentModel.Json
            using (StreamReader r = new StreamReader("C:/inetpub/wwwroot/sc93sc.dev.local/App_Data/ContentModel.json"))
            {
                string Json = r.ReadToEnd();

                //Deserialize ContentModel.json
                Rootobject schemaRoot = JsonConvert.DeserializeObject<Rootobject>(Json);

                //Fields competency: Render field values by using the Sitecore API
                //Contenttype[] = Person, Article, Base
                Contenttype[] contenttype = schemaRoot.contentmodel.contenttype;
                Field[] personfields = contenttype.Single(x => x.name == "Person").fields;
                Field[] basefields = contenttype.Single(x => x.name == "Base").fields;
                Field[] articlefields = contenttype.Single(x => x.name == "Article").fields;

                //API Competency: Use the Sitecore API to navigate the tree.
                //Items Competency: Define a Sitecore template with different sections and field types
                using (new SecurityModel.SecurityDisabler())
                {
                    //Sitecore Template Filepaths
                    //Items Competency: Define a Sitecore template with different sections and field types
                    Data.Database master = Sitecore.Configuration.Factory.GetDatabase("master");
                    Data.Database core = Sitecore.Configuration.Factory.GetDatabase("core");
                    Item textFieldType = core.GetItem("/sitecore/system/field types/simple types/single-line text");
                    Item selectionFieldType = core.GetItem("/sitecore/system/field types/list types/droplist");
                    Item textareaFieldType = core.GetItem("/sitecore/system/field types/simple types/multi-line text");
                    Item richtextFieldType = core.GetItem("/sitecore/system/field types/simple types/rich text");
                    Item dateFieldType = core.GetItem("/sitecore/system/field types/simple types/date");
                    Item parent = master.GetItem("/sitecore/templates/Feature/Articles");

                    //Create Person template
                    TemplateItem PersonTemplate = master.GetItem("/sitecore/templates/Feature/Articles/Person template");

                    if (PersonTemplate == null)
                    {
                        PersonTemplate = master.Templates.CreateTemplate("Person template", parent);
                    }

                    //Create Author section
                    TemplateSectionItem data = PersonTemplate.GetSection("Author");

                    if (data == null || data.InnerItem.Parent.ID != PersonTemplate.ID)
                    {
                        data = PersonTemplate.AddSection("Author", false);

                        //Add section fields
                        foreach (Field field in personfields)
                        {
                            string fieldname = field.name;
                            TemplateFieldItem addfield = data.AddField(fieldname);
                            addfield.BeginEdit();
                            addfield.Type = textFieldType.Name;
                            addfield.EndEdit();
                        }
                    }

                    //Create Base template
                    TemplateItem BaseTemplate = master.GetItem("/sitecore/templates/Feature/Articles/Base template");

                    if (BaseTemplate == null)
                    {
                        BaseTemplate = master.Templates.CreateTemplate("Base template", parent);
                    }

                    //Create Article data section
                    TemplateSectionItem basedata = BaseTemplate.GetSection("Article data");

                    if (basedata == null || basedata.InnerItem.Parent.ID != BaseTemplate.ID)
                    {
                        basedata = BaseTemplate.AddSection("Article data", false);

                        //Add section fields
                        foreach (Field field in basefields)
                        {
                            string fieldname = field.name;
                            TemplateFieldItem addfield = basedata.AddField(fieldname);

                            addfield.BeginEdit();
                            if (field.metadata.objtype.Equals("String"))
                            {
                                addfield.Type = textFieldType.Name;
                            }
                            //Inherit "Person" objtype
                            if (field.metadata.objtype.Equals("Person"))
                            {
                                addfield.Type = selectionFieldType.Name;
                                addfield.Source = "/sitecore/Templates/Feature/Articles/Person template";
                            }
                            addfield.EndEdit();
                        }
                    }

                    //Build Article template
                    TemplateItem ArticleTemplate = master.GetItem("/sitecore/templates/Feature/Articles/Article template");

                    if (ArticleTemplate == null)
                    {
                        ArticleTemplate = master.Templates.CreateTemplate("Article template", parent);
                    }

                    //Templates Competency: + Apply data template inheritance to new and existing data templates
                        //Inherit Base template
                    Data.Fields.MultilistField baseTemplates = ArticleTemplate.InnerItem.Fields[FieldIDs.BaseTemplate];

                    foreach (string key in new string[] { "/sitecore/templates/Feature/Articles/Base template", TemplateIDs.Folder.ToString() })
                    {
                        TemplateItem template = master.GetItem(key);

                        if (!baseTemplates.Contains(template.ID.ToString()))
                        {
                            ArticleTemplate.InnerItem.Editing.BeginEdit();
                            baseTemplates.Add(template.ID.ToString());
                            ArticleTemplate.InnerItem.Editing.EndEdit();
                        }
                    }

                    //Add Article section
                    TemplateSectionItem articledata = ArticleTemplate.GetSection("Article details");

                    if (articledata == null || articledata.InnerItem.Parent.ID != ArticleTemplate.ID)
                    {

                        articledata = ArticleTemplate.AddSection("Article details");

                        //add unique fields
                        foreach (Field field in articlefields)
                        {
                            string fieldname = field.name;
                            TemplateFieldItem addfield = articledata.AddField(fieldname);

                            addfield.BeginEdit();
                            if (field.metadata.fieldtype.Equals("Textarea"))
                            {
                                addfield.Type = textareaFieldType.Name;
                            }
                            if (field.metadata.fieldtype.Equals("Richtext"))
                            {
                                addfield.Type = richtextFieldType.Name;
                            }
                            if (field.metadata.fieldtype.Equals("Date"))
                            {
                                addfield.Type = dateFieldType.Name;
                            }
                            addfield.EndEdit();
                        }
                    }
                }
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ReadJsonStringViewModel model)
        {
            CreateTemplates();

            new ReadJsonStringViewModel();
            model.JsonString = "Success! Templates created.";

            //try/catch: Sitecore.Diagnostics.Log.Info

            if (ModelState.IsValid)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                sb.Append("Output: " + model.JsonString + "</br/>");
                return Content(sb.ToString());
            }
            else
            {
                return View(model);

            }
        }
    }
}

//Presentation Competency: Configure compatible renderings on a component definition item. 
// {CBC91E16-E330-4C0A-8B99-06929D19F6A1} - sitecore/layout/Renderings/Feature/Articles/Article templates import and 
//{14587B69-2600-4F8F-990C-2590E61A42C0} - sitecore/layout/Renderings/Feature/Articles/Article feed controllers are compatible renderings. 