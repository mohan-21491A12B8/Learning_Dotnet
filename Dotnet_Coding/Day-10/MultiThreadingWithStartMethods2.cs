using System;
using System.Threading;

class Test4{
    static void Sum(){
        for(int i=0;i<5;i++){
            if(i==3){
                Thread.Sleep(1000);
                Console.WriteLine("welcome");
            }
        }
    }
    static void Add(){
        for(int i=0;i<5;i++){
            Console.WriteLine("hi");
        }
    }

static void Main(){
        Thread t=new Thread(Sum);
        Thread t1=new Thread(Add);
        t.Start();
        t1.Start();
        t1.Join();
}
} 