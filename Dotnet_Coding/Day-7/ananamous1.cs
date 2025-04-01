using System;
class c1{
    public delegate void show(string str);
    static void Main(string[] args){
        string s3="information technology";
        show s1=delegate(string s4){
            Console.WriteLine(s4);
            Console.WriteLine(s3);
        };
        s1("Mohan");
    }
}