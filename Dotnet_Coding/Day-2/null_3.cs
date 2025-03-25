using System;
class null_3{
    public static void Main(string[] args){
        int? a=null;
        int c=7;
        int b=5;
        int result=a??c;
        Console.WriteLine("Result:"+result);//to see result use concatenate operator 
        Console.WriteLine("Result:",result);//shows output but does not give value
    }
}