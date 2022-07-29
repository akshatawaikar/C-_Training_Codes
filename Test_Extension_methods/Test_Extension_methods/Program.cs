using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string gh = "sidhoji";
            Console.WriteLine(gh.Fn1());

            int hh = 3;
            Console.WriteLine(hh.check());
        }
       

    }
}
