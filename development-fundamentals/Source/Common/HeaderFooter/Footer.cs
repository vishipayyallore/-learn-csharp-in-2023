using HeaderFooter.Interfaces;

using static System.Console;

namespace HeaderFooter
{

    public class Footer : IFooter
    {

        public void DisplayFooter(char footer, int length = 100, ConsoleColor foregroundColor = ConsoleColor.Yellow)
        {
            ForegroundColor = ConsoleColor.Yellow;

            WriteLine($"\n{new string(footer, length)}\n");

            ResetColor();
        }

    }

}