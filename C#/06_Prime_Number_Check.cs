
// Prime number check
// A prime number is greater than 1 and has exactly two positive divisors: 1 and itself.
// Logic: Check divisors only up to the square root of n.

using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= n / i; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine(IsPrime(7));  // True
        Console.WriteLine(IsPrime(10)); // False
    }
}

// IsPrime(7)  => true
// IsPrime(10) => false