using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Linq;

namespace Linq
{
    class Pirate
    {
        public int HP { get; set; }
        public string Name { get; set; }

        public List<string> Drinks { get; set; }

        public Pirate(int hp, string name)
        {
            Drinks = new List<string>();
            HP = hp;
            Name = name;
        }

        public void AddDrink(string drink)
        {
            Drinks.Add(drink);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello World!");
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };

            var pirates = new List<Pirate>();
            var esy = new Pirate(4, "Esy");
            esy.AddDrink("cola");
            esy.AddDrink("rum");
            pirates.Add(esy);
            pirates.Add(new Pirate(10, "Jack"));

            var select = numbers.Select(n => n);
            var where = numbers.Where(n => n > 2);

            var pirateNames = pirates.Select(p => p.Name);

            var piratesWithDrinks = pirates.Where(p => p.Drinks.Contains("rum"));

            var result = new List<Pirate>();
            foreach (var pirate in pirates)
            {
                if (pirate.Drinks.Contains("rum"))
                {
                    result.Add(pirate);
                }
            }

            pirates.ForEach(p => p.AddDrink("whiskey"));

            foreach (var pirate in pirates)
            {
                pirate.AddDrink("whiskey");
            }


            ExamLinq(2);
        }



        public static void ExamLinq(int frequency)
        {
            var text = File.ReadAllText("input.txt");
            char[] separators = { '\n', '\r', ' ' };
            var splitted = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var matched = splitted.GroupBy(w => w).Where(w => w.Count() == frequency);
            var result = string.Join(", ", matched.Select(w => w.Key));

            var testList = matched.ToList();
            
            matched.ToList().ForEach(w => Console.WriteLine(w.Key + " " + w.Count()));

        }


        public static void Linq()
        {
            var dictionary = new Dictionary<string, int>();
            dictionary.Add("one", 1);
            dictionary.Add("two", 2);

            // clasic query
            var twoClassic = from pair in dictionary
                             where pair.Value == 2
                             select pair.Key;

            // using lambda
            var twoLambda = dictionary.Where(pair => pair.Value == 2).Select(p => p.Key);
        }
    }
}
