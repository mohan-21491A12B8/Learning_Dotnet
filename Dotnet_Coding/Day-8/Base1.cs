using System;
class Sample2{
    public int a=90;
    public Sample2(){
        Console.WriteLine("hi");
    }
    public void show(){
        Console.WriteLine("hello");

    }
}
class Exec3:Sample2{
    public Exec3():base(){
        Console.WriteLine("this is child");
    }

    public void Display(){
        base.show();
        Console.WriteLine(base.a);
        Console.WriteLine("child method");
    }
    static void Main(){
        Exec3 e1=new Exec3();
        e1.Display();
    }
}