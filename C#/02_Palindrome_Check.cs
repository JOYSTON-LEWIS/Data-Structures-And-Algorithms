
// Palindrome check
// A palindrome reads the same forward and backward.
// Logic: Compare characters at opposite ends, moving toward the middle.

using System;

class Program
{
    static bool IsPalindrome(string str)
    {
        str = str.ToLowerInvariant();

        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
                return false;

            left++;
            right--;
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine(IsPalindrome("Madam")); // True
        Console.WriteLine(IsPalindrome("Hello")); // False
    }
}

// IsPalindrome("Madam") => true
// IsPalindrome("Hello") => false