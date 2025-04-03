//how to handle multiple exceptions in single catch
using System;
class Exec1{
    static void Main(){
        try{
            Console.WriteLine("Enter a number: ");
            int  num=int.Parse(Console.ReadLine());
            int c=10/num;
            Console.WriteLine(c);
        }
        catch(Exception e){
            if(e is FormatException||e is DivideByzeroException){
                Console.WriteLine(e.Message);
            }else{
                throw;
            }
        }
    }
}