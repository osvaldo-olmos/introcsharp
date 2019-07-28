using System;

/*
 * Tenemos jugadores de fútbol y jugadores de básquet. Todos los jugadores tiene nombre y apellido y un gesto particular para saludar a la afición. Es la marca registrada de cada player.
 * Más allá del saludo, en cada futbolista es importante saber cuál es su posición en cancha y su pierna hábil.
 * En el caso de los basquetbolistas, lo que importa es saber su altura y como saludan
 * Cada equipo, cuando sale a la cancha, saluda a la hinchada. Haciendo delirar a las gradas. Momento único que nos regala el deporte.
 * Hacer un que cree un equipo de Fútbol y uno de Básquet. Hacer que ambos saluden a su público.
 * Implementar una solución basada en la Herencia y otra con Genéricos. Cual conviene y por que ? Justificar.
 */
namespace Genericos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Futbolista futbolista1 = new Futbolista("Ramon", "Medina Bello", "Levanta sus brazos", "ninguna", 7);
            Futbolista futbolista2 = new Futbolista("Joya", "Dybala", "La L del Loro", "derecha", 9);

            Basquetbolista basquetbolista1 = new Basquetbolista("Pichi", "Campana", "Pica la bola", 1.98);
            Basquetbolista basquetbolista2 = new Basquetbolista("Gusano", "Rodman", "Tira saludo gansta", 1.81);

            //DoApproachOne(futbolista1, futbolista2, basquetbolista1, basquetbolista2);

            //DoApproachTwo(futbolista1, futbolista2, basquetbolista1, basquetbolista2);

            DoApproachThree(futbolista1, futbolista2, basquetbolista1, basquetbolista2);
        }

        private static void DoApproachOne(Futbolista futbolista1, Futbolista futbolista2, Basquetbolista basquetbolista1, Basquetbolista basquetbolista2)
        {
            //---- Solucion con equipos especificos ----------------------
            EquipoDeFutbol platense = new EquipoDeFutbol("Platense");
            platense.Jugadores = new Futbolista[] { futbolista1, futbolista2 };

            EquipoDeBasquet obras = new EquipoDeBasquet("Obras Sanitarias");
            obras.Jugadores = new Basquetbolista[] { basquetbolista1, basquetbolista2 };

            Console.Write(platense.SaludaALaHinchada());
            Console.Write(obras.SaludaALaHinchada());
        }
        private static void DoApproachTwo(Futbolista futbolista1, Futbolista futbolista2, Basquetbolista basquetbolista1, Basquetbolista basquetbolista2)
        {
            //---- Solucion con herencia en los jugadores y un contenedor del tipo base ----------------------
            Equipo ferro = new Equipo("Ferro");
            ferro.Jugadores = new Jugador[] { futbolista1, futbolista2, basquetbolista1 };

            Equipo atenas = new Equipo("Atenas de Cordoba");
            atenas.Jugadores = new Jugador[] { basquetbolista1, basquetbolista2, futbolista1 };

            Console.Write(ferro.SaludaALaHinchada());
            Console.Write(atenas.SaludaALaHinchada());
        }
        private static void DoApproachThree(Futbolista futbolista1, Futbolista futbolista2, Basquetbolista basquetbolista1, Basquetbolista basquetbolista2)
        {
            //---- Solucion con Genericos ----------------------
            Equipo<Futbolista> aldosivi = new Equipo<Futbolista>("Aldosivi");
            aldosivi.Jugadores.Add(futbolista1);
            aldosivi.Jugadores.Add(futbolista2);
            //aldosivi.Jugadores.Add(basquetbolista1); //Error

            Equipo<Basquetbolista> regatas = new Equipo<Basquetbolista>("Regatas de Corrientes");
            regatas.Jugadores.Add(basquetbolista1);
            regatas.Jugadores.Add(basquetbolista2);
            //regatas.Jugadores.Add(futbolista2); //Error

            Console.Write(aldosivi.SaludaALaHinchada());
            Console.Write(regatas.SaludaALaHinchada());
        }
    }
}
