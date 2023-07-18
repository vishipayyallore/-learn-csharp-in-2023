using ListAlgosDemo;
using System.Data.Common;

ForegroundColor = ConsoleColor.DarkCyan;

var color = "DarkCyan";
Enum.TryParse<ConsoleColor>(color?.TrimEnd(), out ConsoleColor res);
WriteLine($"Color: {res}");

color = null;
Enum.TryParse<ConsoleColor>(color?.TrimEnd(), out res);
WriteLine($"Color: {res}");

color = string.Empty;
Enum.TryParse<ConsoleColor>(color?.TrimEnd(), out res);
WriteLine($"Color: {res}");

color = "";
Enum.TryParse<ConsoleColor>(color?.TrimEnd(), out res);
WriteLine($"Color: {res}");

ResetColor();

// ValidateSubsequence.ShowDemo();

