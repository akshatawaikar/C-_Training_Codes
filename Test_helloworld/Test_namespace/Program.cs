using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using n1.n11;

namespace Test_namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            c1 obj = new c1();
            n2.c1 obj1 = new n2.c1();
        }
    }
}
namespace n1
{
    namespace n11
    {
        class c1
        {

        }
    }
}
namespace n2
{
    class c1
    {

    }
}