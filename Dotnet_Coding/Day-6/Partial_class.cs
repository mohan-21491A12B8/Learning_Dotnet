using System;
namespace PartialClassExample{
    public partial class Person{
        public string FirstName{get;set;}
        public string LastNamee{get;set;}
        public void DisplayFullName(){
            Console.WriteLine("Full Name:"+FirstName+" "+LastName");
    }
    public partial class Person{
        public int Age{get;set;}

        public void DisplayAge(){
            Console.WriteLine("Age"+Age);
        }
        
    }
    
    public class Program{
        static void Main(string[] args){
            Person p=new Person{
                FirstName="john";
                LastName="wel";
                Age=30;
            };
            p.Di();
            p.DisplayAge();
        }
    }
}
}