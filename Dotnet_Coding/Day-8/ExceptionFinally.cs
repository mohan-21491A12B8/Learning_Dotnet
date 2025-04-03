using System;

class TryFinallyExample
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine()); // May throw FormatException
            int result = 10 / num; // May throw DivideByZeroException
            Console.WriteLine("Result: " + result);
        }
        finally
        {
            Console.WriteLine("Finally block executed. Cleaning up resources...");
        }
    }
}
