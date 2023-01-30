using Microsoft.Extensions.DependencyInjection;
using NamesGenerator.Interfaces;

namespace NamesGenerator.Extensions
{
    public static class NamesGeneratorExtensions
    {
        public static IServiceCollection ConfigureNamesGeneratorServices(this IServiceCollection services)
        {
            _ = services.AddTransient<IGenerateNames, GenerateNames>();

            return services;
        }
    }

}
