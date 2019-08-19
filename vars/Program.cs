using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vars
{
    class Program
    {
        //var cualquiera; //Error: solo como variables locales
        static void Main(string[] args)
        {
            var numeroElementos = 50;
            var otroNumero = 5L;
            object objetito = "object";
            objetito = 78;
            var nombre = "Pirulo";
            var x = nombre + numeroElementos; //string + int = string
            var xz = numeroElementos + nombre; //string + int = string
            var y = numeroElementos + otroNumero; //int +long
            var sb = new StringBuilder();
            var buenEstudiante = new Persona("Osvaldo");

            //var indeciso = null; //Error

            ImprimoLista();
            EjemploLoop();
        }

        private static void ImprimoLista()
        {
            var palabras = new List<string> { "hola", "hila", "hula" };
            Console.WriteLine("LIST COUNT: " + palabras.Count);
        }
        private static void EjemploLoop()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Use a query expression to get all the odd numbers from the array.
            // ... The var stores the result IEnumerable.
            // var items = from item in numbers
            //             where (item % 2 == 1)
            //             select item;

            var items = numbers.Where(x => x % 2 == 1);

            // Each item is an int.
            foreach (var item in items)
            {
                Console.WriteLine("VAR LOOP: {0}", item);
            }
            // Use the same loop but without var.
            foreach (int item in items)
            {
                Console.WriteLine("LOOP 2: {0}", item);
            }
        }
    }
}
