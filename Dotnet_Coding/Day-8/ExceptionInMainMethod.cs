using System;
class Exec1{
    void CheckNum(int num)
    {
        if (num==0){
            throw new DiVideByZeroException("number");
        }
        int result=10/num;
        Console.WriteLine("correct number"+result);
    }
    public static void Main(){
        Exec1 e1=new Exec1();
        try{
            CheckNum(34);
        }catch(DivideByZeroException e){
            Console.WriteLine("Error: " + e.Message);
        }
    }
}