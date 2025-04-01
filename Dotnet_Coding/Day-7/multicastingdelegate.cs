//in multicasting we are creating one object and accessing the two methods
// we do multi casting when the both methods have same return type and same no.of parameters with same data type.
using System;
class c1{
    public delegate void show(int a,int b);
     public void add(int a,int b){
        Console.WriteLine(a+b);
    }
    public void sub(int a,int b){
        Console.WriteLine(a-b);
    }
    static void Main(string[] args){
        c1 c= new c1();
        show a1=new show(c.add);
        a1+=c.sub;//here were telling for the compiler that access the method in the class.so like this we can access every methods in class
        a1.Invoke(23,12);//this statement is used to access the both methods in the class
        a1.Invoke(23,32);   
    } 
}