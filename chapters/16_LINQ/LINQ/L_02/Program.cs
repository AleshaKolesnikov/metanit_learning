using System;
using System.Collections.Generic;
using System.Linq;

namespace L_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1)

            //int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };

            //var evens = from i in numbers
            //                    where i % 2 == 0 && i > 10
            //                    select i;
            ////var evens = numbers.Where(i => i % 2 == 0 && i > 10);

            //foreach (var i in evens)
            //{
            //    Console.WriteLine(i);
            //}

            //  2)

            //List<User> users = new List<User>
            //{
            //    new User {Name="Том", Age=23, Languages = new List<string> {"английский", "немецкий" }},
            //    new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
            //    new User {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
            //    new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            //};

            //var selectedUsers = users.SelectMany(u => u.Languages, (u, l) => new { User = u, Lang = l })
            //    .Where(u => u.Lang == "английский" && u.User.Age < 28)
            //    .Select(u => u.User);

            ////var selectedUsers = from user in users
            ////                    from lang in user.Languages
            ////                    where user.Age < 28
            ////                    where lang == "английский"
            ////                    select user;


            //////var selectedUsers = from user in users
            //////                    where user.Age > 25
            //////                    select user;
            ////var selectedUsers = users.Where(user => user.Age > 25);

            //foreach (var user in selectedUsers)
            //{
            //    Console.WriteLine($"{user.Name} - {user.Age}");
            //}

            //  3)

            //List<User> users = new List<User>();
            //users.Add(new User { Name = "Sam", Age = 43 });
            //users.Add(new User { Name = "Tom", Age = 33 });

            //var items = users.Select(u => new {Name = u.Name, Birth = DateTime.Now.Year - u.Age });


            ////var items = from user in users
            ////            select new { Name = user.Name, Birth = DateTime.Now.Year - user.Age };

            //foreach (var i in items)
            //{
            //    Console.WriteLine($"{i.Name} - {i.Birth}");
            //}

            //  4)

            //List<User> users = new List<User>()
            //{
            //    new User { Name = "Sam", Age = 43 },
            //    new User { Name = "Tom", Age = 33 }
            //};

            //var people = from u in users
            //             let name = "Mr. " + u.Name
            //             select new
            //             {
            //                 Name = name,
            //                 Age = u.Age
            //             };

            //foreach (var p in people)
            //{
            //    Console.WriteLine($"{p.Name} - {p.Age}");
            //}

            //  5)

            List<User> users = new List<User>()
            {
                new User { Name = "Sam", Age = 43 },
                new User { Name = "Tom", Age = 33 }
            };

            List<Phone> phones = new List<Phone>()
            {
                new Phone {Name="Lumia 630", Company="Microsoft" },
                new Phone {Name="iPhone 6", Company="Apple"},
            };

            var people = from u in users
                         from p in phones
                         select new
                         {
                             Name = u.Name,
                             Phone = p.Name
                         };
            foreach (var u in people)
            {
                Console.WriteLine($"{u.Name} - {u.Phone}");
            }
        }
    }
    class Phone
    {
        public string Name { get; set; }
        public string Company { get; set; }
    }
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        //public List<string> Languages { get; set; }
        //public User()
        //{
        //    Languages = new List<string>();
        //}
    }

}
