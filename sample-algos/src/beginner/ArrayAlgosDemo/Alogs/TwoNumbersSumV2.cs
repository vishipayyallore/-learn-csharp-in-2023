using ArrayAlgosDemo.Common;
using ArrayAlgosDemo.Entities;
using ConsoleColorStyleLib;
using HeaderFooter;

namespace ArrayAlgosDemo.Alogs;

public static class TwoNumbersSumV2
{
    private static readonly Header _header = new();
    private static readonly Footer _footer = new();
    private static readonly string[] titles = { "Two Numbers Sum - V1", "Two Numbers Sum - V2" };

    public static void ShowDemo()
    {
        int iCounter = 0;

        TwoNumbersSumInputSet.GenerateTwoNumbersSumInputs().ForEach(input =>
        {
            iCounter++;

            if (input.InputNumbers is null)
            {
                ForegroundColor = ConsoleColorStyleHelper.GetConsoleForegroundColor(ConsoleColorStyle.Red);
                WriteLine($"Error: Input array or function parameter is null. Set {iCounter}");
                ResetColor();

                return;
            }

            // Using Func<T> version for FindTwoNumbersSumBruteForce logic
            ExecuteTwoNumberSum(input.InputNumbers, input.SumToMatch, FindTwoNumbersSumBruteForce, $"{titles[0]} - Set {iCounter}", ConsoleColorStyle.DarkGreen);

            // Using Func<T> version for FindTwoNumbersSumHashSet logic
            ExecuteTwoNumberSum(input.InputNumbers, input.SumToMatch, FindTwoNumbersSumHashSet, $"{titles[1]} - Set {iCounter}", ConsoleColorStyle.DarkMagenta);
        });
    }

    private static void ExecuteTwoNumberSum(int[] inputNumbers, int sumToMatch, Func<int[], int, int[]> twoNumberSumFunc,
        string title, ConsoleColorStyle consoleColor)
    {
        _header.DisplayHeader('=', title);

        ForegroundColor = ConsoleColorStyleHelper.GetConsoleForegroundColor(consoleColor);

        // Common Logic A: Display input and sum
        DisplayInputAndSum(inputNumbers, sumToMatch);

        // Execute the provided function (Func<T>)
        int[] outputArray = twoNumberSumFunc(inputNumbers, sumToMatch);

        // Common Logic B: Display output
        WriteLine($"Output: [{ArrayToStringHelper.ConvertIntArrayToString(outputArray)}]");

        ResetColor();

        _footer.DisplayFooter('-');
    }

    private static int[] FindTwoNumbersSumBruteForce(int[] inputNumbers, int sumToMatch)
    {
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

        // Common Logic B: Return Array.Empty<int>() when no match is found
        return Array.Empty<int>();
    }

    private static int[] FindTwoNumbersSumHashSet(int[] inputNumbers, int sumToMatch)
    {
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

        // Common Logic B: Return Array.Empty<int>() when no match is found
        return Array.Empty<int>();
    }

    private static void DisplayInputAndSum(int[] inputNumbers, int sumToMatch)
    {
        WriteLine($"Input Array: [{ArrayToStringHelper.ConvertIntArrayToString(inputNumbers)}]");
        WriteLine($"Sum to Match: {sumToMatch}");
    }

}
