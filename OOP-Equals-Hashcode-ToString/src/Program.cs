using System;
using System.Collections.Generic;

namespace empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpleadoFulltime empleado1 =new EmpleadoFulltime(123456, "Osvaldo", "Olmos", 100.34);
            EmpleadoFulltime empleado2 =new EmpleadoFulltime(123456, "Mario", "Mandzucick", 100000.50);
            Freelancer empleado3 = new Freelancer(1111111, "Luka", "Modric", 20.50, 100);

            List<Empleado> empleados =new List<Empleado>();
            empleados.Add(empleado1);
            empleados.Add(empleado2);
            empleados.Add(empleado3);

            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine($"El empleado: {empleado.ToString()} cobra: {empleado.SueldoMensual()}");
            }

            //Comparacion de objetos
            Console.WriteLine($"\n\nComparando {empleado1} con {empleado2}\n\n");
            Console.WriteLine($"Equals sobreescrito : {empleado1.Equals(empleado2)}");
            Console.WriteLine($"Comparando referencias: {Object.ReferenceEquals(empleado1, empleado2)}");
            Console.WriteLine($"Comparando con == : { empleado1 == empleado2 }");
        }
    }
}
