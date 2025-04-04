using System;
using System.Collections;

class Collect2{
    static void Main(){
        ArrayList a1=new ArrayList();
        a1.Add(1);
        a1.Add("hi qis");
        a1.Add(7.786);
        a1.Add(true);
        a1.Add(null);
        foreach (object n in a1)
        {
            Console.WriteLine(n);
        }
        
    }
}