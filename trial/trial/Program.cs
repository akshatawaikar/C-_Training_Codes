using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a C# Sharp program to convert an integer to string and a string to an integer.");
            string string1, string2;
            int nn, mm;
            Console.WriteLine("Enter a string:");
            string1 = Console.ReadLine();
            Console.WriteLine("Enter any integer:");
            nn = Convert.ToInt32(Console.ReadLine());
            mm = Convert.ToInt32(string1);
            Console.WriteLine($"The data type of {mm} is {mm.GetType()}");
            string2 = Convert.ToString(nn);
            Console.WriteLine($"The data type of {string2} is {string2.GetType()}");

        }
    }
}
