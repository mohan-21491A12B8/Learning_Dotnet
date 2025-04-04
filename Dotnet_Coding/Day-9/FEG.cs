using System;
using System.Collections.Generic;
class Sample{
    static void Main(){
        List<string> s1 = new List<string>{"r","e","d"};
        // Console.WriteLine(string.Join(",",list));
        IEnumerator<string> e1=s1.GetEnumerator();
        while (e1.MoveNext()){
            Console.WriteLine(e1.Current);
        }
    }
}