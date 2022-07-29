using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Object_oriented
{
    class test 
    {
        static int i;
        private test ()
        {
            i++;
            Console.WriteLine(" i = " + i);
        }
        public static test createobj()
        {
            if (i < 3)
                return new test();
            else
                return null;
        }
        public static void print()
        {
            //this.i = i;
            Console.WriteLine("no of obj created " + i );
            //Console.WriteLine("para i" + i);


        }
    }
}
