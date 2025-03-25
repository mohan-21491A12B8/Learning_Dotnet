using System;
class null1_double{
    public static void Main(string[] args) {
        int? a=null;
        int b=21;
        int result =a ?? b;
        Console.WriteLine("Result:",result);
    }
}