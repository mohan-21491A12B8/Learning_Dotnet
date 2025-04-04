using System;
using System.Collections;

class ClsHashtable
{
    static void Main()
    {
        Hashtable hashtable = new Hashtable(); // Create a new Hashtable
        hashtable.Add("Apple", 1); // Add key-value pairs to the Hashtable
        hashtable.Add("Banana", 2);
        hashtable.Add("Cherry", 3);
        hashtable.Add("Diamond", 4);

        Display(hashtable); // Display the contents of the Hashtable

        Console.WriteLine("Value for Banana is: " + hashtable["Banana"]); // Access the value for the key "Banana"
        hashtable.Remove("Cherry"); // Remove the key-value pair with key "Cherry"
        Display(hashtable); // Display the contents of the Hashtable after removal

        Console.WriteLine("Contains 'Apple'? " + hashtable.ContainsKey("Apple")); // Check if "Apple" is a key
        Console.WriteLine("Contains 'Cherry'? " + hashtable.ContainsKey("Cherry")); // Check if "Cherry" is a key

        Console.WriteLine("Iterating through hashtable:");
        foreach (DictionaryEntry entry in hashtable) // Iterate through the Hashtable
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}"); // Print each key-value pair
        }
        Console.WriteLine();
    }

    static void Display(Hashtable hashtable)
    {
        Console.WriteLine("Hashtable contents are: ");
        foreach (DictionaryEntry entry in hashtable) // Iterate through the Hashtable
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}"); // Print each key-value pair
        }
        Console.WriteLine();
    }
}