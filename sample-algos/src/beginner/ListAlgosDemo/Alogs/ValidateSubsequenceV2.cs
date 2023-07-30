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

        _header.DisplayHeader('=', title);

        ValidateSubsequenceInputSet.GenerateInputSets().ForEach(inputSet =>
        {
            iCounter++;

            if (inputSet.NumbersList is null || inputSet.Sequence is null)
            {
                Console.WriteLine("Error: Input list or sequence is null.");
                return;
            }

            ExecuteValidation(inputSet.NumbersList, inputSet.Sequence, $"{title} - Set {iCounter}");
        });

        _footer.DisplayFooter('-');
    }

    private static void ExecuteValidation(List<int> numbersList, List<int> sequence, string title)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        // Common Logic A: Display input and sequence
        DisplayInputAndSequence(numbersList, sequence, title);

        // Execute the validation
        bool isValidSubsequence = IsValidSubsequence(numbersList, sequence);

        // Common Logic B: Display output
        Console.WriteLine($"Is Valid Subsequence: {isValidSubsequence}");

        Console.ResetColor();
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
        Console.WriteLine($"{title}");
        Console.WriteLine($"Input List: {ListToStringHelper.ConvertIntegerListToString(numbersList)}");
        Console.WriteLine($"Sequence: {ListToStringHelper.ConvertIntegerListToString(sequence)}");
    }

}