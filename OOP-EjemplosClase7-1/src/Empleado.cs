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

        public override bool Equals(object obj)
        {
            //
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //
            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            
            // TODO: write your implementation of Equals() here
            return (obj is Empleado) && this.DNI == (obj as Empleado).DNI;
        }
        
        // override object.GetHashCode
        public override int GetHashCode()
        {
            return this.DNI;
        }

        public override string ToString()
        {
            return $"{DNI} - {Apellido}, {Nombre}";
        }
    }

}