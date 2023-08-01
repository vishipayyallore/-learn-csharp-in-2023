using ArrayAlgosDemo.Common;
using ConsoleColorStyleLib;
using HeaderFooter;

namespace ArrayAlgosDemo.Alogs;

public static class TwoNumbersSum
{
    private static readonly Header _header = new();
    private static readonly Footer _footer = new();
    private static readonly string[] titles = { "Two Numbers Sum - V1", "Two Numbers Sum - V2" };

    public static void ShowDemo()
    {
        var inputNumbers = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
        var sumToMatch = 10;

        ExecuteTwoNumberSum(TwoNumberSumV1, inputNumbers, sumToMatch, titles[0], ConsoleColorStyle.DarkCyan);

        ExecuteTwoNumberSum(TwoNumberSumV2, inputNumbers, sumToMatch, titles[1], ConsoleColorStyle.DarkYellow);
    }

    private static void ExecuteTwoNumberSum(Func<int[], int, int[]> twoNumberSumMethod,
        int[] inputNumbers, int sumToMatch, string title, ConsoleColorStyle consoleColor)
    {
        _header.DisplayHeader('=', title);

        ForegroundColor = ConsoleColorStyleHelper.GetConsoleForegroundColor(consoleColor);

        int[] outputArray = twoNumberSumMethod(inputNumbers, sumToMatch);

        WriteLine($"Output: [{ArrayToStringHelper.ConvertIntArrayToString(outputArray)}]");

        ResetColor();

        _footer.DisplayFooter('-');
    }

    private static int[] TwoNumberSumV1(int[] inputNumbers, int sumToMatch)
    {
        DisplayInputAndSum(inputNumbers, sumToMatch); ;

        for (int i = 0; i < inputNumbers.Length - 1; i++)
        {
            for (int j = i + 1; j < inputNumbers.Length; j++)
            {
                if (inputNumbers[i] + inputNumbers[j] == sumToMatch)
                {
                    return new[] { inputNumbers[i], inputNumbers[j] };
                }
            }
        }

        return Array.Empty<int>();
    }

    private static int[] TwoNumberSumV2(int[] inputNumbers, int sumToMatch)
    {
        DisplayInputAndSum(inputNumbers, sumToMatch);

        HashSet<int> visited = new();

        for (int i = 0; i < inputNumbers.Length; i++)
        {
            int value = sumToMatch - inputNumbers[i];

            if (visited.Contains(value))
            {
                return new[] { inputNumbers[i], value };
            }

            visited.Add(inputNumbers[i]);
        }

        return Array.Empty<int>();
    }

    private static void DisplayInputAndSum(int[] inputNumbers, int sumToMatch)
    {
        WriteLine($"Input Array: [{ArrayToStringHelper.ConvertIntArrayToString(inputNumbers)}]");
        WriteLine($"Sum to Match: {sumToMatch}");
    }

}
