using ArrayAlgosDemo.Common;

namespace ArrayAlgosDemo;

public static class TwoNumbersSum
{
    public static void ShowDemo()
    {
        ForegroundColor = ConsoleColor.DarkCyan;
        WriteLine("***** Two Numbers Sum *****");

        int[] outputArray = TwoNumberSum(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10);

        WriteLine($"Output: [{string.Join(", ", Helpers.ConvertIntToStringArray(outputArray))}]");

        WriteLine("----- Two Numbers Sum -----");
        ResetColor();
    }

    private static int[] TwoNumberSum(int[] inputNumbers, int sumToMatch)
    {
        WriteLine($"Input Array: [{string.Join(", ", Helpers.ConvertIntToStringArray(inputNumbers))}]");
        WriteLine($"Sum to Match: {sumToMatch}");

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
}
