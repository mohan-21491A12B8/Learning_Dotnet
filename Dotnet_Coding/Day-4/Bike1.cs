using System;
namespace Bikes{
    class Bike{
        string name;
        string color;
        int milage;
        double cost;
        void display(){
            Console.WriteLine();
            Console.WriteLine("Choose the Bike:");
            Console.WriteLine("Bike Name: "+name);
            Console.WriteLine("Bike Color: "+color);
            Console.WriteLine("Bike Milage: "+milage);
            Console.WriteLine("Bike Cost: "+cost); 
        }
    
        static void Main(string[] args){
            Bike bike = new Bike();
            bike.name="yamaha";
            bike.color = "Red";
            bike.milage = 1000;
            bike.cost = 1000.0;
            bike.display();
            
            Bike duke = new Bike();
            duke.name="duke";
            duke.color = "blue";
            duke.milage = 1000;
            duke.cost = 1000.0;
            duke.display();
            
            Bike pulsor = new Bike();
            pulsor.name="pulsor";
            pulsor.color = "black";
            pulsor.milage = 1000;
            pulsor.cost = 1000.0;
            pulsor.display();
            
        }
}
    
    

}