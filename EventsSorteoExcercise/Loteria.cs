using System;
using System.Collections.Generic;
using System.Threading;

namespace EventsSorteoExcercise
{
    public class Loteria
    {
        public List<int> Apuestas = new List<int>();

        public event EventHandler<string> ResultadoSorteo;

        public void Sortear()
        {
            Random rnd = new Random();
            bool _sinGanadores = true;
            int i = 0;
            do
            {
                Console.WriteLine($"--- Sorteo nro {++i} ---");
                int numero = rnd.Next(1, 5); //TODO: Para enganchar ganadores, redujo el rango de posibles resultados
                string message;
                if (Apuestas.Contains(numero))
                {
                    message = $"Gano el numero  [[[ {numero} ]]] !!!!";
                    _sinGanadores = false;
                }
                else
                {
                    message = $"Salio el numero [[[ {numero} ]]] !!!! Pozo vacaaaaanteeee";
                }
                ResultadoSorteo?.Invoke(this, message);
                Thread.Sleep(2000);
            } while (_sinGanadores);
        }

    }
}