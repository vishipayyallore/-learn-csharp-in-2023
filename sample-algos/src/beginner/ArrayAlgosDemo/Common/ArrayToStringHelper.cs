namespace ArrayAlgosDemo.Common;

public static class ArrayToStringHelper
{
    public static string[] ConvertIntArrayToStringArray(int[] inputArray)
    {
        return Array.ConvertAll(inputArray, ele => ele.ToString());
    }

    public static string ConvertIntArrayToString(int[] inputArray)
    {
        return string.Join(", ", ConvertIntArrayToStringArray(inputArray));
    }
}