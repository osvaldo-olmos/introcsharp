using System;
using System.Collections.Generic;

namespace Lambdas
{

    class Program
    {

        private static void RunEjemplo1()
        {
            List<Action> actions = new List<Action>();

            //Add some actions
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"My number is {i}");
                actions.Add(() => Console.WriteLine($"My number is {i}"));
            }

            //Call the actions. Which numbers will be printed out ?
            foreach (var action in actions)
            {
                action();
            }
        }

        private static void ClosureExample()
        {
            var myVar = "this is good";

            Func<string, string> myFunc = delegate (string var1)
                                             {
                                                 return var1 + myVar;
                                             };

            Console.WriteLine(myFunc("chamame "));
        }


        static void Main(string[] args)
        {
            RunEjemplo1();
            //ClosureExample();
            //ClosureExample1();
        }

        private static void ClosureExample1()
        {
            var myFunction = GetAFunc();
            Console.WriteLine(myFunction(5));
            Console.WriteLine(myFunction(6));
        }

        public static Func<int, int> GetAFunc()
        {
            var myVar = 1;
            Func<int, int> myMethod = delegate (int param1)
                                    {
                                        myVar = myVar + 1;
                                        return param1 + myVar;
                                    };
            return myMethod;
        }
    }
}
