using System;
using System.Collections.Generic;
using System.Linq;

namespace L_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

            //var selectedTeams = new List<string>();
            //foreach (string s in teams)
            //{
            //    if (s.ToUpper().StartsWith("Б"))
            //        selectedTeams.Add(s);
            //}
            //selectedTeams.Sort();

            //foreach (string s in selectedTeams)
            //{
            //    Console.WriteLine(s);
            //}

            var selectedTeams = from t in teams
                                where t.ToUpper().StartsWith("Б")
                                orderby t
                                select t;

            foreach (string s in selectedTeams)
            {
                Console.WriteLine(s);
            }
        }
    }
}
