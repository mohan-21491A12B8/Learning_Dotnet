using System;
namespace System{
    class Methods{
        int a=1,b=2;
        static int c=3,d=4;

        void add(){
            Console.WriteLine(a+b);
            Console.WriteLine(c+d);
        }

        static void display(){
            // Console.WriteLine(a+b);
            Console.WriteLine(c+d);
        }
        
        static void Main(string[] args){
            Console.WriteLine("testing instance and static methods");
            Methods m=new Methods();
            m.add();
            display();
        }
    }
}