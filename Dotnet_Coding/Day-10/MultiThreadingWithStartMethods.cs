using System;
using System.Threading;

class Test4{
    static void Add(){
        for(int i=0;i<5;i++){
            if(i==3){
                Thread.Sleep(1000);
                Console.WriteLine("hi");
            }
        }
    }
    static void Main(){
        Thread t=new Thread(Add);
        t.start();
    }
}