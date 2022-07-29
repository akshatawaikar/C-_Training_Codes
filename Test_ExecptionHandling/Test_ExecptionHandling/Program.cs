using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ExecptionHandling
{ class Test
    {
        public void fn1(int i)
        {
            if (i > 5)
                throw new Exception ("error from fn1");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            
            try
            {
                t.fn1(10);
            }  
            catch(Exception e1 )
            {
                Console.WriteLine(e1.Message);
                Console.WriteLine(e1.Source);
                //Console.WriteLine(e1.StackTrace);

            }  
            //    int a = 10, b = 0, c;
            //try
            //{
            //    Console.WriteLine(c = a / b);
            //    int d = Convert.ToInt32(Console.ReadLine());
            //}          

            //catch (DivideByZeroException g)
            //{
            //    Console.WriteLine(g.Message);
            //}

            //catch (FormatException f)
            //{
            //    Console.WriteLine(f.Message);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("finally block:");
            //}

        }
    }
}
