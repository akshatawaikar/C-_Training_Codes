using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Arrays
{
    class Program
    {
        
        static void Main(string[] args)
        {
         //   int[] arr = new int[5];// { 1,2,3,4,5};
         //for (int i = 0; i<5; i++)
         //   {
         //       Console.WriteLine("enter a value :");
         //       arr[i] = Convert.ToInt32(Console.ReadLine());

         //   }
         //for (int i = 0; i<5; i++)
         //   {
         //       Console.WriteLine(arr[i] + "");

         //   }
            // 2d array
            int[,] arr1 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for(int i =0; i<3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine(); 
            }

            //jagged array 
            int[][] arr2 = new int[3][];
            arr2[0] = new int[3];
            arr2[1] = new int[2];
            arr2[2] = new int[4];

            //Accepting values 
            for ( int i =0; i<3; i++)
            {
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    arr2[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            { 
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    Console.Write(arr2[i][j]); 
                }
                Console.WriteLine();
            }
            Console.Read(); 
        }
    }
}
