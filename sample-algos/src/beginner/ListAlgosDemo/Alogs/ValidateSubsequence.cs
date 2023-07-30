using HeaderFooter;
using ListAlgosDemo.Common;

namespace ListAlgosDemo.Alogs;

public static class ValidateSubsequence
{

    private static readonly Header _header = new();
    private static readonly Footer _footer = new();

    public static void ShowDemo()
    {
        _header.DisplayHeader('=', "Validate Subsequence");

        ForegroundColor = ConsoleColor.DarkCyan;

        // var results = IsValidSubsequence(new List<int> { 1, 2, 3, 4 }, new List<int> { 1, 3 });
        var results = IsValidSubsequence(new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 1, 6, -1, 10 });
        // var results = IsValidSubsequence(new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 5, 1, 22, 22, 6, -1, 8, 10 });
        WriteLine($"Is Valid Subsequence: {results}");

        ResetColor();

        _footer.DisplayFooter('-');
    }

    private static bool IsValidSubsequence(List<int> numbersList, List<int> sequence)
    {
        WriteLine($"Inputs: {ListToStringHelper.ConvertIntegerListToString(numbersList)}");
        WriteLine($"Sequence Inputs: {ListToStringHelper.ConvertIntegerListToString(sequence)}");

        if (sequence.Count > numbersList.Count || sequence.Count != sequence.ToHashSet().Count && sequence.ToHashSet().Count != 1)
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