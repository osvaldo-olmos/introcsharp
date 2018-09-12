using System;

namespace Genericos1
{

    class Jugador{
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

        public EquipoDeFutbol(string v)
        {
            this.Nombre = v;
        }

        public string Nombre { get ; set; }
        public Futbolista[] Jugadores { get ; set; }

        public string SaludaALaHinchada(){
            string saludo = $"{this.Nombre} sale a la cancha.\nSaludan sus jugadores:\n";
            foreach (var item in Jugadores)
            {
               saludo += item.Saluda() + "\n";
            }
            return saludo;
        }

    }

    class EquipoDeBasquet{

        public EquipoDeBasquet(string v)
        {
            this.Nombre = v;
        }

        public string Nombre { get ; set; }
        public Basquetbolista[] Jugadores { get ; set; }

        public string SaludaALaHinchada(){
            string saludo = $"{this.Nombre} sale a la cancha.\nSaludan sus jugadores:\n";
            foreach (var item in Jugadores)
            {
               saludo += item.Saluda() + "\n";
            }
            return saludo;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Futbolista player =new Futbolista("Ramon", "Medina Bello", "Levanta sus brazos", "ninguna", 7);
            Futbolista player1 =new Futbolista("Joya", "Dybala", "La L del Loro", "derecha", 9);

            EquipoDeFutbol team =new EquipoDeFutbol("Alto Team");
            team.Jugadores =new Futbolista[] {player, player1 };

            Console.Write(team.SaludaALaHinchada());

            Basquetbolista player2 =new Basquetbolista("Pichi", "Campana", "Pica la bola", 1.98);
            Basquetbolista player3 =new Basquetbolista("Gusano", "Rodman", "Tira saludo gansta", 1.81);

            EquipoDeBasquet team1 =new EquipoDeBasquet("Drink Team");
            team1.Jugadores =new Basquetbolista[] {player2, player3 };

            Console.Write(team1.SaludaALaHinchada());
        }
    }
}
