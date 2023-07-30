namespace ListAlgosDemo.Entities;

internal class ValidateSubsequenceInputSet
{
    public List<int>? NumbersList { get; set; }

    public List<int>? Sequence { get; set; }

    public static List<ValidateSubsequenceInputSet> GenerateInputSets() => new()
        {
            new ValidateSubsequenceInputSet { NumbersList = new List<int> { 1, 2, 3, 4 }, Sequence = new List<int> { 1, 3 } },
            new ValidateSubsequenceInputSet { NumbersList = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, Sequence = new List<int> { 1, 6, -1, 10 } },
            new ValidateSubsequenceInputSet { NumbersList = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, Sequence = new List<int> { 5, 1, 22, 22, 6, -1, 8, 10 } },
            new ValidateSubsequenceInputSet { NumbersList = null, Sequence = new List<int> { 1, 2, 3 } }, // Test case with null NumbersList
            new ValidateSubsequenceInputSet { NumbersList = new List<int> { 1, 2, 3, 4 }, Sequence = null }, // Test case with null Sequence
        };
}