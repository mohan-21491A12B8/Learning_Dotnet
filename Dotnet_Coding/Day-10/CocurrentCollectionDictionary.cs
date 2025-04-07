using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

class Temp
{
    static void Main()
    {
        // Create a ConcurrentDictionary
        ConcurrentDictionary<int, string> dictionary = new ConcurrentDictionary<int, string>();

        // Parallel add/update entries
        Parallel.For(0, 10, i =>
        {
            // Add a key-value pair
            bool added = dictionary.TryAdd(i, $"Value {i}");

            // If already exists, update the value
            if (!added)
            {
                dictionary[i] = $"Updated Value {i}";
            }

            Console.WriteLine($"Thread {Task.CurrentId}: Key = {i}, Value = {dictionary[i]}");
        });

        Console.WriteLine("\nContents of ConcurrentDictionary:");
        foreach (var pair in dictionary)
        {
            Console.WriteLine($"Key = {pair.Key}, Value = {pair.Value}");
        }
    }
}
