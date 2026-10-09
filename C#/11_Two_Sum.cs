
// Two Sum
// Find the indices of two numbers that add up to a target.
// Logic: For each number, check whether its required complement has already been seen.

using System;
using System.Collections.Generic;

class Program
{
    static int[] TwoSum(int[] arr, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];

            if (map.TryGetValue(
                complement, out int index))
            {
                return new[] { index, i };
            }

            map[arr[i]] = i;
        }

        return Array.Empty<int>();
    }

    static void Main()
    {
        int[] result = TwoSum(new[] { 2, 7, 11, 15 }, 9);

        Console.WriteLine("[" + string.Join(", ", result) + "]");
    }
}

// TwoSum(new[] { 2, 7, 11, 15 }, 9) => [0, 1]