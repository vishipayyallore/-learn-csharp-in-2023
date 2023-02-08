using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NamesArrayRun.Extensions;
using NamesArrayRun.Runnable;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.ConfigureServices();
    })
    .Build();

host.Services.GetRequiredService<NamesArrayApp>()?.Run();

WriteLine("\n\nPress any key ... ");
ReadKey();