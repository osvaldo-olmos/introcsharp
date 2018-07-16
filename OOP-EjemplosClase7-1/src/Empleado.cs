namespace empleados
{
    public abstract class Empleado
    {
        public int DNI{get;}
        public string Nombre{get;}
        public string Apellido{get;}

        protected Empleado(int DNI, string nombre, string apellido){
            this.DNI =DNI;
            Nombre =nombre;
            Apellido = apellido;

        }

        public abstract double SueldoMensual();
    }

}