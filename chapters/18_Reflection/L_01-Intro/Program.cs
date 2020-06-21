using System;

namespace L_01_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(User);

            User user = new User("Tom", 30);
            Type myType = user.GetType();

            Type getT = Type.GetType("L_01_Intro.User", false, true);

            Console.WriteLine(myType);
            Console.WriteLine(t);
            Console.WriteLine(getT);
        }
    }
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Display()
        {
            Console.WriteLine($"Имя: {Name}  Возраст: {Age}");
        }
        public int Payment(int hours, int perhour)
        {
            return hours * perhour;
        }
    }
}
