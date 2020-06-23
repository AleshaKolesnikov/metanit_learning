using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace L_02_validation_attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите Id:");
            string id = Console.ReadLine();

            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите возраст");
            int age = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();

            Console.WriteLine("Введите пароль повторно");
            string confirm = Console.ReadLine();

            User user = new User { Age = age, Id = id, Name = name, Password = password, ConfirmPassword = confirm };

            ValidateUser(user);
        }

        static void ValidateUser(object obj)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(obj);

            if (!Validator.TryValidateObject(obj, context, results, true))
            {
                foreach (var error in results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
        }
    }
}
