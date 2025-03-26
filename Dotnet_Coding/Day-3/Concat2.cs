using System;
namespace concat2{
    class Concat2{
        static void Main(string[] args){
            string s1="good";
            string s2="morning";
            int s3=100;
            Console.WriteLine(s1+s2);
            //Console.WriteLine(string.Concat(100,@));
            Console.WriteLine(string.Concat(s1,s3));
            Console.WriteLine(string.Concat(100,100));
            Console.WriteLine(s1+s2+s3);
            

        }
    }
}