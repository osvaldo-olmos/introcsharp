using System;

namespace OOP
{
    class CocheAceleradorAvanzado:Coche
    {
        public CocheAceleradorAvanzado(string marca, string modelo, string color, string patente)
                                    : base(marca, modelo, color, patente) {}
    
        public override void Acelerar(double cantidad)
        {
        // Aquí se escribe el nuevo mecanismo de aceleración
            Console.WriteLine("Accionando el mecanismo avanzado de aceleración");
            Console.WriteLine("Incrementando la velocidad en {0} km/h", cantidad);
            velocidad += cantidad;
        }
    }

}