using System;
using System.IO;
public static void Main(){
    try{
        string dest="C:\\Users\\dell\\Desktop\\sai.txt";
        string[] lines=File.ReadAllLines(dest);
        foreach (string l1 in lines)
        {
            Console.WriteLine(l1);
        }
    }
    catch(Exception e){
        Console.WriteLine("Error: "+e.Message);
    }
}