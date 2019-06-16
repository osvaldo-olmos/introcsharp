using System;

namespace EjemploClase6
{
    public class Coche
    {
        public string Motor;
        public string Marca;
        public string Patente;

        public int Velocidad {
            get ;
            protected set;
        }

        public int Direccion;
        public int Combustible;

        public Coche(string motor, string marca, string patente)
        {
            Motor = motor;
            Marca = marca;
            Patente = patente;
            Velocidad = 0;
            Direccion = 0;
            Combustible = 100;
        }

        public void Arrancar()
        {
            Console.WriteLine("Arrrrranca!");
        }

        public void Acelerar(int kilometros)
        {
            Velocidad += kilometros;
            Console.WriteLine($"Acelerado. Velocidad actual es {Velocidad}");
        }

        public void Doblar(int grados)
        {
            Direccion += grados;
            Console.WriteLine($"Doble. Mi direccion actual es {Direccion}");
        }

        public void Frena()
        {
            Velocidad = 0;
            Console.WriteLine($"Frenos clavados!!! Velocidad actual es {Velocidad}");
        }

        public virtual void Consume(int unidades)
        {
            Combustible -= unidades;
            Console.WriteLine($"Consumiendo nafta. Combustible restante {Combustible}");
        }
    }
}