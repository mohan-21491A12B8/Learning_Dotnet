using System;
class CallByValue {
    static void add(int a) {
        a = 10;
        Console.WriteLine("Inside change value method: a = " + a);
    }
    static void Main() {
        int x = 5;
        Console.WriteLine("Before calling the change value: x = " + x);
        add(x);
        Console.WriteLine("After calling the change value: x = " + x);
    }
}
