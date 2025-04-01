using System;
class Cse2{
    public delegate void Show(string str);
    static void Main(string[] args){
        string s3="ram";
        Show s1=delegate(string s2){
            Console.WriteLine(s2);
        };
        s1("mohan");
    }

}