using System;
using System.Reflection;

namespace L_03_assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Assembly assm = Assembly.LoadFrom("L_03-assembly.dll");
            //Assembly assm = Assembly.Load("L_03-assembly");

            //Console.WriteLine(assm.FullName);

            //Type[] types = assm.GetTypes();
            //foreach (Type t in types)
            //{
            //    Console.WriteLine(t.Name);
            //}

            Console.WriteLine(GetResult(6, 100, 2));

        }
        public static double GetResult(int percent, double capital, int year)
        {
            for (int i = 0; i < year; i++)
            {
                capital += capital / 100 * percent;
            }
            return capital;
        }
    }
}
