using System;
using System.Text.RegularExpressions;

namespace L_05_RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string incText = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
            string phone = "2424-433-456";

            Regex regex = new Regex(@"туп(\w)", RegexOptions.IgnoreCase);
            Regex regex2 = new Regex(@"\w*губ\w*", RegexOptions.RightToLeft);
            Regex regex3 = new Regex(@"^\d{4}-\d{3}-\d{3}$");

            MatchCollection matches = regex.Matches(incText);
            MatchCollection matches2 = regex2.Matches(incText);
            MatchCollection matches3 = regex3.Matches(phone);

            GetMatches(matches);
            GetMatches(matches2);
            GetMatches(matches3);

            //check pattern

            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            while (true)
            {
                Console.WriteLine("Введите @mail");
                string email = Console.ReadLine();

                if(Regex.IsMatch(email, pattern))
                {
                    Console.WriteLine("Email подтверждён");
                    break;
                }
                else
                    Console.WriteLine("Некорректный email");
            }

            //replace

            string textRplc = "Some  text  with    multiplespaces";
            Console.WriteLine(textRplc);
            string patternRplc = @"\s+";
            string target = " ";

            Regex regexRplc = new Regex(patternRplc);
            textRplc = regexRplc.Replace(textRplc, target);
            Console.WriteLine(textRplc);
        }
        static void GetMatches(MatchCollection matches)
        {
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            Console.WriteLine("");
        }
    }
}
