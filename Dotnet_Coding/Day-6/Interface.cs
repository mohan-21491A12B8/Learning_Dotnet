using System;
interface i1{
    void Add();
    void Show();
}
class Qis1:i1{
    public void Add(){
        Console.WriteLine("hi");
    }
    public void Show(){
        Console.WriteLine("welcome");
    }
    static void Main(string[] args){
        Qis1 q=new Qis1();
        q.Add();
        q.Show();
    }
    
}