namespace ArrayAlgosDemo.Entities;

internal class TwoNumbersSumInputSet
{
    public int[]? InputNumbers { get; set; }

    public int SumToMatch { get; set; }

    public static List<TwoNumbersSumInputSet> GenerateTwoNumbersSumInputs() => new()
            {
                new TwoNumbersSumInputSet { InputNumbers = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, SumToMatch = 10 },
                new TwoNumbersSumInputSet { InputNumbers = new int[] { 2, 4, 6, 8, 10 }, SumToMatch = 12 },
                new TwoNumbersSumInputSet { InputNumbers = new int[] { -3, 1, 5, 8, -2 }, SumToMatch = 6 },
                new TwoNumbersSumInputSet { InputNumbers = new int[] { 0, 1, 2, 3, 4 }, SumToMatch = 8 },
                new TwoNumbersSumInputSet { InputNumbers = null, SumToMatch = 15 }, // Test case with null InputNumbers
            };
}
