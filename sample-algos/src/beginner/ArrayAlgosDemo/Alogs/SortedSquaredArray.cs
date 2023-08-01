using ArrayAlgosDemo.Common;
using ArrayAlgosDemo.Entities;
using ConsoleColorStyleLib;
using HeaderFooter;

namespace ArrayAlgosDemo.Alogs;

public static class SortedSquaredArray
{
    private static readonly Header _header = new();
    private static readonly Footer _footer = new();
    private static readonly string title = "SortedSquaredArray";

    public static void ShowDemo()
    {
        int iCounter = 0;

        SortedSquaredArrayInputSet.GenerateSortedSquaredArrayInputs().ForEach(inputSet =>
        {
            iCounter++;

            if (inputSet is null || inputSet.InputArray is null)
            {
                ForegroundColor = ConsoleColorStyleHelper.GetConsoleForegroundColor(ConsoleColorStyle.Red);
                WriteLine($"Error: Input list or sequence is null. Set {iCounter}");
                ResetColor();

                return;
            }

            ExecuteSortedSquaredArray(inputSet.InputArray, GenerateSortedSquaredArray, $"{title} - Set {iCounter}", ConsoleColorStyle.DarkCyan);
        });
    }

    private static void ExecuteSortedSquaredArray(int[] inputArray, Func<int[], int[]> sortedSquaredArrayFunc, string title, ConsoleColorStyle consoleColorStyle)
    {
        _header.DisplayHeader('=', title);

        ForegroundColor = ConsoleColorStyleHelper.GetConsoleForegroundColor(consoleColorStyle);

        DisplayInputArray(inputArray, title);

        var sortedSquaredArray = sortedSquaredArrayFunc(inputArray);

        WriteLine($"Sorted Squared Array: {ArrayToStringHelper.ConvertIntArrayToString(sortedSquaredArray)}");

        ResetColor();

        _footer.DisplayFooter('-');
    }

    private static int[] GenerateSortedSquaredArray(int[] inputArray)
    {
        int n = inputArray.Length;
        int[] result = new int[n];
        int left = 0;
        int right = n - 1;
        int index = n - 1;

        while (left <= right)
        {
            int leftSquare = inputArray[left] * inputArray[left];
            int rightSquare = inputArray[right] * inputArray[right];

            if (leftSquare >= rightSquare)
            {
                result[index] = leftSquare;
                left++;
            }
            else
            {
                result[index] = rightSquare;
                right--;
            }

            index--;
        }

        return result;
    }

    private static void DisplayInputArray(int[] inputArray, string title)
    {
        WriteLine($"{title}");
        WriteLine($"Input Array: {ArrayToStringHelper.ConvertIntArrayToString(inputArray)}");
    }

}
