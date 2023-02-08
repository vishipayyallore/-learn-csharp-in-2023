using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuickPoc.Extensions;
using QuickPoc.Runners;
using QuickPoc.Set1;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
    {
        services.ConfigureServices();
    })
    .Build();

host.Services.GetRequiredService<SetOneRunner>()?.Run();

// TODO: Refactor this code.
host.Services.GetRequiredService<CommandLineArguments>()?.Run(args);

ResetColor();

Console.WriteLine("\nPress any key ...");

