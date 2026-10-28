// Test inputs used for the sample output:
// 1) 12, 5, + -> Result: 17
// 2) 12, 0, / -> Cannot divide by zero.
// 3) 10, 4, / -> Result: 2.5
// BEFORE SUBMISSION: Replace YOUR_CLASS_ID with your actual ClassID.
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        

        Console.Write("Enter the first number: ");
        string firstInput = Console.ReadLine() ?? string.Empty;
        if (!double.TryParse(firstInput, NumberStyles.Float, CultureInfo.InvariantCulture, out double firstNumber))
        {
            Console.WriteLine("Invalid number");
            return;
        }

        Console.Write("Enter the second number: ");
        string secondInput = Console.ReadLine() ?? string.Empty;
        if (!double.TryParse(secondInput, NumberStyles.Float, CultureInfo.InvariantCulture, out double secondNumber))
        {
            Console.WriteLine("Invalid number");
            return;
        }

        Console.Write("Enter operator (+, -, *, /): ");
        string operatorInput = Console.ReadLine() ?? string.Empty;
        if (operatorInput.Length != 1)
        {
            Console.WriteLine("Invalid operator");
            return;
        }

        char operation = operatorInput[0];
        double result;

        switch (operation)
        {
            case '+': result = firstNumber + secondNumber; break;
            case '-': result = firstNumber - secondNumber; break;
            case '*': result = firstNumber * secondNumber; break;
            case '/':
                if (secondNumber == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return;
                }
                result = firstNumber / secondNumber;
                break;
            default:
                Console.WriteLine("Invalid operator");
                return;
        }

        Console.WriteLine("Result: " + result.ToString("G", CultureInfo.InvariantCulture));
    }
}
