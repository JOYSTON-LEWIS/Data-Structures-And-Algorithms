
// Find duplicates in an array
// Logic: Use one set to track numbers seen and another to store duplicates.
// HashSet<T>.Add() returns false if the element already exists.

using System;
using System.Collections.Generic;

class Program
{
    static List<int> FindDuplicates(int[] arr)
    {
        HashSet<int> seen = new HashSet<int>();
        HashSet<int> duplicates = new HashSet<int>();

        foreach (int num in arr)
        {
            if (!seen.Add(num))
            {
                duplicates.Add(num);
            }
        }

        return new List<int>(duplicates);
    }

    static void Main()
    {
        List<int> result = FindDuplicates(new[] { 1, 2, 3, 2, 4, 1 });

        Console.WriteLine("[" + string.Join(", ", result) + "]");
    }
}

// FindDuplicates(new[] { 1, 2, 3, 2, 4, 1 })
// => [2, 1]