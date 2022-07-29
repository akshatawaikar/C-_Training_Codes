using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_delegate_sort
{    // This code will do boxing while assigning int  to obj  
     //class Qsort 
     //{
     //    public delegate void Mydel(ref object o1, ref object  o2);
     //    public void sort(object[]arr,Mydel d)
     //    {
     //        for (int i = 0; i < arr.Length; i++)
     //        {
     //            for (int j =i+1; j<arr.Length;j++)
     //            {
     //                d(ref arr[i],ref  arr[j]);
     //            }
     //        }

    //    }
    //}
    class Qsort<T1>
    {
        public delegate void Mydel(ref T1 o1, ref T1 o2);
        public void sort(T1[] arr, Mydel d)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    d(ref arr[i], ref arr[j]);
                }
            }

        }
    }

}
