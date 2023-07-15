// See https://aka.ms/new-console-template for more information


ShowTwoNumberSumDemo();

static void ShowTwoNumberSumDemo()
{
    ForegroundColor = ConsoleColor.DarkCyan;
    int[] outputArray = TwoNumberSum(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10);
    string[] strArray = Array.ConvertAll(outputArray, ele => ele.ToString());
    WriteLine($"[{string.Join(", ", strArray)}]");

    ResetColor();
}

static int[] TwoNumberSum(int[] inputNumbers, int sumToMatch)
{
    for (int i = 0; i < inputNumbers.Length - 1; i++)
    {
        for (int j = i + 1; j < inputNumbers.Length; j++)
        {
            // Uncomment this line for Debugging
            // WriteLine($"{i + 1}. {inputNumbers[i]} + {inputNumbers[j]}");

            if ((inputNumbers[i] + inputNumbers[j]) == sumToMatch)
            {
                return new[] { inputNumbers[i], inputNumbers[j] };
            }
        }
    }

    return Array.Empty<int>();
}