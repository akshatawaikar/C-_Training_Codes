using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_delegate
{
    class AnalyseData
    {   // declaration of a delegate
        public delegate void MyDelegate(int i, double d);
        public void Analyse(int i , double d, MyDelegate del)
        {
            Console.WriteLine("BEgin to analyse Function");
            Console.WriteLine("Begin delegate invocation");
            del(i, d);
            Console.WriteLine("End to analyse Function");
            Console.WriteLine("End delegate invocation");


        }
    }
}
