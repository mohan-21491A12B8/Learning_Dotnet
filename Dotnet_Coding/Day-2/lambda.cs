using System;
public class Lambda
{
    public static void Main (string[ ] args){
        Func<int,int>square=x=>x*x;
int result=square(5);
Console.WriteLine(result);
    }
}