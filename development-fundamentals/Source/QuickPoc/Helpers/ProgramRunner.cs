using HeaderFooter;
using HeaderFooter.Interfaces;
using QuickPoc.Interfaces;

namespace QuickPoc.Helpers
{
    public static class ProgramRunner
    {
        private static readonly IHeader _header = new Header();
        private static readonly IFooter _footer = new Footer();

        public static void Run(IDemoProgram demoProgram, string programTitle = "No Title")
        {
            _header.DisplayHeader('=', programTitle);

            ForegroundColor = ConsoleColor.Cyan;
            demoProgram.RunProgram();
            Console.ResetColor();

            _footer.DisplayFooter('-');
        }

    }
}
