
// Find the missing number
// Assumption: The array contains distinct numbers from 1 to n, with exactly one missing.
// Logic: Expected sum minus actual sum gives the missing number.
// Assumes the array contains numbers from 1 to n, with exactly one missing.

using System;
class Program
{
    static int MissingNumber(int[] arr, int n)
    {
        long expected = (long)n * (n + 1) / 2;
        long actual = 0;

        foreach (int num in arr)
        {
            actual += num;
        }

        return (int)(expected - actual);
    }

    static void Main()
    {
        Console.WriteLine(MissingNumber(new[] { 1, 2, 4, 5 }, 5)); // 3
    }
}

// MissingNumber(new[] { 1, 2, 4, 5 }, 5) => 3