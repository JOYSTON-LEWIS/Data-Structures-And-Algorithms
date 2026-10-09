
// Fibonacci sequence
// Each number is the sum of the previous two numbers.
// Logic: Update the two previous numbers in every iteration.

using System;
using System.Collections.Generic;

class Program
{
    static List<int> Fibonacci(int n)
    {
        List<int> result = new List<int>();

        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            result.Add(a);

            int next = a + b;
            a = b;
            b = next;
        }

        return result;
    }

    static void Main()
    {
        List<int> result = Fibonacci(7);

        Console.WriteLine("[" + string.Join(", ", result) + "]");
    }
}

// Fibonacci(7) => [0, 1, 1, 2, 3, 5, 8]