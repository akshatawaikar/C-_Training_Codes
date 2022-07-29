using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.NAME = "Sidhoji";
            p.AGE = 21;
            Console.WriteLine(" Name = {0} Age= {1}", p.NAME, p.AGE);
            Person p1 = new Person { NAME = "Sidhoji", AGE = 21 , ADDREESS="PUNE" };

            // boxing 
            int i=10;
            object o;
            o = i;
            Console.WriteLine("o = {0}", o);
                
            
        }
    }
}
