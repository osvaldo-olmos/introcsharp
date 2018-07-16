using System;
using System.Collections.Generic;

namespace empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpleadoFulltime empleado1 =new EmpleadoFulltime(123456, "Osvaldo", "Olmos", 100.34);
            EmpleadoFulltime empleado2 =new EmpleadoFulltime(999999, "Mario", "Mandzucick", 100000.50);
            Freelancer empleado3 = new Freelancer(1111111, "Luka", "Modric", 20.50, 100);

            List<Empleado> empleados =new List<Empleado>();
            empleados.Add(empleado1);
            empleados.Add(empleado2);
            empleados.Add(empleado3);

            foreach (Empleado empleado in empleados)
            {
                Console.WriteLine($"El empleado: {empleado.Apellido} cobra: {empleado.SueldoMensual()}");
            }
        }
    }
}
