using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test<int,string> obj = new Test<int,string>();
            //obj.SetData(10);
            //Console.WriteLine(obj.GetData());
            //obj.B_property = "sid";
            //Console.WriteLine(obj.B_property);

            //Test<double, int> obj1 = new Test<double, int>();
            //obj1.SetData(2.6);
            //Console.WriteLine(obj1.GetData());
            //obj1.B_property = 10;
            //Console.WriteLine(obj1.B_property);

            //Dictionary<int, string> dict = new Dictionary<int, string>();
            //dict.Add(1,"sid");
            //dict.Add(2, "yash");
            //dict.Add(3, "mayur");

            //foreach (KeyValuePair<int,string> i in dict)
            //    Console.WriteLine(i);

            //Dictionary<int, string>.Enumerator dic = dict.GetEnumerator();
            //while (dic.MoveNext())
            //    Console.WriteLine(dic.Current);


            //Stack<string> stack = new Stack<string>();
            //stack.Push("hi");
            //stack.Push("hello");
            //stack.Push("bye");
            //foreach (string i in stack)
            //    Console.WriteLine(i);

            GenericDelegate<int, int> o = new GenericDelegate<int, int>();
            GenericDelegate<int, int>.MyDel d1 = new GenericDelegate<int, int>.MyDel(DelInvoke);
            o.Fn1(10, 20, d1);

            GenericDelegate<string, int> f = new GenericDelegate<string, int>();
            GenericDelegate<string, int>.MyDel d2 = new GenericDelegate<string, int>.MyDel(DelInvoke1);
            f.Fn1("hi", 20, d2);







        }
        public static void  DelInvoke( int i , int j  )
        {
            Console.WriteLine("delegate fn invoked ");
        }
        public static void DelInvoke1(string i , int k)
        {
            Console.WriteLine("delegate fn invoked again");
        }
    }
}
