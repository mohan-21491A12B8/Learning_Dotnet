using System;
class Exe1{
    public delegate void show(string message);
    static void Main(){
        show s1=x=>Console.WriteLine(x);
        s1("hai");
    }
}