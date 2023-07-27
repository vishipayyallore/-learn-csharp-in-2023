namespace ArrayAlgosDemo.Common;

public static class ConsoleColorStyleHelper
{
    public static ConsoleColor GetConsoleForegroundColor(ConsoleColorStyle style)
    {
        return style switch
        {
            ConsoleColorStyle.DarkGreen => ConsoleColor.DarkGreen,
            ConsoleColorStyle.DarkMagenta => ConsoleColor.DarkMagenta,
            _ => ConsoleColor.White
        };
    }

}
