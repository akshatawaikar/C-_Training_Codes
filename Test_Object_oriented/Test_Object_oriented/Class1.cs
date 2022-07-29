using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Object_oriented
{
    abstract class CBase
    {
        public CBase()
        {
            Console.WriteLine(" in base const");
        }
        public CBase( int i )
        {
            Console.WriteLine(" in base para const");
        }
        abstract  public void Fn1();
        //{
        //    //Console.WriteLine(" in base fn1 ");
        //}
    }
    class Cder1 : CBase
    {
        public Cder1()
        {
            Console.WriteLine(" in der1 const");
        }
        public Cder1(int j ) : base(j)
        {
            Console.WriteLine(" in der1 para const");
        }
        public override void Fn1()
        {
            Console.WriteLine(" in der 1 ");
        }

    }
    class Cder2 : CBase
    {
        public Cder2()
        {
            Console.WriteLine(" in der2 const");
        }
        public override void Fn1()
        {
            Console.WriteLine(" in der2 fn1() ");             
        }

    }
}
