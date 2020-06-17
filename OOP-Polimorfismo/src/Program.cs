using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Coche miCochecito = new Coche("ABG2345J", "Volkswagen", "EAD555");
            Coche miCochecito = new Coche{
                Patente ="ABG2345J",
                Marca = "Volkswagen",
                Motor = "EAD555"
            };

            //Pero si es de la clase derivada que pasa con el consumo ???
            CocheElectrico miCoche = new CocheElectrico("ABG2345J", "Volkswagen", "EAD555");
            //Coche miCoche = new CocheElectrico("ABG2345J", "Volkswagen", "EAD555");
            CocheFrenoABS miCocheABS = new CocheFrenoABS("ABG2345J", "Volkswagen", "EAD555");
            //Coche miCocheABS = new CocheFrenoABS("ABG2345J", "Volkswagen", "EAD555");
            miCoche.Arrancar();
            miCoche.Acelerar(20);
            (miCoche as Coche).Consume(10); //Consume esta sobreescrito, por eso se llama al de la clase derivada
            miCoche.Consume(3);
            miCochecito.Consume(50);
            miCoche.Doblar(45);
            miCocheABS.Frena();
            (miCocheABS as Coche).Frena(); //Como Frena no está sobreescrito, se llama al de la clase padre.

            Console.ReadKey();

        }
    }
}
