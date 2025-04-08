// Collection generics with Linqueue

using System;
using System.Collections.Generic;
using System.Linq;

class Lin1{
    static void Main(){
    List<string> n1=new List<string>{"arm","mohan","sai","qis"};
    var s=from name in n1
    where name.StartsWith("a")
    select name;
    foreach (var item in s)
    {
        Console.WriteLine(item);
    }   
    }    
}