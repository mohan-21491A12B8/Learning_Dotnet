using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
class Temp{
    static void Main(){
        ConcurrentQueue<int> c1=new ConcurrentQueue<int>();
        Parallel.For(0,10,i=>{
            c1.Enqueue(i);
            Console.WriteLine(i);
        });
        Console.WriteLine("dequeue elements");
        while(c1.TryDequeue(out int result)){
            Console.WriteLine(result);
        }
    }
}

