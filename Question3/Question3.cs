// Test inputs used for the sample output:
// 1) 2024 -> Leap year
// 2) 1900 -> Not a leap year (divisible by 100, not 400)
// 3) 2000 -> Leap year (divisible by 400)
// BEFORE SUBMISSION: Replace YOUR_CLASS_ID with your actual ClassID.
using System;

class Program
{
    static void Main()
    {
        

        Console.Write("Enter a year: ");
        string input = Console.ReadLine() ?? string.Empty;

        if (!int.TryParse(input, out int year) || year <= 0)
        {
            Console.WriteLine("Invalid year");
            return;
        }

        // Apply the 400-year exception before the 100-year rule.
        if (year % 400 == 0)
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else if (year % 100 == 0)
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
        else if (year % 4 == 0)
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
    }
}
