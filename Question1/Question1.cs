// Test inputs used for the sample output:
// 1) 3   -> Wednesday
// 2) 9   -> Invalid number (outside 1-7)
// 3) abc -> Invalid number (not an integer)
// BEFORE SUBMISSION: Replace YOUR_CLASS_ID with your actual ClassID.
using System;

class Program
{
    static void Main()
    {
        

        Console.Write("Enter a day number (1-7): ");
        string input = Console.ReadLine() ?? string.Empty;

        // TryParse rejects text that is not an integer.
        if (!int.TryParse(input, out int day))
        {
            Console.WriteLine("Invalid number");
            return;
        }

        // The default branch handles values outside 1-7.
        switch (day)
        {
            case 1: Console.WriteLine("Day: Monday"); break;
            case 2: Console.WriteLine("Day: Tuesday"); break;
            case 3: Console.WriteLine("Day: Wednesday"); break;
            case 4: Console.WriteLine("Day: Thursday"); break;
            case 5: Console.WriteLine("Day: Friday"); break;
            case 6: Console.WriteLine("Day: Saturday"); break;
            case 7: Console.WriteLine("Day: Sunday"); break;
            default: Console.WriteLine("Invalid number"); break;
        }
    }
}
