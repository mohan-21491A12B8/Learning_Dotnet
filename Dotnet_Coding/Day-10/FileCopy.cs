using System;
using System.IO;
class Temp5{
    static void Main(){
        string source="C:\\Users\\dell\\Desktop\\mohansai";
        string dest="C:\\Users\\dell\\Desktop\\mohans";
        File.Copy(source,dest);
        Console.WriteLine("Sucess");
    }
}