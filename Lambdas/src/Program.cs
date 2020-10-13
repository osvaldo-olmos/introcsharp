    using System;
using System.Collections.Generic;

namespace Lambdas
{
    public delegate int Operacion(int a, int b);
    public delegate void Del(string message);

    class Program
    {
        // Replacing it with a lambda
        // public static int Suma(int a, int b)
        // {
        //     int suma =a+b;
        //     Console.WriteLine($"Suma de {a} y {b} es: {suma}");
        //     return suma;
        // }

        public static int Resta(int r, int t)
        {
            int resta = r-t;
            Console.WriteLine($"Resta de {r} y {t} es: {resta}");
            return resta;
        }

        public static int Multiplicacion(int x, int y)
        {
            int multiplicacion =x * y;

            Console.WriteLine($"Multiplicacion de {x} por {y} es: {multiplicacion}");
            return multiplicacion;
        }

        // Replacing it with a lambda
        // public void DelegateMethod(string message)
        // {
        //     System.Console.WriteLine(message);
        // }

        static void RunEjemplo1(){
            
            //Instanciando a los delegados
            //Operacion mas = new Operacion(Suma);
            Operacion mas = new Operacion((x,y) =>  x + y);
            Operacion menos = new Operacion(Resta);
            Operacion por = new Operacion(Multiplicacion);

            //Invocando a los delegados
            int r1 = mas(4, 5); // r1 es igual a 9
            int r2 = menos(4, 5); // r2 es igual a -1
            int r3 = por(4, 5); // r3 es igual a 20

            //Concatentando delegados
            Operacion combinado = mas;
            combinado += por; // combinación con el operador +=

            Console.WriteLine("----------------------");
            //Ejecutando la concatenacion
            int r4 = combinado(3, 3);
        }

        static void RunEjemplo2(){
            
            //Instanciando a los delegados
            Program program =new Program();
            //Del handler = new Del(program.DelegateMethod);
            Del handler = new Del(x => Console.WriteLine(x));
            //Invocando a los delegados
            handler("Hello World");
        }

        static void RunEjemplo3(){
            string[] palabras = {"hola", "hala", "habla", "zzz"};

            BubbleSorter sorter =new BubbleSorter();
            sorter.Sort(palabras, (x, y) => x.Length > y.Length ? 1 :
                                            x.Length < y.Length ? -1 : 
                                            string.Compare(x, y));

            foreach (var item in palabras)
            {
                Console.WriteLine(item);
            }
        }

        //Replaced by lambdas
        // static int ComparoAsc(string a, string b){
        //     if(a.Length > b.Length){
        //         return 1;
        //     } else if(a.Length < b.Length){
        //         return -1;
        //     } else{
        //         return string.Compare(a,b);
        //     }
        // }

        // static int ComparoDesc(string a, string b){
        //     if(a.Length > b.Length){
        //         return -1;
        //     } else if(a.Length < b.Length){
        //         return 1;
        //     } else{
        //         return string.Compare(a,b) * -1;
        //     }
        // }


        private static void RunEjemplo4()
        {
            List<Action> actions = new List<Action>();

            //Add some actions
            for (int counter = 0; counter < 10; counter++)
            {
                actions.Add(() => Console.WriteLine($"My number is {counter}"));
            }

            //Call the actions
            foreach (var action in actions)
            {
                action();
            }            
        }


        static void Main(string[] args)
        {
            //RunEjemplo1();
            //RunEjemplo2();
            //RunEjemplo3();
            RunEjemplo4();
        }
    }
}
