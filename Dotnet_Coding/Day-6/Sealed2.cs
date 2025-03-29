using System;
public sealed class Sealed{
    public int value{get;set;}

    public void display() {
        Console.WriteLine($"value is: {value}");
    }
}
public class SampleTester{
    public void show(){
        Sealed sealedObject = new Sealed();
        sealedObject.value=100;
        sealedObject.display();

    }
}

class Program{
    public static void Main(string[] args) {
        SampleTester user=new SampleTester();
        user.show();   
    }    
}