// Reverse a string
// Reverse the characters in a string without using the built-in reverse() method.
// Logic: Start at the last character and move backward.
// Alternative: new string(str.Reverse().ToArray()) using LINQ.

using System;

public class Program
{
    static string ReverseString(string str)
    {
        string result = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            result += str[i];
        }

        return result;
    }

    public static void Main()
    {
        Console.WriteLine(ReverseString("hello"));
        // olleh
    }
}
