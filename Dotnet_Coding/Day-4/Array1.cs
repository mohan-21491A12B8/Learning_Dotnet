using System;
class Array1{
    public static void Main(){
        int[] numbers={1,2,3,4,5,3,2,1,5,6};
        Console.WriteLine("Original Array:"+string.Join(",",numbers));
    Array.Clear(numbers,1,3);//starting index end ing index
    Console.WriteLine("After clear:"+string.Join(",",numbers));
    int[] copiedArray=new int[9];
    Array.Copy(numbers,copiedArray, 3);//defaultly starts from 0 and only end value is mentioned ex-3
    Console.WriteLine("copied array:"+string.Join(",",copiedArray));
    int[] destinationArray=new int[10];
    numbers.CopyTo(destinationArray,0);
    Console.WriteLine("destination Array:"+string.Join(",",destinationArray));
    Console.WriteLine(Array.IndexOf(numbers,5));//shows the given number first occurence index
    Console.WriteLine(Array.LastIndexOf(numbers,5));//shows the given number last occurence index
    Array.Sort(numbers);
    Console.WriteLine("Sorted Array:"+string.Join(",",numbers));
    Array.Resize(ref numbers,20);
    Console.WriteLine("Resized Array:"+string.Join(",",numbers));
    
Console.WriteLine("First elemenet greater than 4:"+Array.Find(numbers,element=>element>4));//internally takes the first occurence  then gives the result
Console.WriteLine("All elemenet greater than 4:"+string.Join(",",Array.FindAll(numbers,element=>element>4)));

Console.WriteLine("Elements in the array:");
    Array.ForEach(numbers,element=>Console.WriteLine(element));

Console.WriteLine("Does 5 exist in the array:"+Array.Exists(numbers,element=>element>=0));

int[] clonedArray=(int[])numbers.Clone();
Console.WriteLine("Cloned Array:"+string.Join(",",clonedArray));
    }
}