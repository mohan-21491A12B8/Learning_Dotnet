using System;

public class RightAngleTrianglePattern
{
    public static void Main(string[] args)
    {
        int height = 5; // You can change this value to increase or decrease the height of the triangle

        for (int i = 1; i <= height; i++) // Outer loop for each row
        {
            for (int j = 1; j <= i; j++) // Inner loop for printing stars
            {
                Console.Write("* "); // Print a star followed by a space
            }
            Console.WriteLine(); // Move to the next line after each row
        }
    }
}