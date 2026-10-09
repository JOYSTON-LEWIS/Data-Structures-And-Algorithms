
// FizzBuzz
// Print Fizz for multiples of 3, Buzz for multiples of 5, and FizzBuzz for multiples of both.
// Important: Check divisibility by both numbers first.

using System;

class Program
{
    static void FizzBuzz(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            if (i % 15 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }

    static void Main()
    {
        FizzBuzz(15);
    }
}