using System;

namespace OOP
{
    class Coche
    {
        protected double velocidad = 0;
        public double Velocidad
        {
            get
            {
                return velocidad;
            }
        }

        public string marca;
        public string modelo;
        public string color;
        public string patente;

        public Coche(string marca, string modelo, string color, string patente)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.patente = patente;
        }

        public virtual void Acelerar(double deltaVelocidad)
        {
            // Aquí se le dice al motor que aumente las revoluciones pertinentes, y...
            Console.WriteLine("Accionando el mecanismo de aceleración por defecto");
            Console.WriteLine("Incrementando la velocidad en {0} km/h", deltaVelocidad);
            this.velocidad += deltaVelocidad;
        }

        public virtual void Girar(double grados, string direccion)
        {
            // Aquí iría el código para girar
            Console.WriteLine($"Girando el coche {grados} grados en direccion {direccion}");
        }

        public virtual void Frenar(double deltaVelocidad)
        {
            // Aquí se le dice a los frenos que actúen, y...
            Console.WriteLine("Reduciendo la velocidad en {0} km/h", deltaVelocidad);
            this.velocidad -= deltaVelocidad;
        }
    }
}