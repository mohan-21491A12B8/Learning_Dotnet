// Collection generics with Linqueue

using System;
using System.Collections.Generic;
using System.Linq;

class Lin1{
    static void Main(){
    List<string> n1=new List<string>{"arm","mohan","sai","qis"};
    var namesStartWithA=from name in n1
                        where name.StartsWith("a")
                        select name;
    Console.WriteLine("Names starting with 'a':");
    foreach (var item in namesStartWithA)
    {
        Console.WriteLine(item);
    }   
    }    
}