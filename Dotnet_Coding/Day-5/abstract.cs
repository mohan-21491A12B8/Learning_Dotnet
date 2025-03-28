using System;

abstract class Mohan
{
    public abstract void Display();
}

class Test37 : Mohan
{
    public override void Display()
    {
        Console.WriteLine("hai");
    }

    public void Add()
    {
        Console.WriteLine("hello");
    }

    static void Main(string[] args)
    {
        Test37 t = new Test37();
        t.Add();
        t.Display();
    }
}
