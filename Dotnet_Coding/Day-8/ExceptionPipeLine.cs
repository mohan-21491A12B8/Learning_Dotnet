//how to handle multiple exceptions in single catch
using System;

class Exec1
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int c = 10 / num;
            Console.WriteLine("Result: " + c);
        }
        catch (Exception e) when (e is FormatException || e is DivideByZeroException)
        {
            Console.WriteLine("Error: " + e.Message);
        }
        catch (Exception e)
        {
            throw; // Re-throw for unexpected exceptions
        }
    }
}
