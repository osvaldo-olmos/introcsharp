using System;

namespace VariablesPorReferencia
{
    public class Cliente
    {
        string nombre;

        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.nombre = "Luis";

            Cliente cliente2 = new Cliente();
            cliente2.nombre = "Hugo";

            Console.WriteLine("El Cliente 1 se llama {0}", cliente1.nombre);
            Console.WriteLine("El Cliente 2 se llama {0}", cliente2.nombre);

            Cliente clienteAux = cliente1;

            clienteAux.nombre = "Tincho";

            Console.WriteLine("El Cliente 1 se llama {0}", cliente1.nombre);
            Console.ReadLine();
        }
    }
}
