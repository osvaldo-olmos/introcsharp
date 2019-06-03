
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Cadenas1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, target;
            //byte K;
            
            Console.Write("Ingresa tu nombre : "); 
            nombre = Console.ReadLine();
            
            Console.WriteLine($"{nombre} tiene {nombre.Length} letras");

            Console.Write("Ingresa un string a buscar :"); 
            target = Console.ReadLine();

            Console.WriteLine($"{nombre}" + (nombre.Contains(target) ? " si" : " no") + $" contiene el substring {target}");

            StringBuilder strBuilder =new StringBuilder();
            for (int i = 0; i < nombre.Length; i++)
            {
                strBuilder.Append(nombre[nombre.Length -i-1]);
            }
            Console.WriteLine($"el nombre al reves es {strBuilder}");

            // Console.WriteLine("REEMPLAZO VOCAL A: " + nombre.Replace("A", "X"));
            // Console.WriteLine("EN MINUSCULAS : " + nombre.ToLower());
            // Console.WriteLine("EN MAYÚSCULAS : " + nombre.ToUpper());
            // Console.WriteLine("REMOVER 4 LETRAS : " + nombre.Remove(3, 4));
            // Console.WriteLine("EXTRAER 4 LETRAS : " + nombre.Substring(3, 4));
            // Console.WriteLine("IZQUIERDA 4 LETRAS : " + Left(nombre, 4));
            // Console.WriteLine("DERECHA 4 LETRAS : " + Right(nombre, 4));
            // Console.Write("Pulse una Tecla:"); Console.ReadLine();
            // Console.WriteLine();
            // Console.WriteLine("DESDE LA IZQUIERDA");
            // for (K = 1; K <= nombre.Length; K++)
            // {
            //     Console.WriteLine(Left(nombre, K));
            // }
            // Console.WriteLine();
            // Console.WriteLine("DESDE LA DERECHA");
            // for (K = 1; K <= nombre.Length; K++)
            // {
            //     Console.WriteLine(Right(nombre, K));
            // }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
        public static string Left(string param, int length)
        {
            string result = param.Substring(0, length);
            return result;
        }
        public static string Right(string param, int length)
        {
            int value = param.Length - length;
            string result = param.Substring(value, length);
            return result;
        }
    }
}
