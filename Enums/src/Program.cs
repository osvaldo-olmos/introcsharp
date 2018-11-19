using System;

namespace Enums
{
    enum Dia { Domingo, Lunes, Martes, Miercoles, Jueves, Viernes, Sabado };
    enum Mes : byte
    {
        Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto,
        Septiembre, Octubre, Noviembre, Diciembre
    };

    [Flags]
    enum Days
    {
        None = 0x0,
        Sunday = 0x1,
        Monday = 0x2,
        Tuesday = 0x4,
        Wednesday = 0x8,
        Thursday = 0x10,
        Friday = 0x20,
        Saturday = 0x40
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TestEnums();
            //TestBitwise();
            TestEnumAndBitFlags();

        }


        static void TestEnums()
        {
            Dia today = Dia.Martes;
            int nroDeDia = (int)today;
            Console.WriteLine("{0} es el dia numero #{1}.", today, nroDeDia);

            Mes mesCorriente = Mes.Noviembre;
            byte mesNro = (byte)mesCorriente;
            Console.WriteLine("{0} es el mes numero #{1}.", mesCorriente, mesNro);

            //Ojo! Puedo asignar valores sin sentido !!!
            mesCorriente = (Mes)88;
            mesNro = (byte)mesCorriente;
            Console.WriteLine("{0} es el mes numero #{1}.", mesCorriente, mesNro);

        }

        static void TestBitwise()
        {
            int a = 60;            /* 60 = 0011 1100 */
            int b = 13;            /* 13 = 0000 1101 */
            int c = 0;

            Console.WriteLine($"a como entero es {a} - Como binario es {GetBinaryValue(a)}");
            Console.WriteLine($"b como entero es {b} - Como binario es {GetBinaryValue(b)}");

            c = a & b;             /* 12 = 0000 1100 */
            Console.WriteLine($"c = a & b es {c} - Como binario es {GetBinaryValue(c)}");

            c = a | b;             /* 61 = 0011 1101 */
            Console.WriteLine($"c = a | b es {c} - Como binario es {GetBinaryValue(c)}");

            c = a ^ b;             /* 49 = 0011 0001 */
            Console.WriteLine($"c = a ^ b es {c} - Como binario es {GetBinaryValue(c)}");

            c = ~a;                /*-61 = 1100 0011 */
            Console.WriteLine($"c = ~a es {c} - Como binario es {GetBinaryValue(c)}");

            c = a << 2;      /* 240 = 1111 0000 */
            Console.WriteLine($"c = a << 2 es {c} - Como binario es {GetBinaryValue(c)}");

            c = a >> 2;      /* 15 = 0000 1111 */
            Console.WriteLine($"c = a >> 2 es {c} - Como binario es {GetBinaryValue(c)}");
        }

        private static string GetBinaryValue(int a)
        {
            string strBinary = Convert.ToString(a, 2).PadLeft(8, '0');
            return strBinary.Substring(strBinary.Length - 8, 8);
        }


        private static void TestEnumAndBitFlags()
        {
            Days meetingDays = Days.Tuesday | Days.Thursday;
            // Set an additional flag using bitwise OR.
            meetingDays = meetingDays | Days.Friday;

            Console.WriteLine("Meeting days are {0}", meetingDays);
            // Output: Meeting days are Tuesday, Thursday, Friday

            // Remove a flag using bitwise XOR.
            meetingDays = meetingDays ^ Days.Tuesday;
            Console.WriteLine("Meeting days are {0}", meetingDays);
            // Output: Meeting days are Thursday, Friday

            // Test value of flags using bitwise AND.
            bool test = (meetingDays & Days.Thursday) == Days.Thursday;
            Console.WriteLine("Thursday {0} a meeting day.", test == true ? "is" : "is not");
            // Output: Thursday is a meeting day.
        }
    }
}
