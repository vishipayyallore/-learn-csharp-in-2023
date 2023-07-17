namespace ListAlgosDemo.Common;

public static class Helpers
{
    public static string ConvertIntegerListToString(List<int> inputList)
    {
        return string.Join(", ", inputList);
    }
}