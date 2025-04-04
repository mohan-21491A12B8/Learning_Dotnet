using System;
using System.Collections.Generic;
using System.Linq;
class Sample{
    public static void Main(){
        List<string> s1=new List<string>{"red","yellow","green","white"};
        var s2=s1.Where(n=>n.StartsWith("y"));
        foreach(var x in s2){
            Console.WriteLine(x);
        }
    }
}
