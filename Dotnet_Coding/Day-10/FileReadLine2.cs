using System;
using System.IO;
class Temp6{
    static void Main(){
        string path1="C:\\Users\\dell\\Desktop\\mohansai";
        string path2="C:\\Users\\dell\\Desktop\\mohans";
        using(StreamReader w1=new StreamReader(path1))
        using(StreamReader w2=new StreamReader(path2)){
            string line1,line2;
            while((line1=w1.ReadLine()) !=null && (line2=w2.ReadLine()) !=null){
                Console.WriteLine("hi");
                Console.WriteLine("welcome");
            }
        }Console.WriteLine("execution completed");
    }
}