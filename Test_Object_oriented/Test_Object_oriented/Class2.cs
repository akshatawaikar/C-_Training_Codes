using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Object_oriented
{
    class A 
    {
        public virtual void Fn1()
        {
            Console.WriteLine(" in class A ");
        }

    }
    class B : A
    {
        public override void Fn1()
        {
            Console.WriteLine(" in class b ");
        }

    }
    class C : B
    {
        public virtual new void Fn1()
        {
            Console.WriteLine(" in class c ");
        }
    }
    class D : C
    {
        public override void Fn1()
        {
            Console.WriteLine(" in class d ");
        }
    }
}
