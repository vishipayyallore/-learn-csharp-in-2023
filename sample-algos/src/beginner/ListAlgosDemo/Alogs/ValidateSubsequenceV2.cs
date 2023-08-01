using ConsoleColorStyleLib;
using HeaderFooter;
using ListAlgosDemo.Common;
using ListAlgosDemo.Entities;

namespace ListAlgosDemo.Alogs;

public static class ValidateSubsequenceV2
{
    private static readonly Header _header = new();
    private static readonly Footer _footer = new();
    private static readonly string title = "Validate Subsequence - V2 - ";

    public static void ShowDemo()
    {
        int iCounter = 0;

        ValidateSubsequenceInputSet.GenerateInputSets().ForEach(inputSet =>
        {
            iCounter++;

            if (inputSet.NumbersList is null || inputSet.Sequence is null)
            {
                ForegroundColor = ConsoleColorStyleHelper.GetConsoleForegroundColor(ConsoleColorStyle.Red);
                WriteLine($"Error: Input list or sequence is null. Set {iCounter}");
                ResetColor();

                return;
            }

            ExecuteValidation(inputSet.NumbersList, inputSet.Sequence, $"{title} - Set {iCounter}", ConsoleColorStyle.DarkCyan);
        });
    }

    private static void ExecuteValidation(List<int> numbersList, List<int> sequence, string title, ConsoleColorStyle consoleColorStyle)
    {
        _header.DisplayHeader('=', title);

        ForegroundColor = ConsoleColorStyleHelper.GetConsoleForegroundColor(consoleColorStyle);

        DisplayInputAndSequence(numbersList, sequence, title);

        bool isValidSubsequence = IsValidSubsequence(numbersList, sequence);

        WriteLine($"Is Valid Subsequence: {isValidSubsequence}");

        ResetColor();

        _footer.DisplayFooter('-');
    }

    private static bool IsValidSubsequence(List<int> numbersList, List<int> sequence)
    {
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

    private static void DisplayInputAndSequence(List<int> numbersList, List<int> sequence, string title)
    {
        WriteLine($"{title}");
        WriteLine($"Input List: {ListToStringHelper.ConvertIntegerListToString(numbersList)}");
        WriteLine($"Sequence: {ListToStringHelper.ConvertIntegerListToString(sequence)}");
    }

}