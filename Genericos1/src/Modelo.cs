namespace Genericos1
{
    public abstract class Jugador{
        public string Nombre { get ; set; }
        public string Apellido { get ; set; }

        private string _gesto;

        public Jugador(string nombre, string apellido, string gesto){
            _gesto =gesto;
            Nombre =nombre;
            Apellido =apellido;
        }

        public string Saluda(){
            return $"{Apellido} saluda a la hinchada con {_gesto}";
        }
    }

    class Futbolista : Jugador
    {
        public short Posicion { get ; set; }
        public string PiernaHabil { get ; set; }
        public Futbolista(string nombre, string apellido, string gesto, string piernaHabil, short posicion ) : base(nombre, apellido, gesto)
        {
            Posicion =posicion;
            PiernaHabil = piernaHabil;
        }
    }
    class Basquetbolista : Jugador
    {
        public double Altura { get ; set; }
        public Basquetbolista(string nombre, string apellido, string gesto, double altura) : base(nombre, apellido, gesto)
        {
            Altura =altura;
        }
    }

    class EquipoDeFutbol{

        public EquipoDeFutbol(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get ; set; }
        public Futbolista[] Jugadores { get ; set; }

        public string SaludaALaHinchada(){
            string saludo = $"{this.Nombre} sale a la cancha.\nSaludan sus jugadores:\n";
            foreach (var item in Jugadores)
            {
               saludo += item.Saluda() + "\n";
            }
            return saludo + "\n--------------\n";
        }

    }

    class EquipoDeBasquet{

        public EquipoDeBasquet(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre { get ; set; }
        public Basquetbolista[] Jugadores { get ; set; }

        public string SaludaALaHinchada(){
            string saludo = $"{this.Nombre} sale a la cancha.\nSaludan sus jugadores:\n";
            foreach (var item in Jugadores)
            {
               saludo += item.Saluda() + "\n";
            }
            return saludo + "\n-------------\n";
        }

    }
}