using System;

namespace EventsSorteoExcercise
{
/*
 * Loteria: Es quien recibe las apuestas y realiza el sorteo. Una vez realizado el sorteo,
 * informar el numero ganador a todos los apostadores.
 *
 *Apostador: Apuesta un número.
 *
 *Hacer un programa implemente este modelo, generando un numero random como el numero ganador.

 */

    class Program
    {
        static void Main(string[] args)
        {
            Loteria myLotery = new Loteria();
            Apostador apostador1 =new Apostador();
            myLotery.Apuestas.Add(5);
            myLotery.ResultadoSorteo += apostador1.RecibirResultado;
            Apostador apostador2 =new Apostador();
            myLotery.Apuestas.Add(2);
            myLotery.ResultadoSorteo += apostador2.RecibirResultado;
            Apostador apostador3 =new Apostador();
            myLotery.Apuestas.Add(4);
            myLotery.ResultadoSorteo += apostador3.RecibirResultado;

            myLotery.Sortear();
        }
    }
}
