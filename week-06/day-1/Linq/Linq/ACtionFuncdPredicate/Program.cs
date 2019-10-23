using System;
using System.Collections.Generic;
using System.Linq;

namespace ACtionFuncdPredicate
{
    class Program
    {
        static List<int> numbers = new List<int>() { 1, 2, 3 };

        public delegate void Greet(string name);

        static void Main(string[] args)
        {
            Greet greet = GreetUser;
            greet("esy");
            greet = GreetAdmin;
            greet("esy");
        }

        public static void GreetUser(string name)
        {
            Console.WriteLine($"Helo admin{name}");
        }

        public static void GreetAdmin(string name)
        {
            Console.WriteLine($"Helo admin{name}");
        }

        /* Action is a delegate (pointer) to a method, that takes zero, one or more input parameters, 
         but does not return anything. */
        public static void ActionExample()
        {
            Action<int> actionLambda = (int number) => Console.WriteLine("Its {0}", number);

            Action<int> actionWithBody = (int number) =>
            {
                Console.WriteLine("Its {0}", number);
            };

            actionLambda.Invoke(1);
            actionWithBody.Invoke(1);
        }

        public static void actionClassic(int number)
        {
            Console.WriteLine("Its {0}", number);
        }

        /*Func is a delegate (pointer) to a method, that takes zero, one or more input parameters, 
         and returns a value (or reference).*/
        public static void FuncTest()
        {
            Func<int, int> addOne = (int number) => number + 1;
            var resultSingle = addOne.Invoke(2);
            var test = numbers.Select(n => n);
            var result = numbers.Select(n => addOne(n));
            var resultClassic = numbers.Select(n => addOneClassic(n));
        }

        public static int addOneClassic(int number)
        {
            return number + 1;
        }

        /* Predicate is used when you want a specialized version of a Func that evaluates a value 
         against a set of criteria and returns a boolean result (true for a match, false otherwise).
         */
        public static void PredicateTest()
        {
            Predicate<int> isBiggerThanOne = (int number) => number > 1;
            var resultSingle = isBiggerThanOne.Invoke(1);



            var test = numbers.FindAll(IsBiggerThanOneClassic);




            var result = numbers.FindAll(isBiggerThanOne);
            var resultClassic = numbers.FindAll(IsBiggerThanOneClassic);
        }

        public static bool IsBiggerThanOneClassic(int number)
        {
            return number > 1;
        }
    }
}
