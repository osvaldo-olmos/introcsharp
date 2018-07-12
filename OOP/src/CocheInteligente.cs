using System;

namespace OOP
{
    class CocheInteligente :Coche
    {
        public CocheInteligente(string marca, string modelo, string color, string patente)
                                : base(marca, modelo, color, patente) {}
    
        public void Estacionar()
        {
            // Aquí se escribe el código para que el coche estacione solo
            Console.WriteLine("Estacionando el coche de modo automático");
            this.velocidad = 0;
        }
    }
   
}
