using ListAlgosDemo.Common;

namespace ListAlgosDemo;

public static class ValidateSubsequence
{
    public static void ShowDemo()
    {
        ForegroundColor = ConsoleColor.Yellow;
        WriteLine("***** Validate Subsequence *****");

        // var results = IsValidSubsequence(new List<int> { 1, 2, 3, 4 }, new List<int> { 1, 3 });
        var results = IsValidSubsequence(new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 1, 6, -1, 10 });
        // var results = IsValidSubsequence(new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 5, 1, 22, 22, 6, -1, 8, 10 });
        WriteLine($"Is Valid Subsequence: {results}");

        WriteLine("----- Validate Subsequence -----");
        ResetColor();
    }

    private static bool IsValidSubsequence(List<int> numbersList, List<int> sequence)
    {
        WriteLine($"Inputs: {Helpers.ConvertIntegerListToString(numbersList)}");
        WriteLine($"Sequence Inputs: {Helpers.ConvertIntegerListToString(sequence)}");

        if (sequence.Count > numbersList.Count || (sequence.Count != sequence.ToHashSet().Count && sequence.ToHashSet().Count != 1))
        {
            return false;
        }

        var currentIndex = 0;
        foreach (var item in sequence)
        {
            var index = numbersList.IndexOf(item);
            if (index == -1 || index < currentIndex)
            {
                return false;
            }
            currentIndex = index;
        }

        return true;
    }
}