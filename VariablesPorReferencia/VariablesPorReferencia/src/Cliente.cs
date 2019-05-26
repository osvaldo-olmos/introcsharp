using System;

namespace VariablesPorReferencia
{
    public class Cliente
    {
        string nombre= "Default";

        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.nombre = "Luis";

            Cliente cliente2 = new Cliente();
            cliente2.nombre = "Hugo";

            Console.WriteLine("El Cliente 1 se llama {0}", cliente1.nombre);
            Console.WriteLine("El Cliente 2 se llama {0}", cliente2.nombre);

            ModificaClientes(ref cliente1, cliente2);

            Console.WriteLine("El Cliente 1 se llama {0}", cliente1.nombre);
            Console.WriteLine("El Cliente 2 se llama {0}", cliente2.nombre);
            Console.ReadLine();
        }

        private static void ModificaClientes(ref Cliente cliente1, Cliente cliente2)
        {
            //Modifico el valor de la referencia
            cliente1 = new Cliente();

            //Modifico el estado del objeto (que pasa por referencia)
            cliente2.nombre = "Pepe";
        }
    }
}
