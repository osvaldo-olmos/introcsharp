using System.Collections.Generic;

namespace Genericos1
{
    public class Equipo<T> where T : Jugador
    {
        public string Nombre { get;}
        public List<T> Jugadores {get;}

        public Equipo(string nombre)
        {
            Nombre =nombre;
            Jugadores =new List<T>();
        }

        public string SaludaALaHinchada(){
            string saludo = $"{this.Nombre} sale a la cancha.\nSaludan sus jugadores:\n";
            foreach (var item in Jugadores)
            {
               saludo += item.Saluda() + "\n";
            }
            return saludo;
        }
    }

    public class Team
    {
        public string Nombre { get;}
        public List<Jugador> Jugadores {get;}

        public Team(string nombre)
        {
            Nombre =nombre;
            Jugadores =new List<Jugador>();
        }

        public string SaludaALaHinchada(){
            string saludo = $"{this.Nombre} sale a la cancha.\nSaludan sus jugadores:\n";
            foreach (var item in Jugadores)
            {
               saludo += item.Saluda() + "\n";
            }
            return saludo;
        }
    }
}