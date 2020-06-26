using System;
using System.Text;

namespace L_04_StrBui
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder("Some string");
            //Console.WriteLine(sb.Length);
            //Console.WriteLine(sb.Capacity);

            //StringBuilder sb = new StringBuilder("Название: ");
            //Console.WriteLine(sb);
            //Console.Write($"Длина строки: {sb.Length}, ");
            //Console.WriteLine($"Емкость строки: {sb.Capacity}");

            //sb.Append("Руководство");
            //Console.WriteLine(sb);
            //Console.Write($"Длина строки: {sb.Length}, ");
            //Console.WriteLine($"Емкость строки: {sb.Capacity}");

            //sb.Append(" по C#");
            //Console.WriteLine(sb);
            //Console.Write($"Длина строки: {sb.Length}, ");
            //Console.WriteLine($"Емкость строки: {sb.Capacity}");

            StringBuilder sb = new StringBuilder("Привет мир");
            sb.Append("!");
            sb.Insert(7, "компьютерный ");
            Console.WriteLine(sb);

            sb.Replace("мир", "world");
            Console.WriteLine(sb);

            sb.Remove(7, 13);
            Console.WriteLine(sb);

            string s = sb.ToString();
            Console.WriteLine(s);
        }
    }
}
