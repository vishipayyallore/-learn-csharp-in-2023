// See https://aka.ms/new-console-template for more information
using System.Collections;

int[] outputArray = TwoNumberSum(new int[] { 3, 5, -4, 8, 11, 1, -1, 6 }, 10);

string[] strArray = Array.ConvertAll(outputArray, ele => ele.ToString());
WriteLine($"[{string.Join(", ", strArray)}]");


static int[] TwoNumberSum(int[] array, int targetSum)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            WriteLine($"{i + 1}. {array[i]} + {array[j]}");

            if ((array[i] + array[j]) == targetSum)
            {
                return new[] { array[i], array[j] };
            }
        }
    }

    // Write your code here.
    return Array.Empty<int>();
}