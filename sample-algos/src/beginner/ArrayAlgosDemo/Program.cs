using ArrayAlgosDemo;

TwoNumbersSum.ShowDemo();

var results = IsValidSubsequence(new List<int> { 1, 2, 3, 4 }, new List<int> { 1, 3 });
WriteLine(results);

static bool IsValidSubsequence(List<int> inputNumbers, List<int> sequence)
{
    foreach (var item in sequence)
    {
        if (!inputNumbers.Contains(item))
        {
            return false;
        }
    }

    return true;
}
