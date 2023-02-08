using HeaderFooter;
using HeaderFooter.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using NamesArrayListLib;
using NamesArrayListLib.Interfaces;
using NamesArrayListRun.Runnable;
using NamesGenerator;
using NamesGenerator.Interfaces;

namespace NamesArrayListRun.Extensions
{

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            _ = services.AddTransient<IFooter, Footer>();
            _ = services.AddTransient<IHeader, Header>();

            _ = services.AddTransient<IGenerateNames, GenerateNames>();

            _ = services.AddTransient<INamesArrayList, NamesArrayList>();
            _ = services.AddTransient<IPrintHelper, PrintHelper>();

            // IMPORTANT! Register the application entry point
            _ = services.AddTransient<NamesArrayListApp>();

            return services;
        }
    }

}
