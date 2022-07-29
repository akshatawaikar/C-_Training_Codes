using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_collection_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add("pune");
            arr.Add("mumbai");
            arr.Add("kolhapur");
            arr.Add("delhi");

            foreach (var v in arr)
                Console.WriteLine(v);

            // iterate using IEnumarator
            IEnumerator e;
            e = arr.GetEnumerator();
            while (e.MoveNext())
                Console.WriteLine(e.Current);

            //Hahtable
            Hashtable ht = new Hashtable();
            ht.Add(1, "North");
            ht.Add(2, "South");
            ht.Add(3, "East");
            ht.Add(4, "West");

            foreach (DictionaryEntry v in ht)
                Console.WriteLine(v.Value);

            //Stack 

            Stack st = new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            Console.WriteLine(st.Pop());

            //Queue 
            Queue q = new Queue();
            q.Enqueue(100);
            q.Enqueue(200);
            q.Enqueue(300);
            Console.WriteLine(q.Dequeue());


        }
    }
}
