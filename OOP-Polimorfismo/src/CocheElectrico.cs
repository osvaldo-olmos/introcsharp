using System;

namespace Polimorfismo
{
    class CocheElectrico : Coche
    {
        public CocheElectrico(string motor, string marca, string patente)
             : base(motor, marca, patente) { }

        public override void Consume(int watts)
        {
            Combustible -= (watts*2);
            Console.WriteLine($"Consumiendo {watts} watts. Combustible restante {Combustible}");
        }
    }
}