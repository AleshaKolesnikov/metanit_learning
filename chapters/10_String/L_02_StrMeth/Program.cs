using System;

namespace L_02_StrMeth
{
    class Program
    {
        static void Main(string[] args)
        {
            string apple = "Apple";
            string aday = "a day";
            string keeps = "keeps";
            string adoctor = "a doctor";
            string away = "away";

            string all = String.Concat(apple, " ", aday, " ", keeps, " ", adoctor, " ", away);
            string allv2 = String.Join(' ', apple, aday, keeps, adoctor, away);

            string[] check = new string[2];
            int result = String.Compare(apple, aday);
            if (result < 0)
            {
                check[0] = apple;
                check[1] = aday;
            }
            else if (result > 0)
            {
                check[0] = aday;
                check[1] = apple;
            }
            else
            {
                Console.WriteLine("Строки равны");
            }

            char l = 'l';
            char p = 'p';
            int ind = apple.IndexOf(l);
            int index = apple.IndexOf(p);
            int indexL = apple.LastIndexOf(p);
            int indx = apple.IndexOf("pl");

            bool start = all.StartsWith('a');

            string[] split = all.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (string word in split)
            //    Console.WriteLine(word);

            string trim = all.Trim('a');

            string substring = all.Substring(1, all.Length - 1);

            string insert = aday.Insert(2, "beautiful ");

            string remove = insert.Remove(2, 10);

            string replace = aday.Replace("a ", "a beautiful sunny ");

            string toUpper = apple.ToUpper();

            string toLower = apple.ToLower();
        }
    }
}
