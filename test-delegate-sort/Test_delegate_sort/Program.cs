using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_delegate_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //object[] arr = new object[5] { "abc","ggfg","ecc","xwdd","kie" };
            //Qsort obj = new Qsort();
            //Qsort.Mydel d = new Qsort.Mydel(comp);
            //for(int i =0; i<5; i++)
            //Console.WriteLine(arr[i]);
            //obj.sort(arr, d);
            //Console.WriteLine("sorted array in descending order : ");
            //for (int i = 0; i < 5; i++)
            //    Console.WriteLine(arr[i]);


            string[] arr = new string[5] { "abc", "ggfg", "ecc", "xwdd", "kie" };
            Qsort<string> obj = new Qsort<string>();
            Qsort<string>.Mydel d = new Qsort<string>.Mydel(comp);
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr[i]);
            obj.sort(arr, d);
            Console.WriteLine("sorted array in ascending order : ");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr[i]);


            int[] arr1 = new int[5] { 8,5,4,2,7 };
            Qsort<int> obj1 = new Qsort<int>();
            Qsort<int>.Mydel d1 = new Qsort<int>.Mydel(comp_int);
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr1[i]);
            obj1.sort(arr1, d1);
            Console.WriteLine("sorted array in ascending order : ");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr1[i]);
        }

        public static void comp(ref string o1, ref string o2)
        {
            if (o1.ToString().CompareTo(o2.ToString())>0)
            {
                string k;
                k = (string)o2;
                o2 = o1;
                o1 = k;


            }

        }

        public static void comp_int(ref int o1, ref int o2)
        {
            if (o1>o2)
            {
                int k;
                k = o2;
                o2 = o1;
                o1 = k;


            }
        }
        }
}
