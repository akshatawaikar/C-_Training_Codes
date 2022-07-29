using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_operator_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Cpoint pt1 = new Cpoint();
            pt1.X = 10;
            pt1.Y = 20;
            Cpoint pt2 = new Cpoint(30,40);
            pt1.Print();
            pt2.Print();
            Cpoint pt3 = new Cpoint();
            pt3 = pt1 + pt2;

            Cpoint pt4 = new Cpoint(10,20);
            pt4++;
            pt4.Print();

            Cpoint pt5 = new Cpoint();
            pt5 = 100;
            pt5.Print();
                      




        }
    }
}
