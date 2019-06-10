using System;

namespace OOP_EjemplosClase7
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaCorriente cuenta =new CuentaCorriente();

            cuenta.Deposito(20.53);
            cuenta.Deposito(20.53F);

            Console.WriteLine($"El límite de la Visa debito es: {VisaDebito.LimiteDiario()}");

        }
    }
}
