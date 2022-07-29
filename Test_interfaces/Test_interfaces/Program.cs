using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.Fn1();
            Interf1 obj = new Test();
            obj.Fn1();
        }
    }
}
