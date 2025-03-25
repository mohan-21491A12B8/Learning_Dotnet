using System;

public class VariableOperations
{
    // Declare three variables
    int normalVariable = 10;       // Normal variable
    int _underscoreVariable = 20;  // Variable with underscore
    int @atSymbolVariable = 30;    // Variable with @ symbol

    // Method to add the three variables
    public int Add()
    {
        return normalVariable + _underscoreVariable + @atSymbolVariable;
    }

    // Method to subtract the three variables
    public int Subtract()
    {
        return normalVariable - _underscoreVariable - @atSymbolVariable;
    }

    // Method to multiply the three variables
    public int Multiply()
    {
        return normalVariable * _underscoreVariable * @atSymbolVariable;
    }

    // Method to divide the three variables
    public double Divide()
    {
        // To avoid division by zero, check if the denominator is not zero
        if (_underscoreVariable != 0 && @atSymbolVariable != 0)
        {
            return (double)normalVariable / _underscoreVariable / @atSymbolVariable;
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
            return 0;
        }
    }

    public static void Main(string[] args)
    {
        VariableOperations operations = new VariableOperations(); // Create an instance of the class

        // Call the methods and display the results
        Console.WriteLine("Addition: " + operations.Add());
        Console.WriteLine("Subtraction: " + operations.Subtract());
        Console.WriteLine("Multiplication: " + operations.Multiply());
        Console.WriteLine("Division: " + operations.Divide());
    }
}