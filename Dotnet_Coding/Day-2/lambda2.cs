using System;

public class Greeting
{
    public static void Main(string[] args)
    {
        Action<string> greet = name => Console.WriteLine($"Hello, {name}!");
        greet("Mohan"); // Output: Hello, Alice!
    }
}