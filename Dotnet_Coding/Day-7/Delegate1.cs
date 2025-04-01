using System;
class Cse1{
    public delegate void addnum(int a,int b);
    

    public void Add(int a,int b){
        Console.WriteLine("Addition of two numbers is : "+(a+b));
    }

    public void Sub(int a,int b){
        Console.WriteLine("Subtraction of two numbers is : "+(a-b));
    }

    static void Main(string[] args){
        Cse1 c1=new Cse1();
        addnum a1=new addnum(c1.Add);
        a1+=c1.Sub;
        a1.Invoke(10,20);
        a1.Invoke(10,5);
    }
}