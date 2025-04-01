//we are doing delegate to a static method
using System;
public class c1{
    public delegate void display(string s1);
}
class c2{
    public static void show(c1.display x,string name)
    {
        x(name);
    }
    static void Main(string[] args){
        show(delegate(string name){
            Console.WriteLine(name);
        },"Mohan");
    }
}