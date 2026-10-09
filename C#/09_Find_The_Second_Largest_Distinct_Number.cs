
// Find the second-largest distinct number
// Logic: Maintain the largest and second-largest distinct values in one pass.
// The return type int? allows the method to return null when a second distinct value does not exist.

using System;

class Program
{
    static int? SecondLargest(int[] arr)
    {
        int largest = int.MinValue;
        int second = int.MinValue;

        bool hasLargest = false;
        bool hasSecond = false;

        foreach (int num in arr)
        {
            if (!hasLargest || num > largest)
            {
                second = largest;
                hasSecond = hasLargest;

                largest = num;
                hasLargest = true;
            }
            else if (num < largest &&
                     (!hasSecond || num > second))
            {
                second = num;
                hasSecond = true;
            }
        }

        return hasSecond ? second : (int?)null;
    }

    static void Main()
    {
        Console.WriteLine(SecondLargest(new[] { 10, 5, 20, 8 })); // 10

        int? result = SecondLargest(new[] { 5, 5 });
        Console.WriteLine(result.HasValue ? result.ToString() : "null"); // null
    }
}

// SecondLargest(new[] { 10, 5, 20, 8 }) => 10
// SecondLargest(new[] { 5, 5 })         => null