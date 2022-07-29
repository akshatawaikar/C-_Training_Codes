using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test_Params
{ 
    public class Students
    { 
        public static int Totalmarks(params int [] list)
        {
            int total = 0;
            for (int i = 0; i < list.Length; i++)
                total += list[i];
            return total;

        }
        public static string Allsubjects(params string[] subjects)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i<subjects.Length; i++)
            {
                builder.Append(subjects[i]);
                builder.Append(" ");
                
            }
            return builder.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" params with 3 parameters ");
            int total3 = Students.Totalmarks(8, 9, 8);
            Console.WriteLine(total3);

            string[] subs = { "english", "reading ", "writing" };
            Console.WriteLine(Students.Allsubjects(subs));



            Console.WriteLine(" params with 4 parameters ");
            int[] marks= { 1,2,3,4};
            string[] subjects = { "english ", "reading ", "writing", "history" };

            


        }
    }
}
