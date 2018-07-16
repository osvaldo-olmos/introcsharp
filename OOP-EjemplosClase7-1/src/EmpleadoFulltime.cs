namespace empleados
{
    public class EmpleadoFulltime : Empleado
    {
        public double Sueldo;

        public EmpleadoFulltime(int DNI, string nombre, string apellido, double sueldo)
                    : base(DNI, nombre, apellido){
            
            Sueldo =sueldo;

        }

        public override double SueldoMensual()
        {
            return Sueldo;
        }
    }

}