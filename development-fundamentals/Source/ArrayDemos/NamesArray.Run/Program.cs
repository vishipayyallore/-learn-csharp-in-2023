using Microsoft.Extensions.Hosting;
using NamesArray.Run.Extensions;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.ConfigureServices();
    })
    .Build();