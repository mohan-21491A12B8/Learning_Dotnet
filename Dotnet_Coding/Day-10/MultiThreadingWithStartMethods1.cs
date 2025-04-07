using System;
using System.Threading;

class Test4{
    static void Add(){
        for(int i=0;i<5;i++){
            Console.WriteLine("hi");
        }
    }

static void Main(){
        Thread t=new Thread(Add);
        Thread t1=new Thread(Add);
        t1.Start();
        t1.Join();
}
} 