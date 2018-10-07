using System;
using System.IO;

namespace Using
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escenario1();
            //Escenario2();
            Escenario3();
            //Escenario4();
        }

        private static void Escenario1()
        {
            var descartable = new Descartable();
            try
            {
                descartable.DoSomething();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            finally
            {
                if (descartable != null)
                {
                    (descartable as IDisposable).Dispose();
                }
            }
        }

        private static void Escenario2()
        {
            using (var descartable = new Descartable())
            {
                descartable.DoSomething();
            }
        }
        private static void Escenario3()
        {
            StreamReader sr = new StreamReader("Archivo.txt");

            try
            {            
                String line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo leer el archivo Archivo.txt");
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Dispose();
            }
        }

        private static void Escenario4()
        {
            try
            {
                using (StreamReader sr = new StreamReader("Archivo.txt"))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo leer el archivo Archivo.txt");
                Console.WriteLine(e.Message);
            }
        }
    }
}
