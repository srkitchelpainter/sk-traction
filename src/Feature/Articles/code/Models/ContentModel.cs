//using newtonsoft.json (Edit>Paste Special>Paste JSON as classes)
namespace Sitecore.Feature.Articles.Models
{
    public class Rootobject
    {
        public Contentmodel contentmodel { get; set; }
    }

    public class Contentmodel
    {
        public Contenttype[] contenttype { get; set; }
    }

    public class Contenttype
    {
        public string name { get; set; }
        public Inherit[] inherits { get; set; }
        public Field[] fields { get; set; }
    }

    public class Inherit
    {
        public string type { get; set; }
    }

    public class Field
    {
        public string name { get; set; }
        public Metadata metadata { get; set; }
    }

    public class Metadata
    {
        public string objtype { get; set; }
        public string fieldtype { get; set; }
    }
}