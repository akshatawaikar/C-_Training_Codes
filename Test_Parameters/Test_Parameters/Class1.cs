using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Parameters
{
    public class Test
    {
        public virtual void Fn1()
        {

        }
    }
    public class Testder1: Test
    {
        public sealed override void Fn1()
        {
           
        }

        
    }
    public override void Fn1()
    {

    }
}
