using System;
using System.Reflection;

namespace L_02_applying
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(User);

            Console.WriteLine("DeclaringType MemberType Name");
            foreach (MemberInfo mi in myType.GetMembers())
            {
                Console.WriteLine($"{mi.DeclaringType} {mi.MemberType} {mi.Name}");
            }

            Console.WriteLine("\n\n\nMethods:");
            foreach (MethodInfo method in myType.GetMethods())
            {
                string modificator = "";
                if (method.IsPublic)
                    modificator += "public ";
                if (method.IsStatic)
                    modificator += "static ";
                if (method.IsVirtual)
                    modificator += "virtual";

                Console.Write($"{modificator} {method.ReturnType.Name} {method.Name} (");

                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                    if (i + 1 < parameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }

            Console.WriteLine("\n\n\n");
            foreach (MethodInfo method in myType.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance |
                                                    BindingFlags.NonPublic | BindingFlags.Public))
            {
                string modificator = "";
                if (method.IsPublic)
                    modificator += "public ";
                if (method.IsStatic)
                    modificator += "static ";
                if (method.IsVirtual)
                    modificator += "virtual";

                Console.Write($"{modificator} {method.ReturnType.Name} {method.Name} (");

                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                    if (i + 1 < parameters.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }

            Console.WriteLine("\n\n\nConstructors:");
            foreach (ConstructorInfo ctor in myType.GetConstructors())
            {
                Console.Write($"{myType.Name} (");
                ParameterInfo[] param = ctor.GetParameters();
                for (int i = 0; i < param.Length; i++)
                {
                    Console.Write($"{param[i].ParameterType.Name} {param[i].Name}");
                    if (i + 1 < param.Length) Console.Write(", ");
                }
                Console.WriteLine(")");
            }

            Console.WriteLine("\n\n\nПоля:");
            foreach (FieldInfo field in myType.GetFields())
            {
                Console.WriteLine($"{field.FieldType} {field.Name}");
            }

            Console.WriteLine("\n\n\nСвойства:");
            foreach (PropertyInfo prop in myType.GetProperties())
            {
                Console.WriteLine($"{prop.PropertyType.Name} {prop.Name}");
            }

            Console.WriteLine("\n\n\nРеализованные интерфейсы:");
            foreach (Type iface in myType.GetInterfaces())
            {
                Console.WriteLine(iface.Name);
            }
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
