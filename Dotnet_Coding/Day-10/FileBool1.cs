using System;
using System.IO;
class Temp5{
    static void Main(){
        string path = @"C:\\Users\\dell\\Desktop\\sais";
        using(StreamWriter w1=new StreamWriter(path,true))
        {
            w1.WriteLine("I want to append the text");
        }
        Console.WriteLine("sucess");
    }
}