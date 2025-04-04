using System;
using System.Collections.Generic;
class Cls3{
    static void Main(){
        Stack<int> stack=new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        stack.Push(6);
        stack.Push(7);
        Display(stack);

        Console.WriteLine("Top Element:"+stack.Peek());
        int poppedElement=stack.Pop();
        Console.WriteLine("popped Element:"+poppedElement);
        Display(stack);
        Console.WriteLine("Is Stack empty?"+(stack.Count==0));
        stack.Clear();
        Console.WriteLine("Is stack empty after clear?"+(stack.Count==0));
    }
    static void Display(Stack<int> stack){
        Console.WriteLine("stack contents are: ");
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }
    }
}