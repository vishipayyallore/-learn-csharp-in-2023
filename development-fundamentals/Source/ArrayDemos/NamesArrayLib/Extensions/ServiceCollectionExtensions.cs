using Microsoft.Extensions.DependencyInjection;
using NamesArrayLib;
using NamesArrayLib.Interfaces;

namespace NamesArrayLib.Extensions
{

    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection ConfigureNamesArrayDemoServices(this IServiceCollection services)
        {
            _ = services.AddTransient<INamesArray, NamesArray>();
            _ = services.AddTransient<IPrintHelper, PrintHelper>();

            return services;
        }

    }

}
