using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L_01_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            int age = Int32.Parse(Console.ReadLine());

            User user = new User { Name = name, Age = age };

            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(user);

            if(!Validator.TryValidateObject(user, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
        }
    }
}
