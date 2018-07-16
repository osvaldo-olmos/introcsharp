using System;

namespace OOP_EjemplosClase7
{
    public class CuentaCorriente
    {
        protected double saldo=0;

        public double Saldo
        {
            get{ return saldo; }
        }

        public bool Extraccion(double cantidad)
        {
            if (cantidad<=0) return false;

            this.saldo -= cantidad;
            return true;
        }

        public bool Deposito(double cantidad)
        {
            Console.WriteLine("Ejecutando Deposito con un double como argumento");
            if (cantidad <=0) return false;

            this.saldo += cantidad;

            return true;
        }

        /*
         Sobrecarga erronea
         
        public int Deposito(double cantidad)
        {
            if (cantidad <=0) return 1;
            this.saldo += cantidad;
            return 0;
        }
        */

        public bool Deposito(float cantidad)
        {
            Console.WriteLine("sobrecarga con float !");
            return true;
        }
 
        public int Deposito(double cantidad, double argumento2)
        {
                Console.WriteLine("sobrecarga con double, double !");

                return 0;
        }
    
        public int Deposito(float cantidad, double argumento2)
        {
                Console.WriteLine("sobrecarga con float, double !");

                return 0;
        }

    }
}