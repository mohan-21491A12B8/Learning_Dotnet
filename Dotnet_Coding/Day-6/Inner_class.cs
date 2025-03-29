using System;
public class Sample45{
    public void show(){
        Console.WriteLine("Hello, World!,this is outer class");
    }

    public class Sample46{
        public void display(){
            Console.WriteLine("Welcome to inner class");
        }
    }
}
class Innner_classs{
    static void Main(string[] args){
        
        Sample45.Sample46 v = new Sample45.Sample46();
        v.display();

        Sample45 v2=new Sample45();
        v2.show();
    }
}