//ananamous method means we don't know the method for which we create an object
using System;
class c1{
    public delegate void show(string str);
    public delegate void show1(string str);
    static void Main(string[] args){
        string s3="information technology";
        show s1=delegate(string s4){
            Console.WriteLine(s4);
            Console.WriteLine(s3);
        };
        s1("mohan");
        show1 s2=delegate(string s5){
            Console.WriteLine(s5);
            Console.WriteLine(s3);
        };
        s2("sai");
    }
}