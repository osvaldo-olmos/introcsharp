using System;

namespace EjemploClase6
{
    public class CocheElectrico : Coche
    {
        public CocheElectrico(string motor, string marca, string patente)
            : base(motor, marca, patente) { }

        public override void Consume(int unidades)
        {
            Combustible -= (unidades*2);
            Console.WriteLine($"Consumiendo ELECTRICIDAD. Combustible restante {Combustible}");
        }
    }
}