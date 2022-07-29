using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_interfaces
{ interface Interf1
    {
        void Fn1();
        void Fn2();

    }
    interface Interf2
    {
        void Fn3();
    }
    class Test : Interf1, Interf2 
    {
        void Interf1.Fn1()
        {
            Console.WriteLine("interface 1 ");
        }
        void Interf1.Fn2()
        {
           
        }
        public void Fn1()
        {
            Console.WriteLine("class Fn1() ");
        }
        public void Fn3()
        {
            Console.WriteLine("class fn3()");
        }
        
    }
}
