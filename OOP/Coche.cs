using System;

namespace OOP
{
    class Coche
    {
            protected double velocidad=0;
            public double Velocidad
            {
            get
                {
                    return velocidad;
                }
            }

            public string Marca;
            public string Modelo;
            public string Color;
            public string Patente;

        public Coche(string marca, string modelo, string color, string patente)
        {
                Marca =marca;
                Modelo =modelo;
                Color =color;
                Patente =patente;
        }
    
        public virtual void Acelerar(double cantidad)
        {
        // Aquí se le dice al motor que aumente las revoluciones pertinentes, y...
            Console.WriteLine("Accionando el mecanismo de aceleración por defecto");
            Console.WriteLine("Incrementando la velocidad en {0} km/h", cantidad);
        this.velocidad += cantidad;
        }
    
        public virtual void Girar(double cantidad)
        {
            // Aquí iría el código para girar
            Console.WriteLine("Girando el coche {0} grados", cantidad);
        }
    
        public virtual void Frenar(double cantidad)
        {
            // Aquí se le dice a los frenos que actúen, y...
            Console.WriteLine("Reduciendo la velocidad en {0} km/h", cantidad);
            this.velocidad -= cantidad;
        }
    }
}