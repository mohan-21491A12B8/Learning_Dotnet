using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
class Temp{
    static void Main(){
        ConcurrentStack<int> c1=new ConcurrentStack<int>();
        Parallel.For(0,10,i=>{
            c1.Push(i);
            Console.WriteLine(i);
        });
        Console.WriteLine("pop elements");
        while(c1.TryPop(out int result)){
            Console.WriteLine(result);
        }
    }
}

