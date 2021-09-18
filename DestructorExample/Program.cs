using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorExample
{
    class A
    { 
        public A() { }
        public void doSomething()
        {
            Console.WriteLine("I'm in the constructor!");
        }

        ~A()
        {
            Console.WriteLine("I'm in the destructor! Exiting now....");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            a.doSomething();
            Console.ReadLine();

            Environment.Exit(0);


        }
    }
}
