
 // Anagram check
// Two strings are anagrams if they contain the same characters with the same frequencies.
// Logic: Count each character in the first string, then subtract counts using the second.

using System;
using System.Collections.Generic;

class Program
{
    static bool IsAnagram(string str1, string str2)
    {
        str1 = str1.ToLowerInvariant()
                   .Replace(" ", "");

        str2 = str2.ToLowerInvariant()
                   .Replace(" ", "");

        if (str1.Length != str2.Length)
            return false;

        Dictionary<char, int> frequency = new Dictionary<char, int>();

        foreach (char c in str1)
        {
            if (!frequency.ContainsKey(c))
                frequency[c] = 0;

            frequency[c]++;
        }

        foreach (char c in str2)
        {
            if (!frequency.ContainsKey(c) ||
                frequency[c] == 0)
                return false;

            frequency[c]--;
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine(IsAnagram("listen", "silent")); // true
        Console.WriteLine(IsAnagram("hello", "world"));   // false
        Console.WriteLine(IsAnagram("Dormitory", "Dirty room")); // true
    }
}

// IsAnagram("listen", "silent") => true