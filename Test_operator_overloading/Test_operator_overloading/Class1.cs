using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_operator_overloading
{
    class Cpoint 
    {
        int x, y;
        public Cpoint()
        {
            x = 0;
            y = 0;
        }
        public Cpoint(int i , int j)
        {
            x = i;
            y = j;

        }
        public int X
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
        public int Y
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }
        public void Print ()
        {
            Console.WriteLine(" X: = {0} , Y: = {1} ", x, y);

        }
        public static Cpoint operator +  (Cpoint obj1, Cpoint obj2)
        {
            Cpoint temp = new Cpoint();
            temp.x = obj1.x + obj2.x;
            temp.y = obj1.y + obj2.y;
            return temp;

        }
        public static Cpoint operator++ (Cpoint obj1)
        {
            Cpoint temp = new Cpoint();
            int a, b;
            a = obj1.x;
            b = obj1.y;
            temp.x = ++a;
            temp.y = ++b;
            return temp;
        }

        public static implicit operator Cpoint (int i )
        {
            Cpoint t = new Cpoint(i, 12);
            return t;
        }
           
    }
}
