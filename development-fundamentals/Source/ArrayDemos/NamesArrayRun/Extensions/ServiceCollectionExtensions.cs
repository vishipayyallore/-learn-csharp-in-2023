using HeaderFooter.Extensions;
using Microsoft.Extensions.DependencyInjection;
using NamesArrayLib.Extensions;
using NamesArrayRun.Runnable;
using NamesGenerator.Extensions;

namespace NamesArrayRun.Extensions
{

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            _ = services.ConfigureHeaderFooterServices();
            _ = services.ConfigureNamesGeneratorServices();
            _ = services.ConfigureNamesArrayDemoServices();

            // IMPORTANT! Register the application entry point
            _ = services.AddTransient<NamesArrayDemoApp>();

            return services;
        }
    }

}
