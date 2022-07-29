using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_generics
{
    class Test<T1,T2>
    {
        T1 a;
        public void SetData(T1 para)
        {
            a = para;
        }
        public T1 GetData()
        {
            return a;
        }

        T2 b;
        public T2 B_property
        {
            set
            {
                b = value;
            }
            get
            {
                return b;
            }
        }

    }
}
