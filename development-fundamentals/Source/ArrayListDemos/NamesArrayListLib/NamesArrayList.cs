using NamesArrayListLib.Interfaces;
using NamesGenerator.Interfaces;
using System.Collections;

namespace NamesArrayListLib;

public class NamesArrayList : INamesArrayList
{
    private readonly IGenerateNames _nameGenerator;

    public NamesArrayList(IGenerateNames nameGenerator)
    {
        _nameGenerator = nameGenerator ?? throw new ArgumentNullException(nameof(nameGenerator));
    }

    public ArrayList GenerateNames(int nameLength = 10, int numberOfNames = 10)
    {
        var namesArrayList = new ArrayList();
        namesArrayList.AddRange(_nameGenerator.GetNames(nameLength, numberOfNames));

        return namesArrayList;
    }

}
