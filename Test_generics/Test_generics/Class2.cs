using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_generics
{
    class GenericDelegate<T1,T2>
    {
        public delegate void MyDel(T1 a, T2 b);
        public void Fn1(T1 i , T2 j ,MyDel d1)
        {
            d1(i, j);

        }

    }
}
