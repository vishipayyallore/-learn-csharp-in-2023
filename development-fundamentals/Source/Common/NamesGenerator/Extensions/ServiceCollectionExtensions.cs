using Microsoft.Extensions.DependencyInjection;
using NamesGenerator.Interfaces;

namespace NamesGenerator.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureNamesGeneratorServices(this IServiceCollection services)
        {
            _ = services.AddTransient<IGenerateNames, GenerateNames>();

            return services;
        }
    }

}
