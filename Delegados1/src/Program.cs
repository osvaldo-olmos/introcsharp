using System;
using System.Threading;

/*
 * Delegate as a Callback
 */
namespace Delegados1
{
    public delegate void Del(string message);

    class Worker{
        public void DoAndThenCallback(int param1, int param2, Del callback)
        {
            Console.WriteLine(this + " : Doing...");
            callback("The number is: " + (param1 + param2).ToString());
            Console.WriteLine("Soy Asincrono ?");
        }
    }

    class Program
    {
        public void CallbackMethod(string message)
        {
            Console.WriteLine(this + ": Executing callback !!!");
            System.Console.WriteLine(message);
            Thread.Sleep(5000);
        }

        static void Main(string[] args)
        {
            Program program =new Program();
            Worker worker =new Worker();
            
            Console.WriteLine("Executing main !!!");

            worker.DoAndThenCallback(4, 5, program.CallbackMethod);
        }
    }
}
