using System;
class Sample56{
    public int a=45;

    public virtual void Add(){
        a=34;
        Console.WriteLine(a);
        Console.WriteLine("welcome");
    }
}
    class Sealed:Sample56{
        public override void Add(){
            Console.WriteLine("hello");
        }
        static void Main(string[] args){
            Sample56 s=new Sample56();
            s.a;
            s.Add();
            Sealed s1=new Sealed();
            s1.Add();
            s1.a;
        }

}
