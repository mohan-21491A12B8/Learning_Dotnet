using System;

class Test31
{
    private string name;
    private int marks;

    // Parameterized Constructor
    public Test31(string name, int marks)
    {
        this.name = name;
        this.marks = marks;
    }

    // Copy Constructor
    public Test31(Test31 t)
    {
        name = t.name;
        marks = t.marks;
    }

    // Display Property
    public string Display
    {
        get
        {
            return "My name is " + name + " and my marks are " + marks.ToString();
        }
    }

    static void Main(string[] args)
    {
        Test31 t2 = new Test31("Ram", 89);
        Test31 t3 = new Test31(t2);
        Console.WriteLine(t3.Display);
    }
}
