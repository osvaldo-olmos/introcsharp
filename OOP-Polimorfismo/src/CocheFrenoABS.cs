using System;

namespace Polimorfismo
{
    internal class CocheFrenoABS : Coche
    {
        // public CocheFrenoABS(string motor, string marca, string patente)
        //     : base(motor, marca, patente) { }

        public new void Frena()
        {
            Velocidad = 0;
            Console.WriteLine($"Frenos ABS Funcionando. Velocidad actual es {Velocidad}");
        }
        public new void Consume(int watts)
        {
            Combustible -= (watts*2);
            Console.WriteLine($"Consumiendo {watts} watts. Combustible restante {Combustible}");
        }

    }
}