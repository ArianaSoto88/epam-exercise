using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(IsPalindrome(12341)); // false
        Console.WriteLine(IsPalindrome(12321)); // true
        Console.WriteLine(IsPalindrome(11));    // true
        Console.WriteLine(IsPalindrome(889));   // false
        Console.WriteLine(IsPalindrome(888));   // true
    }

    static bool IsPalindrome(int number)
    {
        int original = number;
        int reversed = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }

        return original == reversed;
    }
}