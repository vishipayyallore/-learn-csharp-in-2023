using HeaderFooter.Interfaces;
using NamesArrayLib.Interfaces;
using PrintHelperLib.Interfaces;

namespace NamesArrayRun.Runnable;

internal class NamesArrayApp
{
    private readonly INamesArray _namesArray;
    private readonly IPrintHelper _printHelper;
    private readonly IHeader _header;
    private readonly IFooter _footer;

    public NamesArrayApp(INamesArray namesArray, IPrintHelper printHelper, IHeader header, IFooter footer)
    {
        _namesArray = namesArray ?? throw new ArgumentNullException(nameof(namesArray));

        _printHelper = printHelper ?? throw new ArgumentNullException(nameof(printHelper));

        _header = header ?? throw new ArgumentNullException(nameof(header));

        _footer = footer ?? throw new ArgumentNullException(nameof(footer));
    }

    public void Run()
    {
        Random _random = new();

        _header.DisplayHeader('=', "Names Array Demo");

        ForegroundColor = ConsoleColor.Cyan;
        _printHelper.Print(_namesArray.GenerateNames(nameLength: _random.Next(5, 10), numberOfNames: 10));
        ResetColor();

        _footer.DisplayFooter('-');
    }
}
