using System;

namespace Program3
{
    interface Iname1
    {
        public void enter();
    }
    interface Iname2
    {
        public void display();
    }
    class Myclass : Iname1,Iname2
    {
        int a;
        public void enter()
        {
            Console.Write("Enter the number:");
            a = Convert.ToInt32(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine(a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Myclass obj = new Myclass();
            obj.enter();
            obj.display();
        }
    }
}
