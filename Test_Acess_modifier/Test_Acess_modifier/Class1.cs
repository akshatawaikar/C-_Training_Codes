using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Acess_modifier
{
    public class A
    {
        private int i = 10;
        public int j = 11;
        internal int k = 12;
        protected int m = 13;
        protected internal int n = 14;



        public void FnA()
        {
            
            Console.WriteLine("Private : " + i);
            Console.WriteLine(" public : " + j);
            Console.WriteLine("internal : " + k);
            Console.WriteLine("protected : " + m);
            Console.WriteLine("protected internal : " + n);


        }
    }

    public class B
    { 
        public void FnB()
        {
            A obj = new A();
            //Console.WriteLine("Private : " + obj.i);
            Console.WriteLine(" public : " + obj.j);
            Console.WriteLine("internal : " + obj.k);
           // Console.WriteLine("protected : " + obj.m);
            Console.WriteLine("protected internal : " + obj.n);

        }

    }
    public class C:A 
    { public void FnC()
        {
            //Console.WriteLine("Private : " + i);
            Console.WriteLine(" public : " + j);
            Console.WriteLine("internal : " + k);
            Console.WriteLine("protected : " + m);
            Console.WriteLine("protected internal : " + n);
        }

    }
}

