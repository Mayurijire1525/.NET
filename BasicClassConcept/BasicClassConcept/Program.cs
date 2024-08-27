using MyNamespace;
//using System;

namespace BasicClassConcepts
{
    internal class Program
    {
        static void Main1()
        {

            //Console.WriteLine("Hello, World!");
            System.Console.WriteLine("Hello World");
            System.Console.WriteLine("Hello World");
            Console.WriteLine("HW");
            Class1 o;

            Display();

        }
        static void Main()
        {
            //Class1 o;  //o is a reference of type Class1
            //o = new Class1(); //new Class1() is an object of Class1. o refers to the object.

            Class1 o = new Class1();
            o.Display();
            o.Display("Vikram");

            //positional parameters
            Console.WriteLine(o.Add());
            Console.WriteLine(o.Add(10));
            Console.WriteLine(o.Add(10, 20));
            Console.WriteLine(o.Add(10, 20, 30));

            //named paramters
            Console.WriteLine(o.Add(5, c: 10));
            Console.WriteLine(o.Add(a: 10));
            Console.WriteLine(o.Add(b: 10));
            Console.WriteLine(o.Add(c: 10));
            Console.WriteLine(o.Add(c: 20, a: 10));
            Console.WriteLine(o.Add(c: 20, a: 10, b: 20));
        }

        static void Display()
        {
            Console.WriteLine("Display");
        }
    }
}
namespace MyNamespace
{
    public class Class1
    {
        public void Display()
        {
            Console.WriteLine("Class1 Display");
        }
        //func overloading
        public void Display(string s)
        {
            Console.WriteLine("Class1 Display" + s);
        }

        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}
        //public int Add(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        //optional paramters using default values

        public int Add(int a = 0, int b = 0, int c = 0)
        {
            return a + b + c;
        }

        public void DoSomething()
        {
            int i = 100;
            Console.WriteLine("ds");
            //local func
            //local func can only be called from within the defining function
            //implicitly private

            void DoSomething2()
            {
                //local func can access variable defined in the calling function
                Console.WriteLine(++i);
            }

            Console.WriteLine(i);
            DoSomething2();
        }

        //to do - try to overload a local func
        //-- try to have a local func inside another local func
    }

}