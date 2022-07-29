using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("begin main");
            AnalyseData obj = new AnalyseData();
           
            AnalyseData.MyDelegate del = new AnalyseData.MyDelegate(CalcInt);
            
            obj.Analyse(108,2.5, del);
            Console.WriteLine("end main");

        }
        public static void CalcInt(int i, double f)
        {
            Console.WriteLine("Delegate invoked");
           
        }
    }
}
