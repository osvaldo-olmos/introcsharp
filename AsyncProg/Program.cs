using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProg
{

    class Program
    {
        static Random rnd = new Random();

        static int HijoUno(){
            int delay =rnd.Next(2000,5000);
            System.Console.WriteLine($"HijoUno - voy a esperar {delay} ");
            Thread.Sleep(delay);
            System.Console.WriteLine("HijoUno Saliendo - " + DateTime.Now.ToString("HH:mm:ss:ffff"));
            return delay;
        }

        static async Task<int> HijoUnoAsync(){
            int delay =rnd.Next(2000,5000);
            System.Console.WriteLine($"HijoUno - voy a esperar {delay} ");
            await Task.Delay(delay);
            System.Console.WriteLine("HijoUno Saliendo - " + DateTime.Now.ToString("HH:mm:ss:ffff"));
            return delay;
        }

        static int HijoDos(){
            int delay =rnd.Next(2000,5000);
            System.Console.WriteLine($"HijoDos - voy a esperar {delay} ");
            Thread.Sleep(delay);
            System.Console.WriteLine("HijoDos Saliendo - " + DateTime.Now.ToString("HH:mm:ss:ffff"));
            return delay;
        }

        static async Task<int> HijoDosAsync(){
            int delay =rnd.Next(2000,5000);
            System.Console.WriteLine($"HijoDos - voy a esperar {delay} ");
            await Task.Delay(delay);
            System.Console.WriteLine("HijoDos Saliendo - " + DateTime.Now.ToString("HH:mm:ss:ffff"));
            return delay;
        }

        static void Padre(){
            DateTime inicio =DateTime.Now;
            System.Console.WriteLine("Inicio Padre -" + inicio.ToString("HH:mm:ss:ffff"));
            var task1Result = HijoUno();
            var task2Result = HijoDos();
            DateTime fin =DateTime.Now;
            TimeSpan timeSpan = fin.Subtract(inicio);
            string finStr =fin.ToString("HH:mm:ss:ffff");
            
            System.Console.WriteLine($"Padre final - {fin} - Resultado: {task1Result+ task2Result} - Tiempo {timeSpan}");
        }

        static async Task PadreAsync(){
            DateTime inicio =DateTime.Now;
            System.Console.WriteLine("Inicio Padre - " + inicio.ToString("HH:mm:ss:ffff"));
            var task1 = HijoUnoAsync();
            var task2 = HijoDosAsync();
            System.Console.WriteLine("Padre esperando - " + DateTime.Now.ToString("HH:mm:ss:ffff"));
            var task1Result = await task1;
            var task2Result = await task2;
            DateTime fin =DateTime.Now;
            TimeSpan timeSpan = fin.Subtract(inicio);
            string finStr =fin.ToString("HH:mm:ss:ffff");
            System.Console.WriteLine($"Padre final - {finStr} Resultado: {task1Result+ task2Result} - Tardo {timeSpan} ");
        }
        static void Main(string[] args){
            //Sync Approach
            Padre();

            //Async Approach
            //var task =Task.Run(PadreAsync);
            //task.Wait();
        }
    }
}
