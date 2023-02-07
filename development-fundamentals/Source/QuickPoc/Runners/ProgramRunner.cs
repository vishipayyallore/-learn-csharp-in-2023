using HeaderFooter.Interfaces;
using QuickPoc.Interfaces;

namespace QuickPoc.Runners
{
    public class ProgramRunner
    {
        private readonly IHeader _header;
        private readonly IFooter _footer;

        public ProgramRunner(IHeader header, IFooter footer)
        {
            _header = header ?? throw new ArgumentNullException(nameof(header));

            _footer = footer ?? throw new ArgumentNullException(nameof(footer));
        }

        public void Run(IDemoProgram demoProgram, string programTitle = "No Title")
        {
            _header.DisplayHeader('=', programTitle);

            ForegroundColor = ConsoleColor.Cyan;
            demoProgram.RunProgram();
            ResetColor();

            _footer.DisplayFooter('-');
        }

    }
}
