using System;
using Sitecore.Data;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Glass.Mapper.Sc.Configuration;
using Sitecore.Globalization;
using Sitecore.Data.Items;
using Sitecore.Data.Fields;
using Sitecore.Mvc.Presentation;

namespace LearnSc93Proj.Models.Identity
{
    public class Identity
    {
        public string imageUrl { get; set; }
        public string mediaAlt { get; set; }
    }
}