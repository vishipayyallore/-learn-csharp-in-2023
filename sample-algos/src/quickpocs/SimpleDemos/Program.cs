
ShowCaseTryParseEnumDemo();

static void ShowCaseTryParseEnumDemo()
{
    ForegroundColor = ConsoleColor.DarkCyan;

    var color = "DarkCyan";
    _ = Enum.TryParse(color?.TrimEnd(), out ConsoleColor res);
    WriteLine($"Color: {res}");

    color = null;
    _ = Enum.TryParse(color?.TrimEnd(), out res);
    WriteLine($"Color: {res}");

    color = string.Empty;
    _ = Enum.TryParse(color?.TrimEnd(), out res);
    WriteLine($"Color: {res}");

    color = "";
    _ = Enum.TryParse(color?.TrimEnd(), out res);
    WriteLine($"Color: {res}");

    ResetColor();
}