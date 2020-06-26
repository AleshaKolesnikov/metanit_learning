using System;

namespace L_03_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person { Age = 18, Name = "Tom" };

            //Console.WriteLine("Name: {0}, Age - {1}", tom.Name, tom.Age);

            //string format = String.Format("Name: {0}, Age - {1}", tom.Name, tom.Age);
            //Console.WriteLine(format);

            //double number = 23.7;
            //int number = 23;
            long number = 375447250000;

            //string result = String.Format("{0:C}", number);
            //string result = String.Format("{0:d}", number);
            //string result = String.Format("{0:f5}", number);
            //string result = String.Format("{0:p}", number);
            string result = String.Format("{0:+###-(##) ###-##-##}", number);
            //Console.WriteLine(number.ToString("+###-(##) ###-##-##"));
            Console.WriteLine(result);
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
