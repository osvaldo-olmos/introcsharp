using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClase6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Coche miCoche = new Coche("ABG2345J", "Volkswagen", "EAD555");
            Coche miCoche = new CocheElectrico("ABG2345J", "Volkswagen", "EAD555");
            miCoche.Arrancar();
            miCoche.Acelerar(20);
            miCoche.Consume(10);
            (miCoche as CocheElectrico).Consume(3);
            miCoche.Doblar(45);
            miCoche.Frena();

            Console.ReadKey();

        }
    }
}
