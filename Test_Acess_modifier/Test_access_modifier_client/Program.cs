using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Acess_modifier;

namespace Test_access_modifier_client
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.FnA();
            Console.WriteLine("----------");
            B b  = new B();
            b.FnB();
            Console.WriteLine("----------");
            C c  = new C();
            c.FnC();
            Console.WriteLine("----------");
            A1 a1 = new A1();
            a1.FnA();
            Console.WriteLine("----------");
            B1 b1 = new B1();
            b1.FnA(); 
            Console.WriteLine("----------");
            string name = "Sidhoji";
            int age = 21;
            Console.WriteLine("My name is {0} and my age is {1}", name, age);
            Console.WriteLine("hello");
            Console.WriteLine("Enter your name ");
            string aa = Console.ReadLine();
            Console.WriteLine(" my name is  " + aa);
            Console.WriteLine(" enter your age ");
            int ag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age !" + ag);
           


        }
    }
    public class A1
    {
        public void FnA()
        {
            A obj = new A();
          //  Console.WriteLine("Private : " + obj.i);
            Console.WriteLine(" public : " + obj.j);
           // Console.WriteLine("internal : " + obj.k);
           // Console.WriteLine("protected : " + obj.m);
           // Console.WriteLine("protected internal : " + obj.n);


        }

    }
    public class B1 :A
    {
        public void FnA()
        {
            //Console.WriteLine("Private : " + i);
            Console.WriteLine(" public : " + j);
            //Console.WriteLine("internal : " + k);
            Console.WriteLine("protected : " + m);
            Console.WriteLine("protected internal : " + n);
        }
    }
}
