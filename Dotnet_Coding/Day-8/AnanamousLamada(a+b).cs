using System;
public delegate int show(int x,int y);

static void main(){
    show s1=(a,b)=>a+b;

    int result=s1(23,12);
    Console.WriteLine(result);
}