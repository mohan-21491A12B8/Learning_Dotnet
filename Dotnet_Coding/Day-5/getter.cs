using System;
class Test30{//example of encapsulation
    private string name;
    private int marks;
    
    public string Name{
        get{
            return name;
        }
        set{
            name=value;
        }
    }    
    public int Marks{
        get{
            return marks;
        }
        set{
            marks=value;
        }
    } 
    static void Main(string[] args){
        Test30 t1=new Test30();
        t1.Name="mohan";//set method works
        t1.Marks=90;
    Console.WriteLine("Name: "+t1.name);//get method works
    Console.WriteLine("Marks: "+t1.marks);
   }
}
