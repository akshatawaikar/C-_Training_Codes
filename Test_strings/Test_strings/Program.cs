using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "sid!";
            string s2 = "sid!";
            string s3 = s1;
            char[] v = { 's', 'i', 'd', '!' };
            string s4 = new string(v);
            if (s1.Equals(s2))
                Console.WriteLine("s1 and s2 are equal");
            else
                Console.WriteLine("s1 and s2 are not equal");
            Console.WriteLine(s1 == s3);
            Console.WriteLine(s1 == s4);
            Console.WriteLine(s1.Equals(s4));
            
        }
    }
}
