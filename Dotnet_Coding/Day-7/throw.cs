using System;
class c1{
    static void Main(string[] args){
        try{
          int a=10;
          Console.WriteLine("enter b value");
          int b=Convert.ToInt32(Console.ReadLine());
          if(b<0){
            throw new Exception("you should enter the non negative number");
          }
          Console.WriteLine(a/b);
        }
        catch(DivideByZeroException e){           
            Console.WriteLine(e.StackTrace);            
        }
        catch(FormatException e){
            Console.WriteLine(e.StackTrace);
        }
        catch(Exception e){
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("hii");
    }
}