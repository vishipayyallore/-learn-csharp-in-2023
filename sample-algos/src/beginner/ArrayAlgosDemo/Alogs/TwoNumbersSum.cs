using ArrayAlgosDemo.Common;
using HeaderFooter;

namespace ArrayAlgosDemo.Alogs;

public static class TwoNumbersSum
{
    private static readonly Header _header = new();
    private static readonly Footer _footer = new();

    public static void ShowDemo()
    {
        _header.DisplayHeader('=', "Two Numbers Sum");

        ForegroundColor = ConsoleColor.DarkCyan;

        int[] outputArray = TwoNumberSum(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10);

        WriteLine($"Output: [{Helpers.ConvertIntArrayToString(outputArray)}]");

        ResetColor();

        _footer.DisplayFooter('-');
    }

    private static int[] TwoNumberSum(int[] inputNumbers, int sumToMatch)
    {
        WriteLine($"Input Array: [{Helpers.ConvertIntArrayToString(inputNumbers)}]");
        WriteLine($"Sum to Match: {sumToMatch}");

        for (int i = 0; i < inputNumbers.Length - 1; i++)
        {
            for (int j = i + 1; j < inputNumbers.Length; j++)
            {
                // WriteLine($"{i + 1}. {inputNumbers[i]} + {inputNumbers[j]}"); // Uncomment this line for Debugging

                if (inputNumbers[i] + inputNumbers[j] == sumToMatch)
                {
                    return new[] { inputNumbers[i], inputNumbers[j] };
                }
            }
        }

        return Array.Empty<int>();
    }
}
