using System;
using System.Collections.Generic;
using System.Linq;
class Program{
    static void Main(){
        var s1=new List<Person>{
            new Person{Name="ram",Age=34},
            new Person{Name="ravi",Age=32},
            new Person{Name="raju",Age=35},
            new Person{Name="raghu",Age=36},
        };
        var result=from person in s1
        where person.Age<35
        select new{person.Name,person.Age};

        foreach(var item in result){
            Console.WriteLine(item);
        }
    }
    class Person{
        public string Name{get;set;}
        public int Age{get;set;}
    }
}