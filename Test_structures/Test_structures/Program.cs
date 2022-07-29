using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_structures
{   struct Employee
    {
        public int ID;
        public string name;
        //parameterized constructor
        public Employee(int emp_id, string emp_name)
        {
            ID = emp_id;
            name = emp_name;

        }
        public void Print()
        {
            Console.WriteLine("ID = {0} Name = {1}", ID, name);

        }
    }
    public enum Days
    {
        sunday , mon , tues,
    }
    class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee(100, "Sidhoji");
            Console.WriteLine(e1);
            Employee e2;
            e2.ID = 1001;
            e2.name = " hihi";
            Console.WriteLine(Days.sunday + ": [0]", Convert.ToInt16(Days.sunday));



        }
    }
}
