using System;
using System.Collections.Generic;
class Cls4{
    static void Main(){
        Queue<int> queue=new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);
        queue.Enqueue(7);
        Display(queue);

        Console.WriteLine("Top Element:"+queue.Peek());
        int poppedElement=queue.Dequeue();
        Console.WriteLine("Dequeued  Element:"+poppedElement);
        Display(queue);
        Console.WriteLine("Is queue empty?"+(queue.Count==0));
        queue.Clear();
        Console.WriteLine("Is queue empty after clear?"+(queue.Count==0));
    }
    static void Display(Queue<int> queue){
        Console.WriteLine("Queue contents are: ");
        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }
    }
}