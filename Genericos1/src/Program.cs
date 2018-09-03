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
        public string Posicion { get ; set; }
        public string PiernaHabil { get ; set; }
        public Futbolista(string nombre, string apellido, string gesto) : base(nombre, apellido, gesto)
        {
        
        }
    }
    class Basquetbolista : Jugador
    {
        public string Posicion { get ; set; }
        public Basquetbolista(string nombre, string apellido, string gesto) : base(nombre, apellido, gesto)
        {
        
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
            Futbolista player =new Futbolista("Ramon", "Medina Bello", "Levanta sus brazos");
            Futbolista player1 =new Futbolista("Joya", "Dybala", "La L de la Di Birra");

            EquipoDeFutbol team =new EquipoDeFutbol("Alto Team");
            team.Jugadores =new Futbolista[] {player, player1 };

            Console.Write(team.SaludaALaHinchada());

            Basquetbolista player2 =new Basquetbolista("Pichi", "Campana", "Pica la bola");
            Basquetbolista player3 =new Basquetbolista("Gusano", "Rodman", "Tira saludo de rappers");

            EquipoDeBasquet team1 =new EquipoDeBasquet("Drink Team");
            team1.Jugadores =new Basquetbolista[] {player2, player3 };

            Console.Write(team1.SaludaALaHinchada());
        }
    }
}
