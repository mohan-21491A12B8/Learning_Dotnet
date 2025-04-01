//ananamous class means we don't know the class for which we create an object
using System;
class c1{
    static void Main(string[] args){
        var person = new{
            name = "Mohan",
            age = 21,
            city = "Ongole"
        };
        Console.WriteLine("name: "+person.name+"\nage: "+person.age+"\ncity: "+person.city);
    }
}