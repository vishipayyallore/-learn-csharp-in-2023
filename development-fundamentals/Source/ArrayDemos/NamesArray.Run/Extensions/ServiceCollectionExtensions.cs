using HeaderFooter.Extensions;
using Microsoft.Extensions.DependencyInjection;
using NamesArray.Lib.Extensions;
using NamesGenerator.Extensions;

namespace NamesArray.Run.Extensions
{

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            _ = services.ConfigureHeaderFooterServices();
            _ = services.ConfigureNamesGeneratorServices();
            _ = services.ConfigureNamesArrayDemoServices();

            return services;
        }
    }

}
