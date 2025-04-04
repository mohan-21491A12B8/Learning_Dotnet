using System;
using System.Collections.Generic;
class Collect1{
    public static void Main(){
        LinkedList<int> l1=new LinkedList<int>();
        l1.AddLast(10);
        l1.AddLast(20);
        l1.AddLast(30);
        l1.AddLast(40);
        l1.AddLast(50);
        l1.AddLast(60);
        foreach(int a in l1){
            Console.Write(a+"->");
        }
    }
}
