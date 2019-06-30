using System;

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
            //---- Solucion con herencia ----------------------
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
