using System;
using System.IO;
class Temp5{
    public static void Main(){
        string path = "C:\\Users\\dell\\Desktop\\sai";

        using(StreamReader w1=new StreamReader(path)){
            string line;
            while ((line = w1.ReadLine()) != null){
                Console.WriteLine(line);
            }
        }
        Console.WriteLine("file created and text copied sucessfully");
    }
}