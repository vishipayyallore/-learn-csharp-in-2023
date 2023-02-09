﻿namespace QuickPoc.Set1
{

    internal class CommandLineArguments
    {

        public void Run(string[] args)
        {
            WriteLine($"There are {args.Length} arguments.");

            if (args.Length < 3)
            {
                WriteLine("You must specify two colors and cursor size, e.g.");
                WriteLine("dotnet run red yellow 50");
                return; // stop running
            }

            ForegroundColor = (ConsoleColor)Enum.Parse(
              enumType: typeof(ConsoleColor),
              value: args[0],
              ignoreCase: true);

            BackgroundColor = (ConsoleColor)Enum.Parse(
              enumType: typeof(ConsoleColor),
              value: args[1],
              ignoreCase: true);

            try
            {
                CursorSize = int.Parse(args[2]);
            }
            catch (PlatformNotSupportedException)
            {
                WriteLine("The current platform does not support changing the size of the cursor.");
            }

            foreach (string arg in args)
            {
                WriteLine(arg);
            }

            ResetColor();
        }
    }

}
