namespace ArrayAlgosDemo.Common;

public static class Helpers
{

    public static string[] ConvertIntToStringArray(int[] inputArray)
    {
        return Array.ConvertAll(inputArray, ele => ele.ToString());
    }

}