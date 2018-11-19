using System;

namespace Enums
{
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
            Dias meetingDays = Dias.Martes | Dias.Jueves;
            
            // Sumo el viernes usando el OR.
            meetingDays = meetingDays | Dias.Viernes;

            Console.WriteLine("Los dias de reunion son: {0}", meetingDays);
            // Output: Martes, Jueves, Viernes

            // Quito el Martes con el XOR.
            meetingDays = meetingDays ^ Dias.Martes;
            Console.WriteLine("Los dias de reunion son: {0}", meetingDays);
            // Output: Martes, Viernes

            // Chequeando un valor usando AND.
            bool test = (meetingDays & Dias.Jueves) == Dias.Jueves;
            Console.WriteLine("Jueves {0} un dia de reunion.", test == true ? "es" : "no es");
            // Output: Jueves es un dia de reunion.
        }
    }
}
