using System.Collections.Generic;

namespace Genericos1
{
    class Equipo{

        public Equipo(string v)
        {
            this.Nombre = v;
        }

        public string Nombre { get ; set; }
        public Jugador[] Jugadores { get ; set; }

        public string SaludaALaHinchada(){
            string saludo = $"{this.Nombre} sale a la cancha.\nSaludan sus jugadores:\n";
            foreach (var item in Jugadores)
            {
               saludo += item.Saluda() + "\n";
            }
            return saludo + "\n------------\n";
        }

    }
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
            return saludo + "\n----------\n";
        }
    }
}