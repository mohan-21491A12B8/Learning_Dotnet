using System;

namespace Variables
{
    class Variables
    {
        int x = 10, y = 12; // instance variables
        static int p = 33, q = 44; // static variables
        const int a = 13; // constant
        readonly int b = 9; // readonly variable

        void add()
        {
            int i = 1; // local variable
            Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            Variables v = new Variables(); // Create an instance of Variables
            Console.WriteLine(v.x + v.y); // Access instance variables
            Console.WriteLine(p - q); // Access static variables
            Console.WriteLine(a); // Access constant
            Console.WriteLine(v.b); // Access readonly variable through instance
            
            v.add(); // Call the add method on the instance
        }
    }
}