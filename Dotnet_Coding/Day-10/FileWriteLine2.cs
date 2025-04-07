using System;
using System.IO;
class Temp5{
    public static void Main(){
        try{
        string path = "C:\\Users\\dell\\Desktop\\sai";

        using(StreamWriter w1=new StreamWriter(path)){
            w1.WriteLine("Hello, Mohan!");
        }
        Console.WriteLine("file created and text copied sucessfully");
        }catch{
            Console.WriteLine("file not created");
        }
    }
}