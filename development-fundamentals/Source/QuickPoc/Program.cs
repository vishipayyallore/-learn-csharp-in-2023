using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuickPoc.Extensions;
using QuickPoc.Runners;
using QuickPoc.Set1;

// Compiler version: '4.4.0-6.22608.27 (af1e46ad)'.Language version: 11.0.QuickPoc    C:\LordKrishna\GitHub\learn - csharp -in-2023\development - fundamentals\Source\QuickPoc\Program.cs  7   Active
// #error version 

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

