using System.Collections;

namespace NamesArrayListLib.Interfaces;

public interface INamesArrayList
{
    ArrayList GenerateNames(int nameLength = 10, int numberOfNames = 10);
}