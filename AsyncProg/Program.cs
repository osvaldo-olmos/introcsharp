using System;
using System.Threading.Tasks;

namespace AsyncProg
{

    class Program
    {
        static Random rnd = new Random();

        static async Task<int> HijoUnoAsync(){
            int delay =rnd.Next(2000,5000);
            await Task.Delay(delay);
            System.Console.WriteLine("En HijoUno - " + DateTime.Now.ToString("HH:mm:ss:ffff"));
            return delay;
        }

        static async Task<int> HijoDosAsync(){
            int delay =rnd.Next(2000,5000);
            await Task.Delay(delay);
            System.Console.WriteLine("En HijoDos - " + DateTime.Now.ToString("HH:mm:ss:ffff"));
            return delay;
        }

        static async Task PadreAsync(){
            System.Console.WriteLine("En Padre - " + DateTime.Now.ToString("HH:mm:ss:ffff"));
            var task1 = HijoUnoAsync();
            var task2 = HijoDosAsync();
            System.Console.WriteLine("En Padre - " + DateTime.Now.ToString("HH:mm:ss:ffff"));
            var task1Result = await task1;
            var task2Result = await task2;
            System.Console.WriteLine($"En Padre - Resultado: {task1Result+ task2Result} - " + DateTime.Now.ToString("HH:mm:ss:ffff"));
        }
        static void Main(string[] args){
            var task =Task.Run(PadreAsync);
            task.Wait();
        }
    }
}
