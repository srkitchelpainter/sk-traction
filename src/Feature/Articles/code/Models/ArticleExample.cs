using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;

namespace Sitecore.Feature.Articles.Models
{
    public class ArticleExample : IRenderingModel
    {
        public Rendering Rendering { get; set; }
        public Item Item { get; set; }
        public Item PageItem { get; set; }

        public IEnumerable<ArticleInfo> ArticleList { get; set; }

        [SitecoreType(AutoMap = true)]
        public class ArticleItem
        {
            public virtual IEnumerable<ArticleInfo> Children { get; set; }
        }

        [SitecoreType(AutoMap = true)]
        public class ArticleInfo
        {
            [SitecoreId]
            public virtual Guid Id { get; set; }

            [SitecoreInfo(SitecoreInfoType.Url)]
            public virtual string Url { get; set; }

            [SitecoreField]
            public virtual string Title { get; set; }
        }
        public void Initialize(Rendering rendering)
        {
            Rendering = rendering;
            Item = rendering.Item;
            PageItem = PageContext.Current.Item;
        }
    }
}