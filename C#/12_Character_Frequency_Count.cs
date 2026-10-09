
// Character frequency count

using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<char, int> CharacterFrequency(
        string str)
    {
        Dictionary<char, int> frequency = new Dictionary<char, int>();

        foreach (char c in str)
        {
            if (!frequency.ContainsKey(c))
                frequency[c] = 0;

            frequency[c]++;
        }

        return frequency;
    }

    static void Main()
    {
        Dictionary<char, int> result = CharacterFrequency("hello");

        foreach (KeyValuePair<char, int> item in result)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}

// CharacterFrequency("hello")
// => h:1, e:1, l:2, o:1