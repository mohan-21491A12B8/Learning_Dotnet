using System;
class Test32{
    private string name;
    private int marks;
    public Test32(){
        name="unknown";
        marks=0;
    }   
    public Test32(string name){
        this.name=name;
        marks=0;
    } 
    public Test32(string name,int marks){
        this.name=name;
        this.marks=marks;
    } 
     public Test32(Test32 t){
        this.name=t.name;
        this.marks=t.marks;
    } 
    public void Display(){
        Console.WriteLine("name:"+name+"marks:"+marks);
    }
    static void Main(string[] args){
        Test32 t2=new Test32();
        t2.Display();
        Test32 t3= new Test32("ram");
        Test32 t4= new Test32("ram",67);
        t4.Display();
        Test32 t5= new Test32(t4);
        t5.Display();
    }
}