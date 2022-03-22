using Sitecore.Data;
using Sitecore.Data.Items;

namespace Sitecore.Feature.Contacts.Tests
{
    public class BasicContentExtractor : IBasicContentExtractor
    {

        //TO-DO: Implement custom route configuration for dependency injection needed for unit testing Feature\Contacts\code\Controllers\CreateContactController.cs
        public string ExtractIntro(Item item)
        {
            var intro = item["Intro"];
            if (string.IsNullOrEmpty(intro))
            {
                intro = "The Intro field is empty.";
            }

            return intro;
        }
    }
}

