using System;

namespace Delegates3WaysToDeclare
{
    // Declare a delegate.
    delegate void Printer(string s);

    class Program
    {
        static void DoWork(string k)
        {
            System.Console.WriteLine(k);
        }

        static void Main()
        {
            // The delegate instantiation using a named method "DoWork".
            Printer p = new Printer(DoWork);
            
            //Invoking the delegate
            p("named method invoke");

            // Instantiate the delegate type using an anonymous method.
            p = delegate(string j)
            {
                System.Console.WriteLine(j);
            };

            // Results from the anonymous delegate call.
            p("The delegate using the anonymous method is called.");

            // Instantiate the delegate type using a lambda.
            p = x => System.Console.WriteLine(x);

            // Results from the anonymous delegate call.
            p("The delegate using a lambda function.");

        }
    }
}
