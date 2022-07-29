using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
        obj[0] = 10;
        obj[1]=20;
         obj[2]=30;
       obj[3]=40;
            Console.WriteLine(obj[0]);

        }
    }
}
