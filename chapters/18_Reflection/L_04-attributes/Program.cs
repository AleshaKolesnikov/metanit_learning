using System;

namespace L_04_attributes
{
    class Program
    {
        // проверить пользователя на соответствие некоторым возрастным ограничениям
        // check user for compliance with some age restrictions

        static void Main(string[] args)
        {
            User tom = new User("Tom", 35);
            User bob = new User("Bob", 16);

            bool tomIsValid = ValidateUser(tom);
            bool bobIsValid = ValidateUser(bob);

            bool tomNameIsValid = ValidateName(tom);
            bool bobNameIsValid = ValidateName(bob);

            Console.WriteLine($"Результат валидации имени у Тома - {tomNameIsValid}");
            Console.WriteLine($"Результат валидации имени у Боба - {bobNameIsValid}");

            Console.WriteLine($"Результат валидации возраста у Тома - {tomIsValid}");
            Console.WriteLine($"Результат валидации возраста у Боба - {bobIsValid}");
        }

        static bool ValidateUser(User user)
        {
            Type t = typeof(User);
            object[] customAttributes = t.GetCustomAttributes(false);

            foreach (AgeValidationAttribute attr in customAttributes)
            {
                if (user.Age >= attr.Age) return true;
                else return false;
            }
            return true;
        }
        static bool ValidateName(User user)
        {
            Type t = typeof(User);
            object[] customAttributes = t.GetCustomAttributes(false);

            for (int i = 0; i < customAttributes.Length; i++)
            {
                //привет костыль
                if (!(customAttributes[i] is NameValidationAttribute))
                    continue;
                else
                {
                    NameValidationAttribute attr = customAttributes[i] as NameValidationAttribute;
                    if (user.Name.Length >= attr.Length) return true;
                    else return false;
                }
            }
            return true;
        }

        public class AgeValidationAttribute : Attribute
        {
            public int Age { get; set; }

            public AgeValidationAttribute()
            {

            }
            public AgeValidationAttribute(int age)
            {
                Age = age;
            }
        }

        public class NameValidationAttribute : Attribute
        {
            public int Length { get; set; }
            public NameValidationAttribute()
            {

            }
            public NameValidationAttribute(int quantity)
            {
                Length = quantity;
            }
        }


        [AgeValidation(18)]
        [NameValidation(1)]
        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public User(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
    }
}
