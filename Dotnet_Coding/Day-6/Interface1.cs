using System;
interface i1{
    void Add();
}
interface i2{
    void Show();
}

class Interface1:i1,i2{
    public void Add(){
        Console.WriteLine("Add");
    }
    public void Show(){
        Console.WriteLine("Show");
    }
    static void Main(string[] args){
        Interface1 i=new Interface1();
        i.Add();
        i.Show();

    }
}