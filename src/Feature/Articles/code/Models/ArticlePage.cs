using System;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Web.UI.WebControls;
using Image = Glass.Mapper.Sc.Fields.Image;

namespace Sitecore.Feature.Articles.Models
{
    //Home/ArticleFeed/Articles/Article
    public class ArticlePage
    {
        //Intro Section - Fields and Field Types
        [SitecoreField]
        public virtual string Author { get; set; }
        [SitecoreField]
        public virtual string Title { get; set; }
        [SitecoreField]
        public virtual string Subtitle { get; set; }
        [SitecoreField]
        public virtual string Description { get; set; }
        //Simple Types
        [SitecoreField]
        public virtual bool Checkbox { get; set; }
        [SitecoreField]
        public virtual DateTime Date { get; set; }
        [SitecoreField]
        public virtual DateTime Datetime { get; set; }
        [SitecoreField]
        public virtual byte File { get; set; }
        [SitecoreField]
        public virtual Image Image { get; set; }
        [SitecoreField]
        public virtual string Integer { get; set; }
        [SitecoreField]
        public virtual string MultilineText { get; set; }
        [SitecoreField]
        public virtual string Number { get; set; }
        [SitecoreField]
        public virtual string Password { get; set; }
        [SitecoreField]
        public virtual string RichText { get; set; }
        [SitecoreField]
        public virtual string SingleLineText { get; set; }
    }
}