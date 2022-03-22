using Sitecore.Feature.Fundamentals.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.Feature.Fundamentals.Controllers;

namespace Sitecore.Feature.Fundamentals
{
    public class RegisterDependencies : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<StockController>();
            serviceCollection.AddTransient(typeof(IStockRepository),
                typeof(StockService));
        }
    }
}