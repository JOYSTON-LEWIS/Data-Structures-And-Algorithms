
// Word frequency count
// Logic: Normalize the text, split it into words, and count each occurrence.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static Dictionary<string, int> WordFrequency(
        string sentence)
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();

        string[] words = Regex
            .Matches(sentence.ToLowerInvariant(),
                     @"\b[\w']+\b")
            .Cast<Match>()
            .Select(m => m.Value)
            .ToArray();

        foreach (string word in words)
        {
            if (!frequency.ContainsKey(word))
                frequency[word] = 0;

            frequency[word]++;
        }

        return frequency;
    }

    static void Main()
    {
        Dictionary<string, int> result =
            WordFrequency("Hello world hello C# world");

        foreach (KeyValuePair<string, int> item in result)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}