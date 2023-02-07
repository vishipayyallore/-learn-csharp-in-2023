using HeaderFooter;
using HeaderFooter.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using QuickPoc.Helpers;

namespace QuickPoc.Extensions
{

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            _ = services.AddTransient<IFooter, Footer>();
            _ = services.AddTransient<IHeader, Header>();

            _ = services.AddTransient<ProgramRunner>();

            // IMPORTANT! Register the application entry point
            _ = services.AddTransient<SetOneRunner>();

            return services;
        }
    }
}
