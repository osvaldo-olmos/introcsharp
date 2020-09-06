using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEnums();
            //TestBitwise();
            //TestEnumAndBitFlags();
            //DiscoverEnumValues();

        }


        static void TestEnums()
        {
            
            Dia hoy = (Dia)2;
            if (Enum.IsDefined(typeof(Dia), hoy))
            {
            Console.WriteLine($"today is #{hoy}.");
            } else{
                Console.WriteLine($"{hoy} no es un número de Dia valido.");
            }

            Dia today = Dia.Martes;
            int nroDeDia = (int)today;
            Console.WriteLine("{0} es el dia numero #{1}.", today, nroDeDia);

            Mes mesCorriente = Mes.Noviembre;
            byte mesNro = (byte)mesCorriente;
            Console.WriteLine("{0} es el mes numero #{1}.", mesCorriente, mesNro);

            // Para NO asignar valores sin sentido...
            mesCorriente = (Mes)88;
            if (Enum.IsDefined(typeof(Mes), mesCorriente))
            {
                mesNro = (byte)mesCorriente;
                Console.WriteLine("{0} es el mes numero #{1}.", mesCorriente, mesNro);
            }else
            {
                Console.WriteLine($"{mesCorriente} no es un numero de mes valido.");
            }    
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
            Color ColoresValidos = Color.Azul | Color.Negro;

            // Sumo el Amarillo usando el OR.
            ColoresValidos = ColoresValidos | Color.Amarillo;

            Console.WriteLine("Los colores validos son: {0}", ColoresValidos);

            // Quito el Azul con el XOR.
            ColoresValidos = ColoresValidos ^ Color.Azul;
            Console.WriteLine("Los colores validos son: {0}", ColoresValidos);

            // Chequeando un valor usando AND.
            bool test = (ColoresValidos & Color.Negro) == Color.Negro;
            Console.WriteLine("Negro {0} un color valido.", test == true ? "es" : "no es");
        }

        private static void DiscoverEnumValues()
        {
            string s = Enum.GetName(typeof(Color), 4);
            Console.WriteLine($"El color con valor 4, tiene el nombre {s}");

            Console.WriteLine("Los posibles valores de Color son:");
            foreach (int i in Enum.GetValues(typeof(Color)))
                Console.WriteLine(i);

            Console.WriteLine("Los posibles nombres de Color son:");
            foreach (string str in Enum.GetNames(typeof(Color)))
                Console.WriteLine(str);
        }
    }
}
