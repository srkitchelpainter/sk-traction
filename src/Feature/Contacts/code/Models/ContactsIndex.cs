using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Sitecore.Feature.Contacts.Models
{
    public class ContactsIndex 
    {
        [SitecoreField]
        public virtual string Intro { get; set; }
        [SitecoreField(FieldType = Glass.Mapper.Sc.Configuration.SitecoreFieldType.Multilist)]
        public virtual IEnumerable<ContactsIndex> Contacts { get; set; }
        [SitecoreField]
        public virtual string FirstName { get; set; }
        [SitecoreField]
        public virtual string LastName { get; set; }
        [SitecoreField]
        public virtual string Email { get; set; }
        [SitecoreField]
        public virtual string JobTitle { get; set; }
        [SitecoreField]
        public virtual string Bio { get; set; }
        [SitecoreField]
        public virtual string Phone { get; set; }
        [SitecoreField]
        public virtual string Tracking { get; set; }

        public virtual string Url { get; set; }
    }
}