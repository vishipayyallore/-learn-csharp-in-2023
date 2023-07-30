namespace ListAlgosDemo.Common;

public static class ListToStringHelper
{
    public static string ConvertIntegerListToString(List<int> inputList)
    {
        return string.Join(", ", inputList);
    }
}