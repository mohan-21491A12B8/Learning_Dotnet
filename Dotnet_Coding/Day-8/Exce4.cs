using System;

class Exec4
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter the type name:");
            string typeName = Console.ReadLine(); // Corrected variable name

            // Use Type.GetType() instead of typeof.GetType()
            Type t = Type.GetType(typeName);
            if (t == null)
            {
                throw new TypeLoadException("Class not found"); // Added missing semicolon and corrected message
            }
            Console.WriteLine("Class found: " + t.FullName); // Display the full name of the found type
        }
        catch (TypeLoadException e)
        {
            Console.WriteLine(e.Message); // Corrected 'message' to 'Message'
        }
        catch (Exception e) // Catch any other exceptions
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}