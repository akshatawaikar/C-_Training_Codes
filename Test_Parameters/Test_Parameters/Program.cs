using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Parameters
{
    class Program
    { public static int addnumber(int first_number, int second_number=8)
        {
            return first_number + second_number;
        }
        public static void Main(string[] args)
        {
            //normal parameters
            Console.WriteLine(addnumber( 12, 18));
            //named arguments can be supplied for the parametes in either order
            Console.WriteLine(addnumber(first_number: 12, second_number: 18));
            Console.WriteLine(addnumber(second_number: 18, first_number: 12));
            //positional arguments cannot follow named arguments
            Console.WriteLine(addnumber(first_number: 12, 18));
            //named arguments can follow positional arguments
            Console.WriteLine(addnumber(12, second_number: 18));


        }
    }
}
