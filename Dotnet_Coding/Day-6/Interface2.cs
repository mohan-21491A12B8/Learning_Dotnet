using System;
interface i1{
    void m1();
}

interface i2{
    void m2();
}

interface i3{
    void m3();
}

interface i4{
    void m4();
}

class Mohan:i1,i2{
    public void m1(){
        Console.WriteLine("First interface");
    }
    public void m2(){
        Console.WriteLine("Second interface");
    }
}
    class Interface2:Mohan,i4{

        
    public void m3(){
        Console.WriteLine("Third interface");
    }

    public void m4(){
        Console.WriteLine("Fourth interface");
    }
    public void show(){
        Console.WriteLine("inherits class1 and i4");
    }

    static void Main(string[] args){
        Interface2 obj = new Interface2();
        obj.m1();
        obj.m2();
        obj.m3();
        obj.m4();
        obj.show();
    }

}