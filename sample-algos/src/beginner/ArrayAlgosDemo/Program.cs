using ArrayAlgosDemo;

// TwoNumbersSum.ShowDemo();

// var results = IsValidSubsequence(new List<int> { 1, 2, 3, 4 }, new List<int> { 1, 3 });
// var results = IsValidSubsequence(new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 1, 6, -1, 10 });
var results = IsValidSubsequence(new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 }, new List<int> { 5, 1, 22, 22, 6, -1, 8, 10 });
WriteLine(results);

static bool IsValidSubsequence(List<int> array, List<int> sequence)
{
    if (sequence.Count > array.Count || (sequence.Count != sequence.ToHashSet().Count && sequence.ToHashSet().Count != 1))
    {
        return false;
    }

    var currentIndex = 0;
    foreach (var item in sequence)
    {
        var index = array.IndexOf(item);
        if (index == -1 || index < currentIndex)
        {
            return false;
        }
        currentIndex = index;
    }

    return true;
}
