using NamesArrayLib.Interfaces;
using NamesGenerator.Interfaces;

namespace NamesArrayLib;

public class NamesArray : INamesArray
{
    private readonly IGenerateNames _nameGenerator;

    public NamesArray(IGenerateNames nameGenerator)
    {
        _nameGenerator = nameGenerator ?? throw new ArgumentNullException(nameof(nameGenerator));
    }

    public string[] GenerateNames(int nameLength = 10, int numberOfNames = 10)
    {
        return _nameGenerator.GetNames(nameLength, numberOfNames);
    }

}