using ArrayAlgosDemo.Common;
using HeaderFooter;

namespace ArrayAlgosDemo.Alogs;

public static class TwoNumbersSum
{
    private static readonly Header _header = new();
    private static readonly Footer _footer = new();

    public static void ShowDemo()
    {
        _header.DisplayHeader('=', "Two Numbers Sum - V1");

        ForegroundColor = ConsoleColor.DarkCyan;

        int[] outputArray = TwoNumberSumV1(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10);

        WriteLine($"Output: [{Helpers.ConvertIntArrayToString(outputArray)}]");

        ResetColor();

        _footer.DisplayFooter('-');

        _header.DisplayHeader('=', "Two Numbers Sum - V2");

        ForegroundColor = ConsoleColor.DarkCyan;

        outputArray = TwoNumberSumV2(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10);

        WriteLine($"Output: [{Helpers.ConvertIntArrayToString(outputArray)}]");

        ResetColor();

        _footer.DisplayFooter('-');
    }

    private static int[] TwoNumberSumV1(int[] inputNumbers, int sumToMatch)
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

    private static int[] TwoNumberSumV2(int[] inputNumbers, int sumToMatch)
    {
        WriteLine($"Input Array: [{Helpers.ConvertIntArrayToString(inputNumbers)}]");
        WriteLine($"Sum to Match: {sumToMatch}");

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
}
