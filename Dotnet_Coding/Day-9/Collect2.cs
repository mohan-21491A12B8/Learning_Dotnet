using System;
using System.Collections.Generic;

class Collect1
{
    public static void Main()
    {
        LinkedList<int> l1 = new LinkedList<int>(); // Create a new LinkedList of integers
        l1.AddLast(10); // Add elements to the LinkedList
        l1.AddLast(20);
        l1.AddLast(30);
        l1.AddLast(40);
        l1.AddLast(50);
        l1.AddLast(60);
        l1.AddFirst(1); // Add an element at the beginning
        l1.Remove(40); // Remove the element with value 40
        Display(l1); // Call the Display method to print the list
        Console.WriteLine(Search(l1, 60)); // Search for the value 60 and print the result
    }

    static bool Search(LinkedList<int> list, int value)
    {
        return list.Contains(value); // Check if the list contains the specified value
    }

    static void Display(LinkedList<int> list) // Corrected method signature to include the parameter
    {
        foreach (int a in list) // Iterate through the LinkedList
        {
            Console.Write(a + "->"); // Print each element followed by an arrow
        }
        Console.WriteLine(); // Print a new line after displaying the list
    }
}