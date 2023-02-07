using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuickPoc.Extensions;
using QuickPoc.Runners;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.ConfigureServices();
    })
    .Build();

host.Services.GetRequiredService<SetOneRunner>()?.Run();

Console.WriteLine("\nPress any key ...");