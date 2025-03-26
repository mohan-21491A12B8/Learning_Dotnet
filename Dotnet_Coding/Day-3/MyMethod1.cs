using System;
class MyMethod1{
    static void MyMethod(string child1,string child2,string child3){
        Console.WriteLine("the youngest child is: "+child3);
    }
    static void Main(string[] args){
        MyMethod(child1: "John",child2: "Mary",child3: "David");
    }
}