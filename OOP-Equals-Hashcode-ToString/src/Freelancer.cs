namespace empleados
{
    public class Freelancer : Empleado
    {
        public double ValorHora;
        public int HorasMensuales;

        public Freelancer(int DNI, string nombre, string apellido, double valorHora, int horasMensuales)
                    : base(DNI, nombre, apellido)
        {
            ValorHora =valorHora;
            HorasMensuales =horasMensuales;
        }

        public override double SueldoMensual()
        {
            return ValorHora * HorasMensuales;
        }
    }

}