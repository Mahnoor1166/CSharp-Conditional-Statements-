// Test inputs used for the sample output:
// 1) 6500 -> 20% discount
// 2) 3500 -> 10% discount
// 3) 1999 -> no discount
// BEFORE SUBMISSION: Replace YOUR_CLASS_ID with your actual ClassID.
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
       

        Console.Write("Enter purchase amount: ");
        string input = Console.ReadLine() ?? string.Empty;

        // Reject non-numeric and negative purchase amounts.
        if (!decimal.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal amount) || amount < 0)
        {
            Console.WriteLine("Invalid amount");
            return;
        }

        decimal discountRate;
        if (amount >= 5000m)
        {
            discountRate = 0.20m;
        }
        else if (amount >= 2000m)
        {
            discountRate = 0.10m;
        }
        else
        {
            discountRate = 0m;
        }

        decimal discountAmount = amount * discountRate;
        decimal finalAmount = amount - discountAmount;

        Console.WriteLine($"Discount percentage: {discountRate * 100m:0}%");
        Console.WriteLine($"Discount amount: {discountAmount:0.00}");
        Console.WriteLine($"Final payable amount: {finalAmount:0.00}");
    }
}
