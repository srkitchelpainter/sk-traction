using Sitecore.Data.Items;

namespace Sitecore.Feature.Contacts.Tests
{
    //TO-DO: Implement custom route configuration for dependency injection needed for unit testing Feature\Contacts\code\Controllers\CreateContactController.cs
    public interface IBasicContentExtractor
    {
        string ExtractIntro(Item item);
    }
}
