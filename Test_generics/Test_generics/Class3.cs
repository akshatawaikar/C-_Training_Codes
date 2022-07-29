using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_generics
{
    class Class3
    {
        class X
        { }
        class Y
        { }
        class W : Y
        { }
        class S
        { }
        class Z<T1, T2>
            //constraints 
            where T1 : X
                where T2 : Y

        { }
    }
}
