using System;

namespace Enums
{
    enum Dia { Domingo, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado };
    enum Mes : byte { Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, 
                        Septiembre, Octubre, Noviembre, Diciembre };

    class Program
    {
        static void Main(string[] args)
        {
            Dia today = Dia.Martes;
            int nroDeDia = (int)today;
            Console.WriteLine("{0} es el dia numero #{1}.", today, nroDeDia);

            Mes mesCorriente = Mes.Noviembre;
            byte mesNro = (byte)mesCorriente;
            Console.WriteLine("{0} es el mes numero #{1}.", mesCorriente, mesNro);

            //Ojo! Puedo asignar valores sin sentido !!!
            mesCorriente = (Mes) 88;
            mesNro = (byte)mesCorriente;
            Console.WriteLine("{0} es el mes numero #{1}.", mesCorriente, mesNro);


        }
    }
}
