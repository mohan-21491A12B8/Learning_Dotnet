using System;
using System.IO;
class Temp5{
    static void Main(){
        // string source="C:\\Users\\dell\\Desktop\\mohansai";
        string dest="C:\\Users\\dell\\Desktop\\mohans.txt";
        if(File.Exists(dest)){
            File.Delete(dest);
            Console.WriteLine("done sucess");
        }
        else{
            Console.WriteLine("File not existed");
        }
    }
}