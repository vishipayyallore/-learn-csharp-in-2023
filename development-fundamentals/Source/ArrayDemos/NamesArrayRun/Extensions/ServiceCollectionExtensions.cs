using HeaderFooter;
using HeaderFooter.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using NamesArrayLib;
using NamesArrayLib.Interfaces;
using NamesArrayRun.Runnable;
using NamesGenerator;
using NamesGenerator.Interfaces;
using PrintHelperLib;
using PrintHelperLib.Interfaces;

namespace NamesArrayRun.Extensions
{

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            _ = services.AddTransient<IFooter, Footer>();
            _ = services.AddTransient<IHeader, Header>();

            _ = services.AddTransient<IGenerateNames, GenerateNames>();

            _ = services.AddTransient<INamesArray, NamesArray>();
            _ = services.AddTransient<IPrintHelper, PrintHelper>();

            // IMPORTANT! Register the application entry point
            _ = services.AddTransient<NamesArrayApp>();

            return services;
        }
    }

}
