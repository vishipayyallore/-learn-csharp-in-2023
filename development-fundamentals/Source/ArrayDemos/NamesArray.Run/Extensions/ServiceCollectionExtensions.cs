using HeaderFooter.Extensions;
using Microsoft.Extensions.DependencyInjection;
using NamesArray.Lib.Extensions;
using NamesGenerator.Extensions;

namespace NamesArray.Run.Extensions
{

    public static class ServiceCollectionExtensions
    {
        public static ServiceProvider ConfigureServices()
        {
            // create service collection
            IServiceCollection services = new ServiceCollection();

            _ = services.ConfigureHeaderFooterServices();
            _ = services.ConfigureNamesGeneratorServices();
            _ = services.ConfigureNamesArrayDemoServices();

            // IMPORTANT! Register the application entry point
            // _ = services.AddTransient<NamesArrayDemoApp>();

            return services.BuildServiceProvider();
        }
    }

}
