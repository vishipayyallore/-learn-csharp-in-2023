using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NamesArrayListRun.Extensions;
using NamesArrayListRun.Runnable;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.ConfigureServices();
    })
    .Build();

host.Services.GetRequiredService<NamesArrayListApp>()?.Run();

WriteLine("\n\nPress any key ... ");
ReadKey();