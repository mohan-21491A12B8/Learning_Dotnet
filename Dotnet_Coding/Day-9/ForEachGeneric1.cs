using System;
using System.Collections.Generic;
class ListExample{
    static void Main(){
        List<int> list = new List<int>();
        // list.Add(new int(1) );
        list.Add(1); // Add the integer 1 to the list
        foreach(int i in list){
            Console.WriteLine(i);
        }
    }
}