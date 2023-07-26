using ArrayAlgosDemo.Common;
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

        ExecuteTwoNumberSum(TwoNumberSumV1, inputNumbers, sumToMatch, titles[0], ConsoleColor.DarkCyan);

        ExecuteTwoNumberSum(TwoNumberSumV2, inputNumbers, sumToMatch, titles[1], ConsoleColor.DarkYellow);
    }

    private static void ExecuteTwoNumberSum(Func<int[], int, int[]> twoNumberSumMethod,
        int[] inputNumbers, int sumToMatch, string title, ConsoleColor consoleColor)
    {
        _header.DisplayHeader('=', title);

        ForegroundColor = consoleColor;

        int[] outputArray = twoNumberSumMethod(inputNumbers, sumToMatch);

        WriteLine($"Output: [{Helpers.ConvertIntArrayToString(outputArray)}]");

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
        WriteLine($"Input Array: [{Helpers.ConvertIntArrayToString(inputNumbers)}]");
        WriteLine($"Sum to Match: {sumToMatch}");
    }

}


//using System;
//using System.Collections.Generic;

//public static class TwoNumbersSum
//{
//    private static readonly Header _header = new();
//    private static readonly Footer _footer = new();
//    private static readonly string[] titles = { "Two Numbers Sum - V1", "Two Numbers Sum - V2" };

//    public static void ShowDemo()
//    {
//        var inputNumbers = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
//        var sumToMatch = 10;

//        // Using Func<T> version for TwoNumberSumV1 logic
//        ExecuteTwoNumberSum(inputNumbers, sumToMatch, TwoNumberSumV1, titles[0], ConsoleColor.DarkCyan);

//        // Using Func<T> version for TwoNumberSumV2 logic
//        ExecuteTwoNumberSum(inputNumbers, sumToMatch, TwoNumberSumV2, titles[1], ConsoleColor.DarkYellow);
//    }

//    private static void ExecuteTwoNumberSum(int[] inputNumbers, int sumToMatch, Func<int[], int, int[]> twoNumberSumFunc,
//        string title, ConsoleColor consoleColor)
//    {
//        _header.DisplayHeader('=', title);

//        Console.ForegroundColor = consoleColor;

//        // Common Logic A: Display input and sum
//        DisplayInputAndSum(inputNumbers, sumToMatch);

//        // Execute the provided function (Func<T>)
//        int[] outputArray = twoNumberSumFunc(inputNumbers, sumToMatch);

//        // Common Logic B: Display output
//        WriteLine($"Output: [{Helpers.ConvertIntArrayToString(outputArray)}]");

//        Console.ResetColor();

//        _footer.DisplayFooter('-');
//    }

//    private static int[] TwoNumberSumV1(int[] inputNumbers, int sumToMatch)
//    {
//        for (int i = 0; i < inputNumbers.Length - 1; i++)
//        {
//            for (int j = i + 1; j < inputNumbers.Length; j++)
//            {
//                if (inputNumbers[i] + inputNumbers[j] == sumToMatch)
//                {
//                    return new[] { inputNumbers[i], inputNumbers[j] };
//                }
//            }
//        }

//        // Common Logic B: Return Array.Empty<int>() when no match is found
//        return Array.Empty<int>();
//    }

//    private static int[] TwoNumberSumV2(int[] inputNumbers, int sumToMatch)
//    {
//        HashSet<int> visited = new();

//        for (int i = 0; i < inputNumbers.Length; i++)
//        {
//            int value = sumToMatch - inputNumbers[i];

//            if (visited.Contains(value))
//            {
//                return new[] { inputNumbers[i], value };
//            }

//            visited.Add(inputNumbers[i]);
//        }

//        // Common Logic B: Return Array.Empty<int>() when no match is found
//        return Array.Empty<int>();
//    }

//    private static void DisplayInputAndSum(int[] inputNumbers, int sumToMatch)
//    {
//        WriteLine($"Input Array: [{Helpers.ConvertIntArrayToString(inputNumbers)}]");
//        WriteLine($"Sum to Match: {sumToMatch}");
//    }

//    // Helper method to avoid Console.WriteLine() duplication
//    private static void WriteLine(string message)
//    {
//        Console.WriteLine(message);
//    }
//}
