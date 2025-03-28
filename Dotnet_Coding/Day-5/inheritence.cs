using System;
class Test{
    public void Display(){
        Console.WriteLine("hai");
    }
}
class Test37:Test{
    public void Add(){
        Console.WriteLine("Welcome");
    }

    static void Main(string[] args){
        Test37 t=new Test37();
        t.Add();
        t.Display();
}
}