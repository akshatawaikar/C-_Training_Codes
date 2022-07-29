using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Indexers
{
    class Test
    {
        int[] arr = new int[5];
        string[] arr1 = new string[5];
        //public  int this [int index]
        //{
        //    set
        //    {
        //        arr[index] = value;
        //    }
        //    get
        //    {
        //        return arr[index];
        //    }
        //}
        public string this[int s]
        {
            set
            {
                arr1[s] = value;
            }
            get
            {
                return arr1[s];
            }
        }
    }
}
