using System;

namespace Genericos1
{

    public class Jugador{
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
            Futbolista futbolista1 =new Futbolista("Ramon", "Medina Bello", "Levanta sus brazos", "ninguna", 7);
            Futbolista futbolista2 =new Futbolista("Joya", "Dybala", "La L del Loro", "derecha", 9);

            Basquetbolista basquetbolista1 =new Basquetbolista("Pichi", "Campana", "Pica la bola", 1.98);
            Basquetbolista basquetbolista2 =new Basquetbolista("Gusano", "Rodman", "Tira saludo gansta", 1.81);

            /*---- Solucion con equipos especificos ----------------------
            EquipoDeFutbol platense =new EquipoDeFutbol("Platense");
            platense.Jugadores = new Futbolista[] {futbolista1, futbolista2 };

            EquipoDeBasquet obras =new EquipoDeBasquet("Obras Sanitarias");
            obras.Jugadores = new Basquetbolista[] {basquetbolista1, basquetbolista2 };

            Console.Write(platense.SaludaALaHinchada());
            Console.Write(obras.SaludaALaHinchada());

*/
            //---- Solucion con herencia ----------------------
            Equipo ferro =new Equipo("Ferro");
            ferro.Jugadores = new Jugador[] {futbolista1, futbolista2, basquetbolista1 };

            Equipo atenas =new Equipo("Atenas de Cordoba");
            atenas.Jugadores = new Jugador[] {basquetbolista1, basquetbolista2, futbolista1};

            Console.Write(ferro.SaludaALaHinchada());
            Console.Write(atenas.SaludaALaHinchada());

            //---- Solucion con Genericos ----------------------
            Team<Futbolista> aldosivi =new Team<Futbolista>("Aldosivi");
            aldosivi.Jugadores.Add(futbolista1);
            aldosivi.Jugadores.Add(futbolista2);
            //aldosivi.Jugadores.Add(basquetbolista1); //Error
            
            Team<Basquetbolista> regatas =new Team<Basquetbolista>("Regatas de Corrientes");
            regatas.Jugadores.Add(basquetbolista1);
            regatas.Jugadores.Add(basquetbolista2);
            //regatas.Jugadores.Add(futbolista2); //Error

            Console.Write(aldosivi.SaludaALaHinchada());
            Console.Write(regatas.SaludaALaHinchada());
        }

    }
}
