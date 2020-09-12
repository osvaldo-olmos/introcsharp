﻿using System;

namespace Delegados3
{
    class Program
    {
        static void Main(string[] args)
        {
            Emisor emisor = new Emisor("Pica bochos");

            Suscriptor susc = null;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese suscriptor:");
                Suscriptor subscriptor = new Suscriptor(Console.ReadLine());
                emisor.Suscribir(subscriptor.EventHandler);
                if (i == 2)
                {
                    susc = subscriptor;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese novedad:");
                emisor.Difundir(Console.ReadLine());
            }

            emisor.Desuscribir(susc.EventHandler);

            Console.WriteLine("Ingrese novedad:");
            emisor.Difundir(Console.ReadLine());
        }
    }
}