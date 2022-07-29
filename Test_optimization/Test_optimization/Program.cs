using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Test_optimization
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<Int32> list1 = new List<int>();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for(int  i =0; i<1000;i++)
            {
                list1.Add(i);
            }
            sw.Stop();
            Console.WriteLine("using array list object " + sw.ElapsedTicks + "\n");
            sw.Reset();
            int[] array1 = new int [1000];
            sw.Start();
            for(int i = 0; i<1000; i++)
            {
                array1[i] = i;
            }
            sw.Stop();
            Console.WriteLine("using array object " + sw.ElapsedTicks + "\n");
           



        }
    }
}
