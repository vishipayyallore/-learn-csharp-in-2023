namespace NamesArray.Lib.Interfaces
{

    public interface INamesArray
    {
        string[] GenerateNames(int numberOfNames = 10, int nameLength = 10);
    }

}
