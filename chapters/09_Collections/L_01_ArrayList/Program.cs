using System;
using System.Collections;

namespace L_01_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(2.3);
            list.Add(55);
            list.AddRange(new string[] { "Hi", "man" });

            foreach (object obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAt(0);
            list.Reverse();
            Console.WriteLine(list[0]);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
