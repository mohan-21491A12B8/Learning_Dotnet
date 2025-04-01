using System;
class c1{
    static void Main(string[] args){
        try{
          int a=10;
          int b=0;
          Console.WriteLine(a/b);
        }
        catch(Exception e){
            Console.WriteLine(e.ToString());
            Console.WriteLine(e.StackTrace);
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("hii");
    }
}