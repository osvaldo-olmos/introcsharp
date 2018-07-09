using System;

namespace MatricesIrregulares
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los campeones del mundo separados por espacio");
            string[] campeones = Console.ReadLine().Split(" ");

            string [][] campeonatosPorCampeon = new string[campeones.Length][];

            for(int i=0; i < campeones.Length; i++){
                Console.WriteLine($"Ingrese los titulos para : {campeones[i]} separados por espacio");
                string[] campeonatos = Console.ReadLine().Split(" ");

                campeonatosPorCampeon[i] = new string[campeonatos.Length];
                for(int j=0; j < campeonatos.Length; j++)
                {
                    campeonatosPorCampeon[i][j] = campeonatos[j];
                }
            }

            for(int x=0; x < campeones.Length; x++)
            {
                Console.WriteLine($"El campeon {campeones[x]} tiene los siguientes campeonatos:\n");
                for(int y=0; y < campeonatosPorCampeon[x].Length; y++)
                {
                    Console.WriteLine($"{campeonatosPorCampeon[x][y]}");
                }
                Console.WriteLine("------------------------------------------");
            }
            

        }
    }
}
