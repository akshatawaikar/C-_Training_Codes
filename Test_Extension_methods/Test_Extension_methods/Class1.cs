using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Extension_methods
{
   static class Class1
    {
        public static string Fn1(this string v)
        {
            return  "hello" +  v ;
        }
        public static bool check(this int a )
        {
            if (a % 2 == 0)
                return true;
            else return false;

        }

    }
}
