using System;
class String3{
    static void Main(string[] args){
        string s1="hi";
        string s2="hi";
        string s3=new string("hai".ToCharArray());
        string s4=new string("hai".ToCharArray());
        //string s2="HI";
        Console.WriteLine(s1.Equals(s2));//content only
        Console.WriteLine(s1==s2);//ref
        Console.WriteLine(object.ReferenceEquals(s1,s2));//content and refernce
        Console.WriteLine(s1.CompareTo(s2));//lexicographical
        Console.WriteLine(s1.Equals(s3));
        Console.WriteLine(s1.CompareTo(s3));

        

    }
}