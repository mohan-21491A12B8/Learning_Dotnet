using System;
class QisException:Exception{
    public QisException(string message):base(message){

    }
}
class Mohan{
    public void AgeCheck(int age) {
        if(age<18){
            throw new QisException("age is not valid");
        }
        Console.WriteLine("Eligible");
    }

    public static void Main(){
        try{
            Console.WriteLine("enter the age:");
            int age=int.Parse(Console.ReadLine());
            Mohan m=new Mohan();
            m.AgeCheck(age);
        }catch(QisException e){
            Console.WriteLine(e.Message);
        }
    }
}