using System;

namespace EvaluacionPerezosa
{
    class Program
    {
        static void Main(string[] args)
        {

            if(EvalLeft(false) && EvalRight(true)){
                Console.WriteLine("Complete eval is true");
            }

            if(EvalLeft(false) & EvalRight(true)){
                Console.WriteLine("Complete eval is true");
            }

        }

        private static bool EvalRight(bool value)
        {
            Console.WriteLine("Eval Right");
            return value;;
        }

        private static bool EvalLeft(bool value)
        {
            Console.WriteLine("Eval Left");
            return value;
        }
    }
}
